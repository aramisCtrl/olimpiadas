using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace Codigo_Azul
{
	public partial class FormUsuario : Form
	{
		private bool Nuevo,Edicion;
		private Usuario oUsuario;
		private ClassConexionSQL miConexion;
		BindingSource bindingSource = new BindingSource();
		
		public FormUsuario(Usuario fUsuario ,ClassConexionSQL fconexion)
		{
			InitializeComponent();
			this.oUsuario = fUsuario;
			this.miConexion = fconexion;
		}
		
		void Limpiar(){
			//valores defecto si no hay registros en la grilla
			txtNombre.Text = "";
			txtApellido.Text = "";
			txtUser.Text = "";
			txtContraseña.Text = "";
			cbxRol.SelectedIndex = -1;
			cbxArea.SelectedIndex = -1;
		}
		void IniciarEdicion(){
			Edicion 			   = true;
			btnCancelar.Enabled    = true;
			btnAceptar.Enabled 	   = true;
			pnlData.Enabled 	   = true;
			
			Nuevo 			       = false;
			btnNuevo.Enabled	   = false;
			pnlMid.Enabled 		   = false;
			pnlTop.Enabled 		   = false;
			btnEditar.Enabled      = false;
			btnSeleccionar.Enabled = false;
		}
		
		void IniciarSeleccion(){
			Edicion 			= false;
			btnCancelar.Enabled = false;
			btnAceptar.Enabled 	= false;
			pnlData.Enabled 	= false;
			
			Nuevo 			    = false;
			btnNuevo.Enabled	= true;
			pnlMid.Enabled 		= true;
			pnlTop.Enabled 		= true;
			btnEditar.Enabled      = true;
			btnSeleccionar.Enabled = true;
		}
		
		void IniciarNuevo(){
			Nuevo 			   	   = true;
			btnCancelar.Enabled    = true;
			btnAceptar.Enabled 	   = true;
			pnlData.Enabled 	   = true;
			
			Edicion  		       = false;
			btnNuevo.Enabled	   = false;
			pnlMid.Enabled 		   = false;
			pnlTop.Enabled 		   = false;
			btnEditar.Enabled      = false;
			btnSeleccionar.Enabled = false;
		}
		
		void cargarComboRol(){
			DataSet ds = miConexion.EjecutarSentencia("SELECT * FROM Rol");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxRol.DataSource = ds.Tables[0];
				cbxRol.DisplayMember = "rol_nombre";
				cbxRol.ValueMember = "rol_id";
			}
		}
		
		void cargarComboArea(){
			DataSet ds = miConexion.EjecutarSentencia("SELECT * FROM Area");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxArea.DataSource = ds.Tables[0];
				cbxArea.DisplayMember = "area_descripcion";
				cbxArea.ValueMember = "area_id";
			}
		}
		
		void BtnSeleccionarClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void cargarGrilla(){
			DataSet ds = miConexion.EjecutarSentencia("exec sp_ObtenerUsuarios");
			
			gridDatos.AutoGenerateColumns = false;
			bindingSource.DataSource = ds.Tables[0]; // ds es tu DataSet
			gridDatos.DataSource = bindingSource;
			
		}
		
		void FormUsuarioLoad(object sender, EventArgs e)
		{
			cargarComboArea();
			cargarComboRol();
//			miConexion.LLenarGrid(ref gridDatos, "exec sp_ObtenerUsuariosGrilla");
			cargarGrilla();
			IniciarSeleccion();
		}
		
		void GridDatosSelectionChanged(object sender, EventArgs e)
		{
			if (gridDatos.SelectedRows.Count > 0)
			{
				// Obtén la fila seleccionada actualmente
				DataGridViewRow filaSeleccionada = gridDatos.SelectedRows[0];
				
				// Actualiza los datos del objeto Pacientes con los valores del formulario
				oUsuario.RolID=Convert.ToInt32(cbxRol.SelectedValue);
				oUsuario.AreaID = Convert.ToInt32(cbxArea.SelectedValue);
				oUsuario.ID = Convert.ToInt32(filaSeleccionada.Cells["usua_id"].Value.ToString());
				oUsuario.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
				oUsuario.Apellido =filaSeleccionada.Cells["Apellido"].Value.ToString();
				oUsuario.User =filaSeleccionada.Cells["User"].Value.ToString();
				oUsuario.Contraseña = filaSeleccionada.Cells["usua_contraseña"].Value.ToString();
				

				//Actualiza los componentes visuales
				txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
				txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
				txtUser.Text = filaSeleccionada.Cells["User"].Value.ToString();
				txtContraseña.Text = filaSeleccionada.Cells["usua_contraseña"].Value.ToString();
				
				if (filaSeleccionada.Cells["Area"].Value != null){
					string Area = filaSeleccionada.Cells["Area"].Value.ToString();
					for (int i = 0; i < cbxArea.Items.Count; i++)
					{
						if (cbxArea.GetItemText(cbxArea.Items[i]) == Area)
						{
							cbxArea.SelectedIndex = i;
							break;
						}
					}
				}
				if (filaSeleccionada.Cells["Rol"].Value != null){
					string Rol = filaSeleccionada.Cells["Rol"].Value.ToString();
					for (int i = 0; i < cbxRol.Items.Count; i++)
					{
						if (cbxRol.GetItemText(cbxRol.Items[i]) == Rol)
						{
							cbxRol.SelectedIndex = i;
							break;
						}
					}
				}
			}
			else
			{
				//valores defecto si no hay registros en la grilla
				Limpiar();
			}
			
		}
		
		
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			string valorBusqueda = txtBuscar.Text;

			// Crear un filtro que sea insensible a mayúsculas y minúsculas
			string filtro = "usua_nombre LIKE '%"+valorBusqueda+"%' OR usua_apellido LIKE '%"+valorBusqueda+"%'";

			// Aplicar el filtro al BindingSource
			bindingSource.Filter = filtro;
			
			if (txtBuscar.Text ==""){
				bindingSource.Filter = "";
			}

		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			IniciarEdicion();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(Edicion){
				// Construye la cadena de parámetros
				string parametros = oUsuario.ID + ", '" +txtNombre.Text+"', '"+ txtApellido.Text + "', '" + txtUser.Text +
					"', '" + txtContraseña.Text + "', " + Convert.ToInt32(cbxRol.SelectedValue) + ", " + Convert.ToInt32(cbxArea.SelectedValue) + " ";

				miConexion.EjecutarSentencia("exec sp_ActualizarUsuario " + parametros);
			}else if (Nuevo){
				string parametros = "'" +txtNombre.Text+"', '"+ txtApellido.Text + "', '" + txtUser.Text +"', '" + txtContraseña.Text + "', " +
					Convert.ToInt32(cbxRol.SelectedValue) + ", " + Convert.ToInt32(cbxArea.SelectedValue) + "";

				miConexion.EjecutarSentencia("exec sp_InsertarUsuario " + parametros);
			}
			//recargo la grilla
			cargarGrilla();
			IniciarSeleccion();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			IniciarSeleccion();
			GridDatosSelectionChanged(null,e);
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			IniciarNuevo();
			Limpiar();
		}
		void GridDatosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		
	}
}
