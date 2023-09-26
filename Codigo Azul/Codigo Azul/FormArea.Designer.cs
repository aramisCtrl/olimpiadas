namespace Codigo_Azul
{
	partial class FormArea
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
			this.pnlMid = new System.Windows.Forms.Panel();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.area_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SalaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlarmaTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlData = new System.Windows.Forms.Panel();
			this.cbxsala = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDescipcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnButtons = new System.Windows.Forms.Panel();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlMid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.pnlData.SuspendLayout();
			this.btnButtons.SuspendLayout();
			this.pnlTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMid
			// 
			this.pnlMid.Controls.Add(this.gridDatos);
			this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMid.Location = new System.Drawing.Point(0, 46);
			this.pnlMid.Name = "pnlMid";
			this.pnlMid.Size = new System.Drawing.Size(584, 262);
			this.pnlMid.TabIndex = 7;
			// 
			// gridDatos
			// 
			this.gridDatos.AllowUserToAddRows = false;
			this.gridDatos.AllowUserToDeleteRows = false;
			this.gridDatos.AllowUserToResizeRows = false;
			this.gridDatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Descripcion,
			this.area_id,
			this.SalaAtencion,
			this.AlarmaTexto});
			this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDatos.Location = new System.Drawing.Point(0, 0);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.ReadOnly = true;
			this.gridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridDatos.Size = new System.Drawing.Size(584, 262);
			this.gridDatos.TabIndex = 1;
			this.gridDatos.SelectionChanged += new System.EventHandler(this.GridDatosSelectionChanged);
			// 
			// Descripcion
			// 
			this.Descripcion.DataPropertyName = "area_descripcion";
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// area_id
			// 
			this.area_id.DataPropertyName = "area_id";
			this.area_id.HeaderText = "area_id";
			this.area_id.Name = "area_id";
			this.area_id.ReadOnly = true;
			this.area_id.Visible = false;
			// 
			// SalaAtencion
			// 
			this.SalaAtencion.DataPropertyName = "sala_descripcion";
			this.SalaAtencion.HeaderText = "Sala de atencion";
			this.SalaAtencion.Name = "SalaAtencion";
			this.SalaAtencion.ReadOnly = true;
			// 
			// AlarmaTexto
			// 
			this.AlarmaTexto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AlarmaTexto.DataPropertyName = "area_alarma_texto";
			this.AlarmaTexto.HeaderText = "Alarma Texto";
			this.AlarmaTexto.Name = "AlarmaTexto";
			this.AlarmaTexto.ReadOnly = true;
			// 
			// pnlData
			// 
			this.pnlData.Controls.Add(this.cbxsala);
			this.pnlData.Controls.Add(this.label8);
			this.pnlData.Controls.Add(this.txtDescipcion);
			this.pnlData.Controls.Add(this.label2);
			this.pnlData.Controls.Add(this.txtNombre);
			this.pnlData.Controls.Add(this.label3);
			this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlData.Enabled = false;
			this.pnlData.Location = new System.Drawing.Point(0, 308);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(584, 109);
			this.pnlData.TabIndex = 6;
			// 
			// cbxsala
			// 
			this.cbxsala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxsala.FormattingEnabled = true;
			this.cbxsala.Location = new System.Drawing.Point(132, 74);
			this.cbxsala.Name = "cbxsala";
			this.cbxsala.Size = new System.Drawing.Size(238, 21);
			this.cbxsala.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(26, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Area";
			// 
			// txtDescipcion
			// 
			this.txtDescipcion.Location = new System.Drawing.Point(132, 48);
			this.txtDescipcion.Name = "txtDescipcion";
			this.txtDescipcion.Size = new System.Drawing.Size(238, 20);
			this.txtDescipcion.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Texto (Alarma)";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(132, 22);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(238, 20);
			this.txtNombre.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(26, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// btnButtons
			// 
			this.btnButtons.Controls.Add(this.btnNuevo);
			this.btnButtons.Controls.Add(this.btnEditar);
			this.btnButtons.Controls.Add(this.btnSeleccionar);
			this.btnButtons.Controls.Add(this.btnCancelar);
			this.btnButtons.Controls.Add(this.btnAceptar);
			this.btnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnButtons.Location = new System.Drawing.Point(0, 417);
			this.btnButtons.Name = "btnButtons";
			this.btnButtons.Size = new System.Drawing.Size(584, 43);
			this.btnButtons.TabIndex = 4;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(127, 6);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(106, 27);
			this.btnNuevo.TabIndex = 4;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(239, 6);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(106, 27);
			this.btnEditar.TabIndex = 3;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(15, 6);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(106, 27);
			this.btnSeleccionar.TabIndex = 2;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Location = new System.Drawing.Point(463, 6);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(106, 27);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Enabled = false;
			this.btnAceptar.Location = new System.Drawing.Point(351, 6);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(106, 27);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.txtBuscar);
			this.pnlTop.Controls.Add(this.label1);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(584, 46);
			this.pnlTop.TabIndex = 5;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(89, 9);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(448, 20);
			this.txtBuscar.TabIndex = 0;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar";
			// 
			// FormArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 460);
			this.Controls.Add(this.pnlMid);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnButtons);
			this.Controls.Add(this.pnlTop);
			this.Name = "FormArea";
			this.Text = "Area";
			this.Load += new System.EventHandler(this.FormAreaLoad);
			this.pnlMid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			this.btnButtons.ResumeLayout(false);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridViewTextBoxColumn area_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlarmaTexto;
		private System.Windows.Forms.DataGridViewTextBoxColumn SalaAtencion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Panel btnButtons;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescipcion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbxsala;
		private System.Windows.Forms.Panel pnlData;
		private System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.Panel pnlMid;
	}
}
