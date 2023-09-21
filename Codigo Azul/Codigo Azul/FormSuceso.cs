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
		private Usuario usuarioSeleccionado;
		
		public FormSuceso( Suceso FSuceso,ClassConexionSQL fconexion)
		{
			oSuceso = FSuceso;
			InitializeComponent();
		}

		
		void FormSucesoLoad(object sender, EventArgs e)
		{
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_tipo");
			
			cargarComboEstado();
			cargarComboOrigen();
			cargarComboTipo();
			cargarComboSala();
			
			if (ds != null && ds.Tables.Count > 0)
			{
				if(Nuevo==true)
				{
					lblNumero.Text="Nuevo suceso";
					dtp_fecha.Enabled=false; 
					cbxEstado.Enabled=true;
					cbxOrigen.Enabled=true;
				}
				else if(Edicion==true){
					dtp_fecha.Enabled=false;
					lblNumero.Text="Suceso Nº"+oSuceso.Id;
					dtp_fecha.Value=oSuceso.FechaInicio;
					cbxSala.Text=oSuceso.Sala;
					txtUsuario.Text=oSuceso.Medico;
					txtPaciente.Text=oSuceso.Nombre +" "+ oSuceso.Apellido;
					lbl_dni1.Text=oSuceso.Dni.ToString();
					lbl_obra_social1.Text=oSuceso.ObraSocial;
					lbl_grupo_sanguineo1.Text=oSuceso.GrupoSanguineo;
					richTextBox1.Text=oSuceso.Descripcion;
					
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
		
		void BtnBuscarUsuarioClick(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario(); // Crea una instancia de Pacientes
			FormUsuario formUsuario = new FormUsuario(usuario,miconexion);
			
			// Muestra el formulario de pacientes
			formUsuario.ShowDialog();

			// Verifica si el usuario aceptó los cambios en el formulario de pacientes
			if (formUsuario.DialogResult == DialogResult.OK)
			{
				usuarioSeleccionado = usuario;
				txtUsuario.Text = usuarioSeleccionado.Nombre;

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
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM sala ORDER BY sala_descripcion");
			
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
//	            	   @suce_area_id INT,
//					    @suce_suti_id INT,
//					    @suce_sues_id INT,
//					    @suce_paci_id INT,
//					    @suce_usua_id INT,
//					    @suce_suor_id INT,
//					    @suce_descripcion VARCHAR(MAX),
//					    @suce_fecha_ini DATETIME,
//					    @suce_paci_sala_id INT
	            	string fecha = dtp_fecha.Value.ToString("yyyyMMdd HH:mm:ss"); 
	                parametros = oSuceso.SuceAreaId + ", " + oSuceso.SuceSutiId + ", " + cbxEstado.SelectedValue + ", " +
	                	pacienteSeleccionado.ID + ", " + usuarioSeleccionado.ID + ", " + oSuceso.SuceSuorId + ", '" +
	                    richTextBox1.Text + "', '" + fecha + "', " +
	                    oSuceso.SucePaciSalaId;
	                
	                // Prepara la consulta de inserción
	                query = "exec sp_InsertarSuceso " + parametros;
	            }
//	            else
//	            {
//	                // Para una edición, construye la cadena de parámetros
//	                parametros = oSuceso.Id + ", " + tuValorSuceAreaId + ", " + tuValorSuceSutiId + ", " +
//	                    tuValorSuceSuesId + ", " + tuValorSucePaciId + ", " + tuValorSuceUsuaId + ", " +
//	                    tuValorSuceSuorId + ", '" + richTextBox1.Text + "', '" +
//	                    dtp_fecha.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " + tuValorSucePaciSalaId;
//	                
//	                // Prepara la consulta de actualización
//	                query = "exec sp_ActualizarSuceso " + parametros;
//	            }
	
	            // Ejecuta la consulta utilizando el método EjecutarSentencia
	            DataSet filasAfectadas = miconexion.EjecutarSentencia(query);
//	            int filasafectadas=int.Parse(filasAfectadas.ToString());
//	
//	            if (filasafectadas > 0)
//	            {
//	                MessageBox.Show("Suceso guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
//	            }
//	            else
//	            {
//	                MessageBox.Show("No se pudo guardar el suceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//	            }
		        
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Error al guardar el suceso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		    }
		}

	
		void Btn_aceptarClick(object sender, EventArgs e)
		{
			GuardarSuceso();
		}
		
	}
}
