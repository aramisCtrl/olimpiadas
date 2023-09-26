using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Codigo_Azul
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Btn_ingresarClick(object sender, EventArgs e)
		{
			string nombreUsuario = txt_usuario.Text;
			string contraseña = txt_contraseña.Text;
			
			// Validar el usuario en la base de datos
			ClassConexionSQL conexionSQL = new ClassConexionSQL();
			if (conexionSQL.CrearConexion() && conexionSQL.ValidarUsuario(nombreUsuario, contraseña))
			{
				FormGrilla form = new FormGrilla();
				form.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string nombreUsuario = txt_usuario.Text;
			string contraseña = txt_contraseña.Text;
			
			// Validar el usuario en la base de datos
			ClassConexionSQL conexionSQL = new ClassConexionSQL();
			if (conexionSQL.CrearConexion() && conexionSQL.ValidarUsuario(nombreUsuario, contraseña))
			{
//				FormGrilla form = new FormGrilla();
//				form.Show();
//				this.Hide();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
			}			
//			FormGrilla form = new FormGrilla();
//			form.Show();
//			this.Hide();
		}
	}
}