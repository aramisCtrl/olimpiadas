﻿using System;
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
		

		void btnNuevoClick(object sender, EventArgs e)
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
			if (dataGridView1.SelectedRows.Count > 0)
			{
				//Obtén la fila seleccionada actualmente
				DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
				
				// Actualiza los datos del objeto Suceso con los valores del formulario
				miSuceso.Numero=int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
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
				
				FormSuceso form = new FormSuceso(miSuceso,miConexion);
				form.miconexion = this.miConexion;
				
				form.Edicion=true;
				form.Show();
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
