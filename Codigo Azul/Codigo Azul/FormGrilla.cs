using System;
using System.Drawing;
using System.Windows.Forms;

namespace Codigo_Azul
{
	public partial class FormGrilla : Form
	{
		
		ClassConexionSQL miConexion;
		Suceso miSuceso;
		Area fArea;
		Sala fSala;
		public FormGrilla()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void FormGrillaLoad(object sender, EventArgs e)
		{
//			//crear el objeto conexion
			miConexion = new ClassConexionSQL();
			miSuceso=new Suceso();
//
//			//crear la conexion indicando el nombre de la base de datos que vamos a usar
			miConexion.CrearConexion("codigo_azul");
			dgv_sucesos.AutoGenerateColumns = false;
			miConexion.LLenarGrid(ref dgv_sucesos, "exec sp_ObtenerSucesosGrilla");
			
			//cargar la grilla con un select, se le pasa como 1er parametro el datagridview y como 2do parametro la consulta con la que queremos llenar ese grid
//			miConexion.LLenarGrid(ref dataGridView1, "select * from suceso");
			timer1.Start();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			miConexion.LLenarGrid(ref dgv_sucesos, "exec sp_ObtenerSucesosGrilla");
		}
		

		void btnNuevoClick(object sender, EventArgs e)
		{
			FormSuceso form = new FormSuceso(miSuceso,miConexion);
			form.miconexion = this.miConexion;
			form.Nuevo=true;
			form.ShowDialog();
		}
		
		void Btn_reportesClick(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://192.168.1.103:3000");
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
				miSuceso.Id=int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
				miSuceso.Estado=filaSeleccionada.Cells["estado"].Value.ToString();
				miSuceso.FechaInicio=DateTime.Parse(filaSeleccionada.Cells["FechaInicio"].Value.ToString());
				miSuceso.Tipo=filaSeleccionada.Cells["Tipo"].Value.ToString();
				miSuceso.Descripcion=filaSeleccionada.Cells["Descripcion"].Value.ToString();
				miSuceso.Sala=filaSeleccionada.Cells["Sala"].Value.ToString();
				miSuceso.Nombre=filaSeleccionada.Cells["Nombre"].Value.ToString();
				miSuceso.Apellido=filaSeleccionada.Cells["Apellido"].Value.ToString();
				miSuceso.Dni=int.Parse(filaSeleccionada.Cells["Dni"].Value.ToString());
				miSuceso.GrupoSanguineo=filaSeleccionada.Cells["GrupoSanguineo"].Value.ToString();
				miSuceso.ObraSocial=filaSeleccionada.Cells["ObraSocial"].Value.ToString();
				miSuceso.Origen=filaSeleccionada.Cells["Origen"].Value.ToString();
				miSuceso.Medico=filaSeleccionada.Cells["Medico"].Value.ToString();
				miSuceso.SuceAreaId=int.Parse(filaSeleccionada.Cells["SuceAreaId"].Value.ToString());
				miSuceso.SuceSuesId=int.Parse(filaSeleccionada.Cells["SuceSuesId"].Value.ToString());
				miSuceso.SucePaciId=int.Parse(filaSeleccionada.Cells["SucePaciId"].Value.ToString());
				miSuceso.SuceSutiId=int.Parse(filaSeleccionada.Cells["SuceSutiId"].Value.ToString());
				miSuceso.SuceUsuaId=int.Parse(filaSeleccionada.Cells["SuceUsuaId"].Value.ToString());
				miSuceso.SuceSuorId=int.Parse(filaSeleccionada.Cells["SuceSuorId"].Value.ToString());
				miSuceso.SucePaciSalaId=int.Parse(filaSeleccionada.Cells["SucePaciSalaId"].Value.ToString());
	
				
				FormSuceso form = new FormSuceso(miSuceso,miConexion);
				form.miconexion = this.miConexion;
				
				form.Edicion=true;
				form.ShowDialog();
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
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


		
		void Button1Click(object sender, EventArgs e)
		{
			fSala = new Sala();

			FormSala aFormSala = new FormSala(fSala,miConexion);
			aFormSala.ShowDialog();
		}
		

		void Btn_nueva_areaClick(object sender, EventArgs e)
		{
			fArea = new Area();

			FormArea aFormArea = new FormArea(fArea,miConexion);
			aFormArea.Show();		
		}
	}
}
