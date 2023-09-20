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
			this.btnNuevo = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.panel1.Controls.Add(this.btnNuevo);
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
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(12, 23);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 0;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevoClick);
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
									this.Estado,
									this.Numero,
									this.FechaInicio,
									this.Tipo,
									this.Descripcion,
									this.Sala,
									this.Nombre,
									this.Apellido,
									this.Dni,
									this.GrupoSanguineo,
									this.ObraSocial,
									this.Medico,
									this.Origen});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1342, 414);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1DataBindingComplete);
			this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1DoubleClick);
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "sues_descripcion";
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			this.Estado.Width = 65;
			// 
			// Numero
			// 
			this.Numero.DataPropertyName = "suce_id";
			this.Numero.HeaderText = "Numero";
			this.Numero.Name = "Numero";
			this.Numero.ReadOnly = true;
			this.Numero.Visible = false;
			this.Numero.Width = 69;
			// 
			// FechaInicio
			// 
			this.FechaInicio.DataPropertyName = "suce_fecha_ini";
			this.FechaInicio.HeaderText = "Fecha de inicio";
			this.FechaInicio.Name = "FechaInicio";
			this.FechaInicio.ReadOnly = true;
			this.FechaInicio.Width = 74;
			// 
			// Tipo
			// 
			this.Tipo.DataPropertyName = "suti_descripcion";
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Width = 53;
			// 
			// Descripcion
			// 
			this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descripcion.DataPropertyName = "suce_descripcion";
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Sala
			// 
			this.Sala.DataPropertyName = "sala_descripcion";
			this.Sala.HeaderText = "Sala";
			this.Sala.Name = "Sala";
			this.Sala.ReadOnly = true;
			this.Sala.Width = 53;
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "paci_nombre";
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 69;
			// 
			// Apellido
			// 
			this.Apellido.DataPropertyName = "paci_apellido";
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			this.Apellido.Width = 69;
			// 
			// Dni
			// 
			this.Dni.DataPropertyName = "paci_dni";
			this.Dni.HeaderText = "DNI";
			this.Dni.Name = "Dni";
			this.Dni.ReadOnly = true;
			this.Dni.Width = 51;
			// 
			// GrupoSanguineo
			// 
			this.GrupoSanguineo.DataPropertyName = "paci_grupo_sanguineo";
			this.GrupoSanguineo.HeaderText = "Grupo sanguineo";
			this.GrupoSanguineo.Name = "GrupoSanguineo";
			this.GrupoSanguineo.ReadOnly = true;
			this.GrupoSanguineo.Width = 104;
			// 
			// ObraSocial
			// 
			this.ObraSocial.DataPropertyName = "obso_descripcion";
			this.ObraSocial.HeaderText = "Obra social";
			this.ObraSocial.Name = "ObraSocial";
			this.ObraSocial.ReadOnly = true;
			this.ObraSocial.Width = 78;
			// 
			// Medico
			// 
			this.Medico.DataPropertyName = "usua_nombre";
			this.Medico.HeaderText = "Medico";
			this.Medico.Name = "Medico";
			this.Medico.ReadOnly = true;
			this.Medico.Width = 67;
			// 
			// Origen
			// 
			this.Origen.DataPropertyName = "suor_descripcion";
			this.Origen.HeaderText = "Origen";
			this.Origen.Name = "Origen";
			this.Origen.ReadOnly = true;
			this.Origen.Visible = false;
			this.Origen.Width = 63;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
		private System.Windows.Forms.DataGridViewTextBoxColumn ObraSocial;
		private System.Windows.Forms.DataGridViewTextBoxColumn GrupoSanguineo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.Button btn_reportes;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
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
