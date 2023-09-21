/*
 * Created by SharpDevelop.
 * User: TaielGamerR
 * Date: 18/09/2023
 * Time: 21:55
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
	/// Description of FormArea.
	/// </summary>
	public partial class FormArea : Form
	{
		private ClassConexionSQL miConexion;
		private Area oArea;
		private bool Nuevo,Edicion;
		BindingSource bindingSource = new BindingSource();
		public FormArea(Area fArea ,ClassConexionSQL fconexion)
		{

			InitializeComponent();
			this.oArea = fArea;
			this.miConexion = fconexion;

		}
		void cargarComboSala(){
			DataSet ds = miConexion.EjecutarSentencia("SELECT * FROM sala");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxsala.DataSource = ds.Tables[0];
				cbxsala.DisplayMember = "sala_descripcion";
				cbxsala.ValueMember = "sala_id";
			}
		}
		void cargarGrilla(){
			DataSet ds = miConexion.EjecutarSentencia("exec sp_ObtenerAreas");
			
			gridDatos.AutoGenerateColumns = false;
			bindingSource.DataSource = ds.Tables[0]; // ds es tu DataSet
			gridDatos.DataSource = bindingSource;
			
		}
		void Limpiar(){
			//valores defecto si no hay registros en la grilla
			txtNombre.Text = "";
			
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
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void FormAreaLoad(object sender, EventArgs e)
		{
			cargarComboSala();
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
		
		void GridDatosSelectionChanged(object sender, EventArgs e)
		{
//			if (gridDatos.SelectedRows.Count > 0)
//			{
//				// Obtén la fila seleccionada actualmente
//				DataGridViewRow filaSeleccionada = gridDatos.SelectedRows[0];
//				
//				// Actualiza los datos del objeto Pacientes con los valores del formulario
//				oArea.ID = Convert.ToInt32(filaSeleccionada.Cells["area_id"].Value.ToString());
//				oArea.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
//				
//
//				//Actualiza los componentes visuales
//				txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
//				
//				
//				string Sala = gridDatos.SelectedRows[0].Cells["Sala"].Value.ToString();
//				for (int i = 0; i < cbxsala.Items.Count; i++)
//				{
//					if (cbxsala.GetItemText(cbxsala.Items[i]) == Sala)
//					{
//						cbxsala.SelectedIndex = i;
//						break;
//					}
//				}
//				
//			}
//			else
//			{
//				//valores defecto si no hay registros en la grilla
//				Limpiar();
//			}
			
		}
		
		void BtnSeleccionarClick(object sender, EventArgs e)
		{
			
			this.DialogResult = DialogResult.OK;
			this.Close();			
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			IniciarEdicion();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(Edicion){
				// Construye la cadena de parámetros
				string parametros = oArea.ID + ", '" +txtNombre.Text+"', '"+/*falta id sala*/ "', " /*falta texto (speech)*/;

				miConexion.EjecutarSentencia("exec sp_ActualizarArea " + parametros);
			}else if (Nuevo){
				string parametros = "'" +txtNombre.Text+"', '"+"', "+/*falta id sala*/ "', " /*falta texto (speech)*/;

				miConexion.EjecutarSentencia("exec sp_InsertarArea " + parametros);
			}
			//recargo la grilla
			cargarGrilla();
			IniciarSeleccion();			
		}
		
		void GridDatosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
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
	}
}
