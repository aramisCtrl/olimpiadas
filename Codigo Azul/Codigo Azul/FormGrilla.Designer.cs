﻿/*
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrilla));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrarSuceso = new System.Windows.Forms.Button();
			this.btnUusarios = new System.Windows.Forms.Button();
			this.btnSala = new System.Windows.Forms.Button();
			this.btn_alarma = new System.Windows.Forms.Button();
			this.btn_reportes = new System.Windows.Forms.Button();
			this.btn_nueva_area = new System.Windows.Forms.Button();
			this.btn_nuevo_suceso = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgv_sucesos = new System.Windows.Forms.DataGridView();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaAtendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SuceAreaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SuceAreaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SuceSutiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SuceSuesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SucePaciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SuceUsuaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SuceSuorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SucePaciSalaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolTip_botones = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_sucesos)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCerrarSuceso);
			this.panel1.Controls.Add(this.btnUusarios);
			this.panel1.Controls.Add(this.btnSala);
			this.panel1.Controls.Add(this.btn_alarma);
			this.panel1.Controls.Add(this.btn_reportes);
			this.panel1.Controls.Add(this.btn_nueva_area);
			this.panel1.Controls.Add(this.btn_nuevo_suceso);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1342, 71);
			this.panel1.TabIndex = 7;
			// 
			// btnCerrarSuceso
			// 
			this.btnCerrarSuceso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarSuceso.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSuceso.Image")));
			this.btnCerrarSuceso.Location = new System.Drawing.Point(74, 3);
			this.btnCerrarSuceso.Margin = new System.Windows.Forms.Padding(2);
			this.btnCerrarSuceso.Name = "btnCerrarSuceso";
			this.btnCerrarSuceso.Size = new System.Drawing.Size(66, 64);
			this.btnCerrarSuceso.TabIndex = 7;
			this.toolTip_botones.SetToolTip(this.btnCerrarSuceso, "Cerrar suceso");
			this.btnCerrarSuceso.UseVisualStyleBackColor = true;
			this.btnCerrarSuceso.Click += new System.EventHandler(this.BtnCerrarSucesoClick);
			// 
			// btnUusarios
			// 
			this.btnUusarios.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUusarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUusarios.Image")));
			this.btnUusarios.Location = new System.Drawing.Point(358, 3);
			this.btnUusarios.Margin = new System.Windows.Forms.Padding(2);
			this.btnUusarios.Name = "btnUusarios";
			this.btnUusarios.Size = new System.Drawing.Size(66, 64);
			this.btnUusarios.TabIndex = 6;
			this.toolTip_botones.SetToolTip(this.btnUusarios, "Usuarios");
			this.btnUusarios.UseVisualStyleBackColor = true;
			this.btnUusarios.Click += new System.EventHandler(this.BtnUusariosClick);
			// 
			// btnSala
			// 
			this.btnSala.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSala.Image = ((System.Drawing.Image)(resources.GetObject("btnSala.Image")));
			this.btnSala.Location = new System.Drawing.Point(288, 3);
			this.btnSala.Margin = new System.Windows.Forms.Padding(2);
			this.btnSala.Name = "btnSala";
			this.btnSala.Size = new System.Drawing.Size(66, 64);
			this.btnSala.TabIndex = 5;
			this.toolTip_botones.SetToolTip(this.btnSala, "Salas");
			this.btnSala.UseVisualStyleBackColor = true;
			this.btnSala.Click += new System.EventHandler(this.BtnSalaClick);
			// 
			// btn_alarma
			// 
			this.btn_alarma.BackColor = System.Drawing.Color.Transparent;
			this.btn_alarma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_alarma.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_alarma.Dock = System.Windows.Forms.DockStyle.Right;
			this.btn_alarma.Image = ((System.Drawing.Image)(resources.GetObject("btn_alarma.Image")));
			this.btn_alarma.Location = new System.Drawing.Point(1272, 0);
			this.btn_alarma.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.btn_alarma.Name = "btn_alarma";
			this.btn_alarma.Size = new System.Drawing.Size(70, 71);
			this.btn_alarma.TabIndex = 3;
			this.toolTip_botones.SetToolTip(this.btn_alarma, "Alarma Código Azul");
			this.btn_alarma.UseVisualStyleBackColor = false;
			this.btn_alarma.Click += new System.EventHandler(this.Btn_alarmaClick);
			// 
			// btn_reportes
			// 
			this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
			this.btn_reportes.Location = new System.Drawing.Point(217, 3);
			this.btn_reportes.Name = "btn_reportes";
			this.btn_reportes.Size = new System.Drawing.Size(66, 64);
			this.btn_reportes.TabIndex = 2;
			this.toolTip_botones.SetToolTip(this.btn_reportes, "Reportes");
			this.btn_reportes.UseVisualStyleBackColor = true;
			this.btn_reportes.Click += new System.EventHandler(this.Btn_reportesClick);
			// 
			// btn_nueva_area
			// 
			this.btn_nueva_area.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_nueva_area.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva_area.Image")));
			this.btn_nueva_area.Location = new System.Drawing.Point(145, 3);
			this.btn_nueva_area.Name = "btn_nueva_area";
			this.btn_nueva_area.Size = new System.Drawing.Size(66, 64);
			this.btn_nueva_area.TabIndex = 1;
			this.toolTip_botones.SetToolTip(this.btn_nueva_area, "Areas");
			this.btn_nueva_area.UseVisualStyleBackColor = true;
			this.btn_nueva_area.Click += new System.EventHandler(this.Btn_nueva_areaClick);
			// 
			// btn_nuevo_suceso
			// 
			this.btn_nuevo_suceso.BackColor = System.Drawing.Color.Transparent;
			this.btn_nuevo_suceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_nuevo_suceso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_nuevo_suceso.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_suceso.Image")));
			this.btn_nuevo_suceso.Location = new System.Drawing.Point(3, 3);
			this.btn_nuevo_suceso.Name = "btn_nuevo_suceso";
			this.btn_nuevo_suceso.Size = new System.Drawing.Size(66, 64);
			this.btn_nuevo_suceso.TabIndex = 0;
			this.toolTip_botones.SetToolTip(this.btn_nuevo_suceso, "Nuevo suceso");
			this.btn_nuevo_suceso.UseVisualStyleBackColor = false;
			this.btn_nuevo_suceso.Click += new System.EventHandler(this.btnNuevoClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgv_sucesos);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 71);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1342, 405);
			this.panel2.TabIndex = 8;
			// 
			// dgv_sucesos
			// 
			this.dgv_sucesos.AllowUserToAddRows = false;
			this.dgv_sucesos.AllowUserToDeleteRows = false;
			this.dgv_sucesos.AllowUserToResizeRows = false;
			this.dgv_sucesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_sucesos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgv_sucesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_sucesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Estado,
			this.FechaAtendido,
			this.Numero,
			this.FechaInicio,
			this.Tipo,
			this.Descripcion,
			this.SuceAreaDescripcion,
			this.Sala,
			this.Nombre,
			this.Apellido,
			this.Dni,
			this.GrupoSanguineo,
			this.ObraSocial,
			this.Medico,
			this.Origen,
			this.SuceAreaId,
			this.SuceSutiId,
			this.SuceSuesId,
			this.SucePaciId,
			this.SuceUsuaId,
			this.SuceSuorId,
			this.SucePaciSalaId});
			this.dgv_sucesos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_sucesos.Location = new System.Drawing.Point(0, 0);
			this.dgv_sucesos.MultiSelect = false;
			this.dgv_sucesos.Name = "dgv_sucesos";
			this.dgv_sucesos.ReadOnly = true;
			this.dgv_sucesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_sucesos.Size = new System.Drawing.Size(1342, 405);
			this.dgv_sucesos.TabIndex = 7;
			this.dgv_sucesos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_sucesosCellContentClick);
			this.dgv_sucesos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1DataBindingComplete);
			this.dgv_sucesos.DoubleClick += new System.EventHandler(this.DataGridView1DoubleClick);
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "sues_descripcion";
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			this.Estado.Width = 65;
			// 
			// FechaAtendido
			// 
			this.FechaAtendido.DataPropertyName = "suce_fecha_atendido";
			this.FechaAtendido.HeaderText = "FechaAtendido";
			this.FechaAtendido.Name = "FechaAtendido";
			this.FechaAtendido.ReadOnly = true;
			this.FechaAtendido.Visible = false;
			this.FechaAtendido.Width = 104;
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
			// SuceAreaDescripcion
			// 
			this.SuceAreaDescripcion.DataPropertyName = "area_descripcion";
			this.SuceAreaDescripcion.HeaderText = "Area";
			this.SuceAreaDescripcion.Name = "SuceAreaDescripcion";
			this.SuceAreaDescripcion.ReadOnly = true;
			this.SuceAreaDescripcion.Width = 54;
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
			// SuceAreaId
			// 
			this.SuceAreaId.DataPropertyName = "suce_area_id";
			this.SuceAreaId.HeaderText = "SuceAreaId";
			this.SuceAreaId.Name = "SuceAreaId";
			this.SuceAreaId.ReadOnly = true;
			this.SuceAreaId.Visible = false;
			this.SuceAreaId.Width = 88;
			// 
			// SuceSutiId
			// 
			this.SuceSutiId.DataPropertyName = "suce_suti_id";
			this.SuceSutiId.HeaderText = "SuceSutiId";
			this.SuceSutiId.Name = "SuceSutiId";
			this.SuceSutiId.ReadOnly = true;
			this.SuceSutiId.Visible = false;
			this.SuceSutiId.Width = 84;
			// 
			// SuceSuesId
			// 
			this.SuceSuesId.DataPropertyName = "suce_sues_id";
			this.SuceSuesId.HeaderText = "SuceSuesId";
			this.SuceSuesId.Name = "SuceSuesId";
			this.SuceSuesId.ReadOnly = true;
			this.SuceSuesId.Visible = false;
			this.SuceSuesId.Width = 90;
			// 
			// SucePaciId
			// 
			this.SucePaciId.DataPropertyName = "suce_paci_id";
			this.SucePaciId.HeaderText = "SucePaciId";
			this.SucePaciId.Name = "SucePaciId";
			this.SucePaciId.ReadOnly = true;
			this.SucePaciId.Visible = false;
			this.SucePaciId.Width = 87;
			// 
			// SuceUsuaId
			// 
			this.SuceUsuaId.DataPropertyName = "suce_usua_id";
			this.SuceUsuaId.HeaderText = "SuceUsuaId";
			this.SuceUsuaId.Name = "SuceUsuaId";
			this.SuceUsuaId.ReadOnly = true;
			this.SuceUsuaId.Visible = false;
			this.SuceUsuaId.Width = 91;
			// 
			// SuceSuorId
			// 
			this.SuceSuorId.DataPropertyName = "suce_suor_id";
			this.SuceSuorId.HeaderText = "SuceSuorId";
			this.SuceSuorId.Name = "SuceSuorId";
			this.SuceSuorId.ReadOnly = true;
			this.SuceSuorId.Visible = false;
			this.SuceSuorId.Width = 88;
			// 
			// SucePaciSalaId
			// 
			this.SucePaciSalaId.DataPropertyName = "suce_paci_sala_id";
			this.SucePaciSalaId.HeaderText = "SucePaciSalaId";
			this.SucePaciSalaId.Name = "SucePaciSalaId";
			this.SucePaciSalaId.ReadOnly = true;
			this.SucePaciSalaId.Visible = false;
			this.SucePaciSalaId.Width = 108;
			// 
			// toolTip_botones
			// 
			this.toolTip_botones.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip_botonesPopup);
			// 
			// FormGrilla
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1342, 476);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormGrilla";
			this.ShowIcon = false;
			this.Text = "Sucesos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormGrillaLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_sucesos)).EndInit();
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.Button btnSala;
		private System.Windows.Forms.DataGridViewTextBoxColumn SuceAreaDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn SucePaciSalaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn SuceSuorId;
		private System.Windows.Forms.DataGridViewTextBoxColumn SuceUsuaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn SucePaciId;
		private System.Windows.Forms.DataGridViewTextBoxColumn SuceSuesId;
		private System.Windows.Forms.DataGridViewTextBoxColumn SuceSutiId;
		private System.Windows.Forms.DataGridViewTextBoxColumn SuceAreaId;
		private System.Windows.Forms.Button btn_alarma;
		private System.Windows.Forms.ToolTip toolTip_botones;
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
		private System.Windows.Forms.Button btn_nuevo_suceso;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;

		private System.Windows.Forms.Button btn_nueva_area;
		private System.Windows.Forms.DataGridView dgv_sucesos;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaAtendido;
		private System.Windows.Forms.Button btnCerrarSuceso;
		private System.Windows.Forms.Button btnUusarios;
	}
}
