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

		
		public FormSuceso(Suceso FSuceso, ClassConexionSQL fconexion)
		{
			oSuceso = FSuceso;
			miconexion = fconexion;
			InitializeComponent();
		}
		
		void Limpiar(){
			cbxEstado.SelectedIndex = -1;
			cbxOrigen.SelectedIndex = -1;
			cbxSala.SelectedIndex 	= -1;
			cbxTipo.SelectedIndex 	= -1;
			cbxArea2.SelectedIndex 	= -1;
			txtDescripcion.Text		= "";
			txtPaciente.Text 		= "";
			txtUsuario.Text 		= "";
		}

		
		void FormSucesoLoad(object sender, EventArgs e)
		{
			usuarioSeleccionado = new Usuario();
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_tipo");
			Limpiar();
			cargarComboEstado();
			cargarComboOrigen();
			cargarComboArea();
			cargarComboTipo();
			cargarComboSala();
			
			if (ds != null && ds.Tables.Count > 0)
			{
				if(Edicion)
				{
					lblNumero.Text	  = "Suceso Nº"+oSuceso.Id;
					
					dtp_fecha.Enabled       = false;
					cbxEstado.Enabled       = false;
					cbxOrigen.Enabled       = true;
					
					dtp_fecha.Value         = oSuceso.FechaInicio;
					txtUsuario.Text			= oSuceso.Medico;
					txtPaciente.Text		= oSuceso.Nombre +" "+ oSuceso.Apellido;
					lbl_dni1.Text			= oSuceso.Dni.ToString();
					lbl_obra_social1.Text	= oSuceso.ObraSocial;
					lbl_grupo_sanguineo1.Text = oSuceso.GrupoSanguineo;
					txtDescripcion.Text		= oSuceso.Descripcion;
					

					
					//carga combo area
					for (int i = 0; i < cbxArea2.Items.Count; i++)
					{
						if (cbxArea2.GetItemText(cbxArea2.Items[i]) == oSuceso.SuceAreaDescripcion)
						{
							cbxArea2.SelectedIndex = i;
							break;
						}
					}
					//carga combo tipo
					for (int i = 0; i < cbxTipo.Items.Count; i++)
					{
						if (cbxTipo.GetItemText(cbxTipo.Items[i]) == oSuceso.Tipo)
						{
							cbxTipo.SelectedIndex = i;
							break;
						}
					}
					
					//carga combo estado
					for (int i = 0; i < cbxEstado.Items.Count; i++)
					{
						if (cbxEstado.GetItemText(cbxEstado.Items[i]) == oSuceso.Estado)
						{
							cbxEstado.SelectedIndex = i;
							break;
						}
					}
					
					//carga combo origen
					for (int i = 0; i < cbxOrigen.Items.Count; i++)
					{
						if (cbxOrigen.GetItemText(cbxOrigen.Items[i]) == oSuceso.Origen)
						{
							cbxOrigen.SelectedIndex = i;
							break;
						}
					}
					//carga combo sala
					for (int i = 0; i < cbxSala.Items.Count; i++)
					{
						if (cbxSala.GetItemText(cbxSala.Items[i]) == oSuceso.Sala)
						{
							cbxSala.SelectedIndex = i;
							break;
						}
					}

				}
				else if(Nuevo){
					Limpiar();
					oSuceso.SuceSuorId = 2;//manual
					oSuceso.SuceSuesId = 1;//pendiente
					oSuceso.SuceSutiId = 1;//normal
					
					cbxOrigen.SelectedValue	 = oSuceso.SuceSuorId;
					cbxEstado.SelectedValue	 = oSuceso.SuceSuesId;
					cbxTipo.SelectedValue	 = oSuceso.SuceSutiId;
					
					btnCancelar.Enabled   	= true;
					btnAceptar.Enabled 	   	= true;
					pnlDatos.Enabled 	   	= true;
					
					dtp_fecha.Enabled	   	= false;
					lblNumero.Text			= "Nuevo suceso";
					
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
				oSuceso.SucePaciId = pacienteSeleccionado.ID;

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
			DataSet ds = miconexion.EjecutarSentencia("SELECT area_id, area_descripcion FROM Area where area_id <> 0 order by area_descripcion ");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxArea2.DataSource = ds.Tables[0];
				cbxArea2.DisplayMember = "area_descripcion";
				cbxArea2.ValueMember = "area_id";
			}
			cbxArea2.SelectedIndexChanged += CbxArea_SelectedIndexChanged;
			cargarComboSala();
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
			try{
				string i = cbxArea2.SelectedValue.ToString();
				
				DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM sala INNER JOIN area ON area_id = sala_area_id WHERE sala_area_id ="+i+" ORDER BY sala_descripcion");
				
				if (ds != null && ds.Tables.Count > 0)
				{
					cbxSala.DataSource = ds.Tables[0];
					cbxSala.DisplayMember = "sala_descripcion";
					cbxSala.ValueMember = "sala_id";
				}
			}catch{}
		}
		
		bool GuardarSuceso()
		{
			try
			{
				string query="";
				string parametros;
				
				if (Nuevo)
				{
					parametros = cbxArea2.SelectedValue + ", " + cbxTipo.SelectedValue + ", " + cbxEstado.SelectedValue + ", " +
						pacienteSeleccionado.ID + ", " + usuarioSeleccionado.ID + ", " + cbxOrigen.SelectedValue+ ", '" +
						txtDescripcion.Text + "', "+ cbxSala.SelectedValue;
					
					query = "exec sp_InsertarSuceso " + parametros;
				}
				else if(Edicion)
				{
					
					parametros = oSuceso.Id +", " + cbxArea2.SelectedValue + ", " + cbxTipo.SelectedValue + ", " + cbxEstado.SelectedValue + ", " +
						oSuceso.SucePaciId + ", " + usuarioSeleccionado.ID + ", " + cbxOrigen.SelectedValue+ ", '" +
						txtDescripcion.Text + "', " + cbxSala.SelectedValue + ", ''";
					
					query = "exec sp_ActualizarSuceso " + parametros;
					
				}
				
				// Ejecuta la consulta utilizando el método EjecutarSentencia
				DataSet filasAfectadas = miconexion.EjecutarSentencia(query);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar el suceso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		void CbxArea_SelectedIndexChanged(object sender, EventArgs e)
		{
			cargarComboSala();
		}
		
		void Btn_aceptarClick(object sender, EventArgs e)
		{
			GuardarSuceso();
			this.Close();
		}
		void BtnBuscarUsuarioClick(object sender, EventArgs e)
		{
			FormUsuario frmUsuario = new FormUsuario(usuarioSeleccionado,miconexion);
			frmUsuario.ShowDialog();
			if (frmUsuario.DialogResult== DialogResult.OK){
				txtUsuario.Text = usuarioSeleccionado.Nombre + ' ' + usuarioSeleccionado.Apellido;
				oSuceso.SuceUsuaId = usuarioSeleccionado.ID;
			}
			
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
			//si el usuario o el paciente no fueron seleccionados no dejo continuar el guardado
			if ( (oSuceso.SucePaciId == -1) || (oSuceso.SuceUsuaId ==-1) ){
				MessageBox.Show("Debe seleccionar un usuario y un paciente válidos","Error");
			}else{
				GuardarSuceso();
				this.DialogResult = DialogResult.Cancel;
			}
			
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		
	}
}
