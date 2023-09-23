using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Codigo_Azul
{
	public partial class FormSala : Form
	{
		private bool Nuevo,Edicion;
		private Sala oSala;
		private ClassConexionSQL miConexion;
		BindingSource bindingSource = new BindingSource();
		
		public FormSala(Sala fSala ,ClassConexionSQL fconexion)
		{
			InitializeComponent();
			this.oSala = fSala;
			this.miConexion = fconexion;
		}
		
		void Limpiar(){
			//valores defecto si no hay registros en la grilla
			txtNombre.Text = "";
			cbxArea.SelectedIndex = -1;
		}
		void IniciarEdicion(){
			Edicion 			   = true;
			btnCancelar.Enabled    = true;
			btnAceptar.Enabled 	   = true;
			pnlData.Enabled 	   = true;
			Nuevo 			       = false;
			btnNuevo.Enabled	   = false;
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
			pnlTop.Enabled 		   = false;
			btnEditar.Enabled      = false;
			btnSeleccionar.Enabled = false;
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
			DataSet ds = miConexion.EjecutarSentencia("exec sp_ObtenerSalaGrilla");
			
			gridDatos.AutoGenerateColumns = false;
			bindingSource.DataSource = ds.Tables[0]; // ds es tu DataSet
			gridDatos.DataSource = bindingSource;
			
		}
		
		void FormUsuarioLoad(object sender, EventArgs e)
		{
			cargarComboArea();
			cargarGrilla();
			IniciarSeleccion();
		}
		
		void GridDatosSelectionChanged(object sender, EventArgs e)
		{
			if (gridDatos.SelectedRows.Count > 0)
			{
				// Obtén la fila seleccionada actualmente
				DataGridViewRow filaSeleccionada = gridDatos.SelectedRows[0];
				
				// Actualiza los datos del objeto Sala con los valores del formulario
				oSala.AreaID = Convert.ToInt32(cbxArea.SelectedValue);
				oSala.ID = Convert.ToInt32(filaSeleccionada.Cells["sala_area_id"].Value.ToString());
				oSala.Descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();
				
				//Actualiza los componentes visuales
				txtNombre.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
				
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
			string filtro = "sala_descripcion LIKE '%"+valorBusqueda+"%'";

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
				string parametros = oSala.ID + ", '" +txtNombre.Text+ "', "+ Convert.ToInt32(cbxArea.SelectedValue);

				miConexion.EjecutarSentencia("exec sp_ActualizarSala " + parametros);
			}else if (Nuevo){
				string parametros = "'" +txtNombre.Text+"', "+ Convert.ToInt32(cbxArea.SelectedValue);
				miConexion.EjecutarSentencia("exec sp_InsertarSala " + parametros);
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
		
		void FormSalaLoad(object sender, EventArgs e)
		{
			cargarComboArea();
			cargarGrilla();
			IniciarSeleccion();			
		}
	}
}
