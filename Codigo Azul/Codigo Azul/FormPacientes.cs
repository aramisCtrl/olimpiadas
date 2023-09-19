/*
 * Created by SharpDevelop.
 * User: jerem
 * Date: 17/9/2023
 * Time: 12:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Codigo_Azul
{
	
	/// <summary>
	/// Description of FormPacientes.
	/// </summary>
	public partial class FormPacientes : Form
	{
		private bool Nuevo,Edicion;
		private Paciente oPaciente;
		private ClassConexionSQL miConexion;
		BindingSource bindingSource = new BindingSource();
		
		public FormPacientes(Paciente fPaciente ,ClassConexionSQL fconexion)
		{
			InitializeComponent();
			this.oPaciente = fPaciente;
			this.miConexion = fconexion;
		}
		void cargarComboCiudad(){
			DataSet ds = miConexion.EjecutarSentencia("SELECT * FROM ciudad");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxciudad.DataSource = ds.Tables[0];
				cbxciudad.DisplayMember = "ciud_descripcion";
				cbxciudad.ValueMember = "ciud_id";
			}
		}
		void Limpiar(){
			//valores defecto si no hay registros en la grilla
			txtNombre.Text = "";
			txtApellido.Text = "";
			txtDireccion.Text = "";
			txtDni.Text = "";
			txtEmail.Text = "";
			txtGrupoSanguineo.Text = "";
			txtTelefono.Text = "";
			cbxciudad.SelectedIndex = -1;
			cbxObraSocial.SelectedIndex = -1;
			cbxProvincia.SelectedIndex = -1;
			
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

		void cargarComboProvincia(){
			DataSet ds = miConexion.EjecutarSentencia("SELECT * FROM provincia");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxProvincia.DataSource = ds.Tables[0];
				cbxProvincia.DisplayMember = "prov_descripcion";
				cbxProvincia.ValueMember = "prov_id";
			}
		}
		void cargarComboObraSocial(){
			DataSet ds = miConexion.EjecutarSentencia("SELECT * FROM obra_social");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxObraSocial.DataSource = ds.Tables[0];
				cbxObraSocial.DisplayMember = "obso_descripcion";
				cbxObraSocial.ValueMember = "obso_id";
			}
		}
		void BtnSeleccionarClick(object sender, EventArgs e)
		{
			//HOLA
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void cargarGrilla(){
			DataSet ds = miConexion.EjecutarSentencia("exec sp_ObtenerPacientesGrilla");
			
			gridDatos.AutoGenerateColumns = false;
			bindingSource.DataSource = ds.Tables[0]; // ds es tu DataSet
			gridDatos.DataSource = bindingSource;
			
		}
		void FormPacientesLoad(object sender, EventArgs e)
		{
			cargarComboProvincia();
			cargarComboCiudad();
			cargarComboObraSocial();
//			miConexion.LLenarGrid(ref gridDatos, "exec sp_ObtenerPacientesGrilla");
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
				oPaciente.CiudadID=Convert.ToInt32(cbxProvincia.SelectedValue);
				oPaciente.ObraSocialID = Convert.ToInt32(cbxObraSocial.SelectedValue);
				oPaciente.ProvinciaID = Convert.ToInt32(cbxProvincia.SelectedValue);
				oPaciente.ID = Convert.ToInt32(filaSeleccionada.Cells["paci_id"].Value.ToString());
				oPaciente.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
				oPaciente.Apellido =filaSeleccionada.Cells["Apellido"].Value.ToString();
				oPaciente.Direccion =filaSeleccionada.Cells["Direccion"].Value.ToString();
				oPaciente.Dni = filaSeleccionada.Cells["Dni"].Value.ToString();
				oPaciente.Email= filaSeleccionada.Cells["Email"].Value.ToString();
				oPaciente.GrupoSanguineo =  filaSeleccionada.Cells["GrupoSanguineo"].Value.ToString();
				oPaciente.Telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
				oPaciente.ObraSocialDescripcion = filaSeleccionada.Cells["obso_descripcion"].Value.ToString();
				oPaciente.CiudadNombre = cbxciudad.Text;
				oPaciente.ProvinciaNombre = cbxProvincia.Text;
				

				//Actualiza los componentes visuales
				txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
				txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
				txtDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
				txtDni.Text = filaSeleccionada.Cells["Dni"].Value.ToString();
				txtEmail.Text = filaSeleccionada.Cells["Email"].Value.ToString();
				txtGrupoSanguineo.Text = filaSeleccionada.Cells["GrupoSanguineo"].Value.ToString();
				txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
				
				
				string Ciudad = gridDatos.SelectedRows[0].Cells["Ciudad"].Value.ToString();
				for (int i = 0; i < cbxciudad.Items.Count; i++)
				{
					if (cbxciudad.GetItemText(cbxciudad.Items[i]) == Ciudad)
					{
						cbxciudad.SelectedIndex = i;
						break;
					}
				}
				
				string ObraSocial = gridDatos.SelectedRows[0].Cells["ObraSocial"].Value.ToString();
				for (int i = 0; i < cbxObraSocial.Items.Count; i++)
				{
					if (cbxObraSocial.GetItemText(cbxObraSocial.Items[i]) == ObraSocial)
					{
						cbxObraSocial.SelectedIndex = i;
						break;
					}
				}
				
				string Provincia = gridDatos.SelectedRows[0].Cells["Provincia"].Value.ToString();
				for (int i = 0; i < cbxProvincia.Items.Count; i++)
				{
					if (cbxProvincia.GetItemText(cbxProvincia.Items[i]) == Provincia)
					{
						cbxProvincia.SelectedIndex = i;
						break;
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
			string filtro = "paci_nombre LIKE '%"+valorBusqueda+"%' OR paci_apellido LIKE '%"+valorBusqueda+"%'";

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
				string parametros = oPaciente.ID + ", '" +txtNombre.Text+"', '"+ txtApellido.Text + "', " + txtDni.Text +
					", '" + txtGrupoSanguineo.Text + "', " + Convert.ToInt32(cbxObraSocial.SelectedValue) + ", " + Convert.ToInt32(cbxciudad.SelectedValue) + ", " + Convert.ToInt32(cbxProvincia.SelectedValue) + ", '"
					+ txtTelefono.Text + "', '" + txtEmail.Text + "', '" + txtDireccion.Text + "', 1";

				miConexion.EjecutarSentencia("exec sp_ActualizarPaciente " + parametros);
			}else if (Nuevo){
				string parametros = "'" +txtNombre.Text+"', '"+ txtApellido.Text + "', " + txtDni.Text +", '" + txtGrupoSanguineo.Text + "', " +
					Convert.ToInt32(cbxObraSocial.SelectedValue) + ", " + Convert.ToInt32(cbxciudad.SelectedValue) + ", " + Convert.ToInt32(cbxProvincia.SelectedValue) + ", '"
					+ txtTelefono.Text + "', '" + txtEmail.Text + "', '" + txtDireccion.Text + "', 1";

				miConexion.EjecutarSentencia("exec sp_InsertarPaciente " + parametros);
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
	}
}
