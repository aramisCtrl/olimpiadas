using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Codigo_Azul
{
	public partial class FormSuceso : Form
	{
		public ClassConexionSQL miconexion;
		private Paciente pacienteSeleccionado;
		
		public FormSuceso()
		{
			InitializeComponent();
		}

		
		void FormSucesoLoad(object sender, EventArgs e)
		{
			DataSet ds = miconexion.EjecutarSentencia("SELECT * FROM suceso_tipo");
			
			if (ds != null && ds.Tables.Count > 0)
			{
				cbxTipo.DataSource = ds.Tables[0];
				cbxTipo.DisplayMember = "suti_descripcion";
				cbxTipo.ValueMember = "suti_id";
				// establecer el valor seleccionado inicial
				// cbxTipo.SelectedValue = valorInicial;
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
			}
		}
	}
}
