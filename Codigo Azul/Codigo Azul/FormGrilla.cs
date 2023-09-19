using System;
using System.Drawing;
using System.Windows.Forms;

namespace Codigo_Azul
{
	public partial class FormGrilla : Form
	{
	
		ClassConexionSQL miConexion;
		Suceso miSuceso;
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
			dataGridView1.AutoGenerateColumns = false;
			miConexion.LLenarGrid(ref dataGridView1, "exec sp_ObtenerSucesosGrilla");
			
			//cargar la grilla con un select, se le pasa como 1er parametro el datagridview y como 2do parametro la consulta con la que queremos llenar ese grid
//			miConexion.LLenarGrid(ref dataGridView1, "select * from suceso");
			timer1.Start();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			miConexion.LLenarGrid(ref dataGridView1, "exec sp_ObtenerSucesosGrilla");
		}
		

		void Button1Click(object sender, EventArgs e)
		{
			FormSuceso form = new FormSuceso(miSuceso,miConexion);
			form.miconexion = this.miConexion;
			form.Nuevo=true;
			form.Show();
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
		
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
			//Obtén la fila seleccionada actualmente
			DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
					
			// Actualiza los datos del objeto Pacientes con los valores del formulario
//					oSuceso.Estado=Convert.ToInt32(cbxProvincia.SelectedValue);
//					oSuceso.FechaInicio = Convert.ToInt32(cbxObraSocial.SelectedValue);
//					oSuceso.Tipo = Convert.ToInt32(cbxProvincia.SelectedValue);
//					oSuceso.Descripcion = Convert.ToInt32(filaSeleccionada.Cells["paci_id"].Value.ToString());
//					oSuceso.Sala = filaSeleccionada.Cells["Nombre"].Value.ToString();
//					oSuceso.Nombre =filaSeleccionada.Cells["Apellido"].Value.ToString();
//					oSuceso.Apellido =filaSeleccionada.Cells["Direccion"].Value.ToString();
//					oSuceso.Dni = filaSeleccionada.Cells["Dni"].Value.ToString();
//					oSuceso.GrupoSanguineo =  filaSeleccionada.Cells["GrupoSanguineo"].Value.ToString();
//					oSuceso.ObraSocialDescripcion = filaSeleccionada.Cells["obso_descripcion"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["Estado"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["FechaInicio"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["Tipo"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["Descripcion"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["Sala"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["Nombre"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["Apellido"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["Dni"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["GrupoSanguineo"].Value.ToString();
			miSuceso.Estado=filaSeleccionada.Cells["ObraSocial"].Value.ToString();
				
			FormSuceso form = new FormSuceso(miSuceso,miConexion);
			form.miconexion = this.miConexion;
			
			form.Edicion=true;
			form.Show();
		}
	}
}
