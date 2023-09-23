using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Codigo_Azul
{
	public partial class FormSuceso : Form
	{
		public bool Nuevo,Edicion;
		private Suceso oSuceso;
		public ClassConexionSQL miconexion;
		private Paciente pacienteSeleccionado;

		
		public FormSuceso(Suceso FSuceso, ClassConexionSQL fconexion)
		{
		    oSuceso = FSuceso;
		    miconexion = fconexion; // Asegúrate de asignar la instancia de ClassConexionSQL aquí
		    InitializeComponent();
		    
		    cbxArea.SelectedIndexChanged += CbxArea_SelectedIndexChanged;
		}

		
		void FormSucesoLoad(object sender, EventArgs e)
		{
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_tipo");
			
			cargarComboEstado(); 
			cargarComboOrigen();
			cargarComboArea();
			cargarComboTipo();
			cargarComboSala();
			
			if (ds != null && ds.Tables.Count > 0)
			{
				if(Edicion==true)
				{
					lblNumero.Text="Suceso Nº"+oSuceso.Id;
					
					dtp_fecha.Enabled=false; 
					cbxEstado.Enabled=true;
					cbxOrigen.Enabled=true;

				}
				else if(Nuevo==true){
					dtp_fecha.Enabled=false;
					lblNumero.Text="Nuevo suceso";
					dtp_fecha.Value=oSuceso.FechaInicio;
					txtUsuario.Text=oSuceso.Medico;
					txtPaciente.Text=oSuceso.Nombre +" "+ oSuceso.Apellido;
					lbl_dni1.Text=oSuceso.Dni.ToString();
					lbl_obra_social1.Text=oSuceso.ObraSocial;
					lbl_grupo_sanguineo1.Text=oSuceso.GrupoSanguineo;
					richTextBox1.Text=oSuceso.Descripcion;
					
					for (int i = 0; i < cbxArea.Items.Count; i++)
					{
						if (cbxArea.GetItemText(cbxArea.Items[i]) == oSuceso.SuceAreaDescripcion)
						{
							cbxArea.SelectedIndex = i;
							break;
						}
					}
					
					for (int i = 0; i < cbxTipo.Items.Count; i++)
					{
						if (cbxTipo.GetItemText(cbxTipo.Items[i]) == oSuceso.Tipo)
						{
							cbxTipo.SelectedIndex = i;
							break;
						}
					}
					
					for (int i = 0; i < cbxEstado.Items.Count; i++)
					{
						if (cbxEstado.GetItemText(cbxEstado.Items[i]) == oSuceso.Estado)
						{
							cbxEstado.SelectedIndex = i;
							break;
						}
					}
					
					for (int i = 0; i < cbxOrigen.Items.Count; i++)
					{
						if (cbxOrigen.GetItemText(cbxOrigen.Items[i]) == oSuceso.Origen)
						{
							cbxOrigen.SelectedIndex = i;
							break;
						}
					}
					
					for (int i = 0; i < cbxSala.Items.Count; i++)
					{
						if (cbxSala.GetItemText(cbxSala.Items[i]) == oSuceso.Sala)
						{
							cbxSala.SelectedIndex = i;
							break;
						}
					}
					
				}
			}
			
		}
		void BtnBuscarPacienteClick(object sender, EventArgs e)
		{
			Paciente paciente = new Paciente(); // Crea una instancia de Pacientes
			FormPacientes formPacientes = new FormPacientes(paciente,miconexion);
			
			// Muestra el formulario de pacientes
			formPacientes.ShowDialog();

			// Verifica si el usuario aceptó los cambios en el formulario de pacientes
			if (formPacientes.DialogResult == DialogResult.OK)
			{
				pacienteSeleccionado = paciente;
				txtPaciente.Text = pacienteSeleccionado.Nombre + ' ' + pacienteSeleccionado.Apellido;
				
				lbl_dni1.Text = pacienteSeleccionado.Dni;
				lbl_grupo_sanguineo1.Text = pacienteSeleccionado.GrupoSanguineo;
				lbl_obra_social1.Text = pacienteSeleccionado.ObraSocialDescripcion;

			}
		}
		
		void cargarComboEstado(){
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_estado ORDER BY sues_descripcion");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxEstado.DataSource = ds.Tables[0];
				cbxEstado.DisplayMember = "sues_descripcion";
				cbxEstado.ValueMember = "sues_id";
			}
		}
		
		void cargarComboArea(){
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM Area order by area_descripcion");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxArea.DataSource = ds.Tables[0];
				cbxArea.DisplayMember = "area_descripcion";
				cbxArea.ValueMember = "area_id";
			}
		}
		
		void cargarComboOrigen(){
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_origen ORDER BY suor_descripcion");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxOrigen.DataSource = ds.Tables[0];
				cbxOrigen.DisplayMember = "suor_descripcion";
				cbxOrigen.ValueMember = "suor_id";
			}
		}
		
		void cargarComboTipo(){
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_tipo ORDER BY suti_descripcion");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxTipo.DataSource = ds.Tables[0];
				cbxTipo.DisplayMember = "suti_descripcion";
				cbxTipo.ValueMember = "suti_id";
			}
		}
		
		void cargarComboSala(){
			string i = cbxArea.SelectedValue.ToString();
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM sala INNER JOIN area ON area_id = sala_area_id WHERE sala_area_id ="+i+" ORDER BY sala_descripcion");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxSala.DataSource = ds.Tables[0];
				cbxSala.DisplayMember = "sala_descripcion";
				cbxSala.ValueMember = "sala_id";
			}
		}
		
		private void GuardarSuceso()
		{
		    try
		    {
	            string query="";
	            string parametros;
	
	            if (Nuevo)
	            {
	            	string fecha = dtp_fecha.Value.ToString("yyyyMMdd HH:mm:ss"); 
	            	parametros = cbxArea.SelectedValue + ", " + cbxTipo.SelectedValue + ", " + cbxEstado.SelectedValue + ", " +
	                	pacienteSeleccionado.ID + ", " + usuarioSeleccionado.ID + ", " + cbxOrigen.SelectedValue+ ", '" +
	                    richTextBox1.Text + "', '" + fecha + "', " +
	                    cbxSala.SelectedValue;
	         
	                query = "exec sp_InsertarSuceso " + parametros;
	            }
	            else if(Edicion)
	            {
//				string parametros = "'" +txtNombre.Text+"', '"+ txtApellido.Text + "', " + txtDni.Text +", '" + txtGrupoSanguineo.Text + "', " +
//					Convert.ToInt32(cbxObraSocial.SelectedValue) + ", " + Convert.ToInt32(cbxciudad.SelectedValue) + ", " + Convert.ToInt32(cbxProvincia.SelectedValue) + ", '"
//					+ txtTelefono.Text + "', '" + txtEmail.Text + "', '" + txtDireccion.Text + "', 1";
//
//				miConexion.EjecutarSentencia("exec sp_InsertarPaciente " + parametros);
	            }
	
	            // Ejecuta la consulta utilizando el método EjecutarSentencia
	            DataSet filasAfectadas = miconexion.EjecutarSentencia(query);
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Error al guardar el suceso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		    }
		}


		private void CbxArea_SelectedIndexChanged(object sender, EventArgs e)
		{
		    cargarComboSala();
		}
	
		void Btn_aceptarClick(object sender, EventArgs e)
		{
			GuardarSuceso();
			this.Close();
		}
		
	}
}
