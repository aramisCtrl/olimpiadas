using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Codigo_Azul
{
	public partial class FormGrilla : Form
	{
		int indiceFilaSeleccionada=-1;
		ClassConexionSQL miConexion;
		Suceso fSuceso;
		BindingSource bindingSource = new BindingSource();

		Sala fSala;
		Area fArea;
		Usuario fUsuario;

		public FormGrilla()
		{
			InitializeComponent();
		}
		
		void cargarGrilla(){
			DataSet ds = miConexion.EjecutarSentencia("exec sp_ObtenerSucesosGrilla");
			
			dgv_sucesos.AutoGenerateColumns = false;
			bindingSource.DataSource = ds.Tables[0]; // ds es tu DataSet
			dgv_sucesos.DataSource = bindingSource;
			
		}
		
		void FormGrillaLoad(object sender, EventArgs e)
		{
//			//crear el objeto conexion
			miConexion = new ClassConexionSQL();
			fSuceso=new Suceso();
//
//			//crear la conexion indicando el nombre de la base de datos que vamos a usar
			miConexion.CrearConexion();
			dgv_sucesos.AutoGenerateColumns = false;
//			miConexion.LLenarGrid(ref dgv_sucesos, "exec sp_ObtenerSucesosGrilla");
			cargarGrilla();
			
			//cargar la grilla con un select, se le pasa como 1er parametro el datagridview y como 2do parametro la consulta con la que queremos llenar ese grid
//			miConexion.LLenarGrid(ref dataGridView1, "select * from suceso");
			timer1.Start();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (dgv_sucesos.SelectedRows.Count > 0)
			{
				indiceFilaSeleccionada = dgv_sucesos.SelectedRows[0].Index;
			}
			miConexion.LLenarGrid(ref dgv_sucesos, "exec sp_ObtenerSucesosGrilla");
			dgv_sucesos.ClearSelection();
			if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dgv_sucesos.Rows.Count)
			{
				bindingSource.Position = indiceFilaSeleccionada;
				dgv_sucesos.Rows[indiceFilaSeleccionada].Selected = true;
				dgv_sucesos.CurrentCell = dgv_sucesos.Rows[indiceFilaSeleccionada].Cells[0];
			}
			

		}
		

		void btnNuevoClick(object sender, EventArgs e)
		{
			FormSuceso form = new FormSuceso(fSuceso,miConexion);
			form.Nuevo=true;
			form.Edicion=false;
			form.ShowDialog();
		}
		
		void Btn_reportesClick(object sender, EventArgs e)
		{
			try
			{

//				System.Diagnostics.Process.Start("http://192.168.1.103:3000/public/dashboard/af5d4d6d-6de8-4e8e-a859-e892714436c6");
				System.Diagnostics.Process.Start(miConexion.UrlMetabase);				

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al abrir la URL: " + ex.Message);
			}
		}
		
		//Doble click
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
			if (dgv_sucesos.SelectedRows.Count > 0)
			{
				//Obtén la fila seleccionada actualmente
				DataGridViewRow filaSeleccionada = dgv_sucesos.SelectedRows[0];
				
				// Actualiza los datos del objeto Suceso con los valores del formulario
				fSuceso.Id				= int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
				fSuceso.Estado			= filaSeleccionada.Cells["estado"].Value.ToString();
				fSuceso.FechaInicio		= DateTime.Parse(filaSeleccionada.Cells["FechaInicio"].Value.ToString());
				fSuceso.FechaAtendido	= DateTime.Parse(filaSeleccionada.Cells["FechaAtendido"].Value.ToString());
				fSuceso.Tipo			= filaSeleccionada.Cells["Tipo"].Value.ToString();
				fSuceso.Descripcion		= filaSeleccionada.Cells["Descripcion"].Value.ToString();
				fSuceso.Sala			= filaSeleccionada.Cells["Sala"].Value.ToString();
				fSuceso.Nombre			= filaSeleccionada.Cells["Nombre"].Value.ToString();
				fSuceso.Apellido		= filaSeleccionada.Cells["Apellido"].Value.ToString();
				fSuceso.Dni				= int.Parse(filaSeleccionada.Cells["Dni"].Value.ToString());
				fSuceso.GrupoSanguineo	= filaSeleccionada.Cells["GrupoSanguineo"].Value.ToString();
				fSuceso.ObraSocial		= filaSeleccionada.Cells["ObraSocial"].Value.ToString();
				fSuceso.Origen			= filaSeleccionada.Cells["Origen"].Value.ToString();
				fSuceso.Medico			= filaSeleccionada.Cells["Medico"].Value.ToString();

				if (filaSeleccionada.Cells["SuceAreaId"].Value != DBNull.Value){
					fSuceso.SuceAreaId=int.Parse(filaSeleccionada.Cells["SuceAreaId"].Value.ToString());
				}else{
					fSuceso.SuceAreaId=-1;
				}
				if (filaSeleccionada.Cells["SuceSuesId"].Value != DBNull.Value){
					fSuceso.SuceSuesId=int.Parse(filaSeleccionada.Cells["SuceSuesId"].Value.ToString());
				}else{
					fSuceso.SuceSuesId=-1;
				}
				if (filaSeleccionada.Cells["SucePaciId"].Value != DBNull.Value){
					fSuceso.SucePaciId=int.Parse(filaSeleccionada.Cells["SucePaciId"].Value.ToString());
				}else{
					fSuceso.SucePaciId=-1;
				}
				
				if (filaSeleccionada.Cells["SuceSutiId"].Value != DBNull.Value){
					fSuceso.SuceSutiId=int.Parse(filaSeleccionada.Cells["SuceSutiId"].Value.ToString());
				}else{
					fSuceso.SuceSutiId=-1;
				}
				if (filaSeleccionada.Cells["SuceUsuaId"].Value != DBNull.Value){
					fSuceso.SuceUsuaId=int.Parse(filaSeleccionada.Cells["SuceUsuaId"].Value.ToString());
				}else{
					fSuceso.SuceUsuaId=-1;
				}
				if (filaSeleccionada.Cells["SuceSuorId"].Value != DBNull.Value){
					fSuceso.SuceSuorId=int.Parse(filaSeleccionada.Cells["SuceSuorId"].Value.ToString());
				}else{
					fSuceso.SuceSuorId=-1;
				}
				if (filaSeleccionada.Cells["SucePaciSalaId"].Value != DBNull.Value){
					fSuceso.SucePaciSalaId=int.Parse(filaSeleccionada.Cells["SucePaciSalaId"].Value.ToString());
				}else{
					fSuceso.SucePaciSalaId=-1;
				}
				fSuceso.SuceAreaDescripcion=filaSeleccionada.Cells["SuceAreaDescripcion"].Value.ToString();
				
				FormSuceso form = new FormSuceso(fSuceso,miConexion);
				form.miconexion = this.miConexion;
				
				form.Nuevo=false;
				form.Edicion=true;
				form.ShowDialog();
			}
		}
		
		
		//Color azul
		void DataGridView1DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			var gridView = (DataGridView)sender;
			var tipo = "Emergencia";
			var estado = "Pendiente";
			Color color = Color.LightBlue;
			Color colorAux = Color.White;
			
			foreach (DataGridViewRow row in gridView.Rows)
			{
				if (row.Cells["Tipo"].Value.ToString() == tipo && row.Cells["Estado"].Value.ToString() == estado)
				{
					row.DefaultCellStyle.BackColor = color;
				}
				else
				{
					row.DefaultCellStyle.BackColor = colorAux;
				}
			}
		}

		void Btn_nueva_areaClick(object sender, EventArgs e)
		{
			fArea = new Area();
			FormArea FormArea = new FormArea(fArea,miConexion);
			FormArea.ShowDialog();
		}
		
		void BtnSalaClick(object sender, EventArgs e)
		{
			fSala = new Sala();
			FormSala aFormSala = new FormSala(fSala,miConexion);
			aFormSala.ShowDialog();
		}
		
		void Btn_alarmaClick(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Desea crear una alarma para el Area " +  miConexion.AreaPuesto +"?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				miConexion.EjecutarSentencia("exec sp_InsertarSucesoAlarmaCodigoAzul " + miConexion.AreaPuesto);
			}					
		}
		
		void Dgv_sucesosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		void ToolTip_botonesPopup(object sender, PopupEventArgs e)
		{
			
		}
		void BtnCerrarSucesoClick(object sender, EventArgs e)
		{
			MessageBox.Show("Sin hacer");
		}
		void BtnUusariosClick(object sender, EventArgs e)
		{
			fUsuario = new Usuario();
			FormUsuario aFormUsuario = new FormUsuario(fUsuario,miConexion);
			aFormUsuario.ShowDialog();
		}
	}
}
