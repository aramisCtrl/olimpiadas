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
		
		public FormSuceso( Suceso FSuceso,ClassConexionSQL fconexion)
		{
			oSuceso = FSuceso;
			InitializeComponent();
		}

		
		void FormSucesoLoad(object sender, EventArgs e)
		{
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_tipo");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				if(Nuevo==true)
				{
					cbxTipo.DataSource = ds.Tables[0];
					cbxTipo.DisplayMember = "suti_descripcion";
					cbxTipo.ValueMember = "suti_id";
					// establecer el valor seleccionado inicial
					// cbxTipo.SelectedValue = valorInicial;
				}
				else if(Edicion==true){
//					// Obtén la fila seleccionada actualmente
//					DataGridViewRow filaSeleccionada = gridDatos.SelectedRows[0];
//					
//					// Actualiza los datos del objeto Pacientes con los valores del formulario
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

			}
		}
	}
}
