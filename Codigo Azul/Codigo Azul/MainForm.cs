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
//			if(){
				FormGrilla form = new FormGrilla();
				form.Show();
//			}
		}
	}
}


