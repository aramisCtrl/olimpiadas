/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 13/09/2023
 * Time: 20:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Codigo_Azul
{
	partial class FormGrilla
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_reportes = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paci_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paci_grupo_sanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.obso_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_reportes);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1342, 62);
			this.panel1.TabIndex = 7;
			// 
			// btn_reportes
			// 
			this.btn_reportes.Location = new System.Drawing.Point(174, 23);
			this.btn_reportes.Name = "btn_reportes";
			this.btn_reportes.Size = new System.Drawing.Size(85, 23);
			this.btn_reportes.TabIndex = 2;
			this.btn_reportes.Text = "Abrir reportes";
			this.btn_reportes.UseVisualStyleBackColor = true;
			this.btn_reportes.Click += new System.EventHandler(this.Btn_reportesClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(93, 23);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Modificar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1342, 414);
			this.panel2.TabIndex = 8;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column4,
									this.Column2,
									this.Column8,
									this.Column3,
									this.Column7,
									this.Column5,
									this.Column6,
									this.paci_dni,
									this.paci_grupo_sanguineo,
									this.obso_descripcion});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1342, 414);
			this.dataGridView1.TabIndex = 7;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "sues_descripcion";
			this.Column1.HeaderText = "Estado";
			this.Column1.Name = "Column1";
			this.Column1.Width = 65;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "suce_id";
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			this.Column4.Visible = false;
			this.Column4.Width = 73;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "suce_fecha_ini";
			this.Column2.HeaderText = "Fecha de inicio";
			this.Column2.Name = "Column2";
			this.Column2.Width = 74;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "suti_descripcion";
			this.Column8.HeaderText = "Tipo ";
			this.Column8.Name = "Column8";
			this.Column8.Width = 56;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.DataPropertyName = "suce_descripcion";
			this.Column3.HeaderText = "Descripción";
			this.Column3.Name = "Column3";
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "sala_descripcion";
			this.Column7.HeaderText = "Sala";
			this.Column7.Name = "Column7";
			this.Column7.Width = 53;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "paci_nombre";
			this.Column5.HeaderText = "Nombre";
			this.Column5.Name = "Column5";
			this.Column5.Width = 69;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "paci_apellido";
			this.Column6.HeaderText = "Apellido";
			this.Column6.Name = "Column6";
			this.Column6.Width = 69;
			// 
			// paci_dni
			// 
			this.paci_dni.DataPropertyName = "paci_dni";
			this.paci_dni.HeaderText = "DNI";
			this.paci_dni.Name = "paci_dni";
			this.paci_dni.Width = 51;
			// 
			// paci_grupo_sanguineo
			// 
			this.paci_grupo_sanguineo.DataPropertyName = "paci_grupo_sanguineo";
			this.paci_grupo_sanguineo.HeaderText = "Grupo sanguineo";
			this.paci_grupo_sanguineo.Name = "paci_grupo_sanguineo";
			this.paci_grupo_sanguineo.Width = 104;
			// 
			// obso_descripcion
			// 
			this.obso_descripcion.DataPropertyName = "obso_descripcion";
			this.obso_descripcion.HeaderText = "Obra social";
			this.obso_descripcion.Name = "obso_descripcion";
			this.obso_descripcion.Width = 78;
			// 
			// FormGrilla
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1342, 476);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormGrilla";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormGrillaLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_reportes;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn obso_descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn paci_grupo_sanguineo;
		private System.Windows.Forms.DataGridViewTextBoxColumn paci_dni;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
