/*
 * Created by SharpDevelop.
 * User: jerem
 * Date: 17/9/2023
 * Time: 12:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Codigo_Azul
{
	partial class FormPacientes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlMid;
		private System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel btnButtons;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Panel pnlData;
		private System.Windows.Forms.TextBox txtGrupoSanguineo;
		private System.Windows.Forms.ComboBox cbxProvincia;
		private System.Windows.Forms.ComboBox cbxciudad;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbxObraSocial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
		private System.Windows.Forms.DataGridViewTextBoxColumn ObraSocial;
		private System.Windows.Forms.DataGridViewTextBoxColumn GrupoSanguineo;
		private System.Windows.Forms.DataGridViewTextBoxColumn paci_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn paci_cuid_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn paci_obso_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn paci_prov_id;
		private System.Windows.Forms.Button btnNuevo;
		
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
			this.pnlTop = new System.Windows.Forms.Panel();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnButtons = new System.Windows.Forms.Panel();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.pnlData = new System.Windows.Forms.Panel();
			this.cbxObraSocial = new System.Windows.Forms.ComboBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtGrupoSanguineo = new System.Windows.Forms.TextBox();
			this.cbxProvincia = new System.Windows.Forms.ComboBox();
			this.cbxciudad = new System.Windows.Forms.ComboBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlMid = new System.Windows.Forms.Panel();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.obso_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paci_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paci_obso_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paci_prov_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paci_cuid_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlTop.SuspendLayout();
			this.btnButtons.SuspendLayout();
			this.pnlData.SuspendLayout();
			this.pnlMid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.txtBuscar);
			this.pnlTop.Controls.Add(this.label1);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(1077, 46);
			this.pnlTop.TabIndex = 1;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(89, 9);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(781, 20);
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
			// btnButtons
			// 
			this.btnButtons.Controls.Add(this.btnNuevo);
			this.btnButtons.Controls.Add(this.btnEditar);
			this.btnButtons.Controls.Add(this.btnSeleccionar);
			this.btnButtons.Controls.Add(this.btnCancelar);
			this.btnButtons.Controls.Add(this.btnAceptar);
			this.btnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnButtons.Location = new System.Drawing.Point(0, 483);
			this.btnButtons.Name = "btnButtons";
			this.btnButtons.Size = new System.Drawing.Size(1077, 43);
			this.btnButtons.TabIndex = 1;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(599, 6);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(106, 27);
			this.btnNuevo.TabIndex = 4;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(711, 6);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(106, 27);
			this.btnEditar.TabIndex = 3;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(487, 6);
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
			this.btnCancelar.Location = new System.Drawing.Point(935, 6);
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
			this.btnAceptar.Location = new System.Drawing.Point(823, 6);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(106, 27);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// pnlData
			// 
			this.pnlData.Controls.Add(this.cbxObraSocial);
			this.pnlData.Controls.Add(this.txtEmail);
			this.pnlData.Controls.Add(this.label10);
			this.pnlData.Controls.Add(this.txtGrupoSanguineo);
			this.pnlData.Controls.Add(this.cbxProvincia);
			this.pnlData.Controls.Add(this.cbxciudad);
			this.pnlData.Controls.Add(this.txtTelefono);
			this.pnlData.Controls.Add(this.label11);
			this.pnlData.Controls.Add(this.label9);
			this.pnlData.Controls.Add(this.label8);
			this.pnlData.Controls.Add(this.txtDireccion);
			this.pnlData.Controls.Add(this.label7);
			this.pnlData.Controls.Add(this.label6);
			this.pnlData.Controls.Add(this.label5);
			this.pnlData.Controls.Add(this.txtDni);
			this.pnlData.Controls.Add(this.label2);
			this.pnlData.Controls.Add(this.txtApellido);
			this.pnlData.Controls.Add(this.label4);
			this.pnlData.Controls.Add(this.txtNombre);
			this.pnlData.Controls.Add(this.label3);
			this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlData.Enabled = false;
			this.pnlData.Location = new System.Drawing.Point(0, 240);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(1077, 243);
			this.pnlData.TabIndex = 2;
			// 
			// cbxObraSocial
			// 
			this.cbxObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxObraSocial.FormattingEnabled = true;
			this.cbxObraSocial.Location = new System.Drawing.Point(495, 48);
			this.cbxObraSocial.Name = "cbxObraSocial";
			this.cbxObraSocial.Size = new System.Drawing.Size(238, 21);
			this.cbxObraSocial.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(132, 100);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(238, 20);
			this.txtEmail.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(26, 100);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 25;
			this.label10.Text = "Email";
			// 
			// txtGrupoSanguineo
			// 
			this.txtGrupoSanguineo.Location = new System.Drawing.Point(495, 75);
			this.txtGrupoSanguineo.Name = "txtGrupoSanguineo";
			this.txtGrupoSanguineo.Size = new System.Drawing.Size(67, 20);
			this.txtGrupoSanguineo.TabIndex = 9;
			// 
			// cbxProvincia
			// 
			this.cbxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxProvincia.FormattingEnabled = true;
			this.cbxProvincia.Location = new System.Drawing.Point(132, 179);
			this.cbxProvincia.Name = "cbxProvincia";
			this.cbxProvincia.Size = new System.Drawing.Size(238, 21);
			this.cbxProvincia.TabIndex = 7;
			// 
			// cbxciudad
			// 
			this.cbxciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxciudad.FormattingEnabled = true;
			this.cbxciudad.Location = new System.Drawing.Point(132, 152);
			this.cbxciudad.Name = "cbxciudad";
			this.cbxciudad.Size = new System.Drawing.Size(238, 21);
			this.cbxciudad.TabIndex = 6;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(132, 74);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(176, 20);
			this.txtTelefono.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(26, 74);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Telefono";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(26, 179);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Provincia";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(26, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Ciudad";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(132, 126);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(238, 20);
			this.txtDireccion.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(26, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Direccion";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(403, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Obra Social";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(403, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Gupo Sanguineo";
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(132, 48);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(176, 20);
			this.txtDni.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Dni";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(495, 22);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(311, 20);
			this.txtApellido.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(403, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Apellido";
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
			// 
			// pnlMid
			// 
			this.pnlMid.Controls.Add(this.gridDatos);
			this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMid.Location = new System.Drawing.Point(0, 46);
			this.pnlMid.Name = "pnlMid";
			this.pnlMid.Size = new System.Drawing.Size(1077, 194);
			this.pnlMid.TabIndex = 3;
			// 
			// gridDatos
			// 
			this.gridDatos.AllowUserToAddRows = false;
			this.gridDatos.AllowUserToDeleteRows = false;
			this.gridDatos.AllowUserToResizeRows = false;
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Nombre,
									this.obso_descripcion,
									this.paci_id,
									this.paci_obso_id,
									this.paci_prov_id,
									this.Apellido,
									this.Dni,
									this.Telefono,
									this.Email,
									this.Direccion,
									this.Ciudad,
									this.Provincia,
									this.ObraSocial,
									this.GrupoSanguineo,
									this.paci_cuid_id});
			this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDatos.Location = new System.Drawing.Point(0, 0);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.ReadOnly = true;
			this.gridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridDatos.Size = new System.Drawing.Size(1077, 194);
			this.gridDatos.TabIndex = 0;
			this.gridDatos.SelectionChanged += new System.EventHandler(this.GridDatosSelectionChanged);
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "paci_nombre";
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// obso_descripcion
			// 
			this.obso_descripcion.DataPropertyName = "obso_descripcion";
			this.obso_descripcion.HeaderText = "obso_descripcion";
			this.obso_descripcion.Name = "obso_descripcion";
			this.obso_descripcion.ReadOnly = true;
			this.obso_descripcion.Visible = false;
			// 
			// paci_id
			// 
			this.paci_id.DataPropertyName = "paci_id";
			this.paci_id.HeaderText = "paci_id";
			this.paci_id.Name = "paci_id";
			this.paci_id.ReadOnly = true;
			this.paci_id.Visible = false;
			// 
			// paci_obso_id
			// 
			this.paci_obso_id.DataPropertyName = "paci_obso_id";
			this.paci_obso_id.HeaderText = "paci_obso_id";
			this.paci_obso_id.Name = "paci_obso_id";
			this.paci_obso_id.ReadOnly = true;
			this.paci_obso_id.Visible = false;
			// 
			// paci_prov_id
			// 
			this.paci_prov_id.DataPropertyName = "paci_prov_id";
			this.paci_prov_id.HeaderText = "paci_prov_id";
			this.paci_prov_id.Name = "paci_prov_id";
			this.paci_prov_id.ReadOnly = true;
			this.paci_prov_id.Visible = false;
			// 
			// Apellido
			// 
			this.Apellido.DataPropertyName = "paci_apellido";
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			// 
			// Dni
			// 
			this.Dni.DataPropertyName = "paci_dni";
			this.Dni.HeaderText = "Dni";
			this.Dni.Name = "Dni";
			this.Dni.ReadOnly = true;
			// 
			// Telefono
			// 
			this.Telefono.DataPropertyName = "paci_telefono";
			this.Telefono.HeaderText = "Telefono";
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "paci_email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			// 
			// Direccion
			// 
			this.Direccion.DataPropertyName = "paci_direccion";
			this.Direccion.HeaderText = "Direccion";
			this.Direccion.Name = "Direccion";
			this.Direccion.ReadOnly = true;
			// 
			// Ciudad
			// 
			this.Ciudad.DataPropertyName = "ciud_descripcion";
			this.Ciudad.HeaderText = "Ciudad";
			this.Ciudad.Name = "Ciudad";
			this.Ciudad.ReadOnly = true;
			// 
			// Provincia
			// 
			this.Provincia.DataPropertyName = "prov_descripcion";
			this.Provincia.HeaderText = "Provincia";
			this.Provincia.Name = "Provincia";
			this.Provincia.ReadOnly = true;
			// 
			// ObraSocial
			// 
			this.ObraSocial.DataPropertyName = "obso_descripcion";
			this.ObraSocial.HeaderText = "Obra social";
			this.ObraSocial.Name = "ObraSocial";
			this.ObraSocial.ReadOnly = true;
			// 
			// GrupoSanguineo
			// 
			this.GrupoSanguineo.DataPropertyName = "paci_grupo_sanguineo";
			this.GrupoSanguineo.HeaderText = "Grupo sanguineo";
			this.GrupoSanguineo.Name = "GrupoSanguineo";
			this.GrupoSanguineo.ReadOnly = true;
			// 
			// paci_cuid_id
			// 
			this.paci_cuid_id.DataPropertyName = "paci_cuid_id";
			this.paci_cuid_id.HeaderText = "paci_cuid_id";
			this.paci_cuid_id.Name = "paci_cuid_id";
			this.paci_cuid_id.ReadOnly = true;
			this.paci_cuid_id.Visible = false;
			// 
			// FormPacientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 526);
			this.Controls.Add(this.pnlMid);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnButtons);
			this.Controls.Add(this.pnlTop);
			this.Name = "FormPacientes";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pacientes";
			this.Load += new System.EventHandler(this.FormPacientesLoad);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.btnButtons.ResumeLayout(false);
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			this.pnlMid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn obso_descripcion;
	}
}
