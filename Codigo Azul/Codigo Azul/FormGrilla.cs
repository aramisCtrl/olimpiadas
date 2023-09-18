using System;
using System.Drawing;
using System.Windows.Forms;

namespace Codigo_Azul
{
	public partial class FormGrilla : Form
	{
		ClassConexionSQL miConexion;
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
			FormSuceso form = new FormSuceso();
			form.miconexion = this.miConexion;
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
	}
}
