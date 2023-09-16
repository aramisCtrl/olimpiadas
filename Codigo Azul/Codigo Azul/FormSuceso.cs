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
		public FormSuceso()
		{
			InitializeComponent();
		}

		
		void FormSucesoLoad(object sender, EventArgs e)
		{
			DataSet ds = miconexion.EjecutarSentencia("select * from suceso_tipo");
			cbxTipo.DataSource = ds;
			cbxTipo.DisplayMember = "suti_descripcion";
			cbxTipo.ValueMember ="suti_id";
			
		}
	}
}
