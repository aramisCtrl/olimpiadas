/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 18/9/2023
 * Time: 20:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Codigo_Azul
{
	partial class FormUsuario
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
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxArea = new System.Windows.Forms.ComboBox();
			this.cbxRol = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlMid = new System.Windows.Forms.Panel();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usua_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usua_contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.pnlTop.Size = new System.Drawing.Size(577, 46);
			this.pnlTop.TabIndex = 2;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(89, 9);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(438, 20);
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
			this.btnButtons.Location = new System.Drawing.Point(0, 544);
			this.btnButtons.Name = "btnButtons";
			this.btnButtons.Size = new System.Drawing.Size(577, 43);
			this.btnButtons.TabIndex = 6;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(128, 6);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(106, 27);
			this.btnNuevo.TabIndex = 1;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(240, 6);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(106, 27);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(16, 6);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(106, 27);
			this.btnSeleccionar.TabIndex = 0;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Location = new System.Drawing.Point(464, 6);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(106, 27);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Enabled = false;
			this.btnAceptar.Location = new System.Drawing.Point(352, 6);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(106, 27);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// pnlData
			// 
			this.pnlData.Controls.Add(this.txtUser);
			this.pnlData.Controls.Add(this.label5);
			this.pnlData.Controls.Add(this.cbxArea);
			this.pnlData.Controls.Add(this.cbxRol);
			this.pnlData.Controls.Add(this.label9);
			this.pnlData.Controls.Add(this.label8);
			this.pnlData.Controls.Add(this.txtContraseña);
			this.pnlData.Controls.Add(this.label2);
			this.pnlData.Controls.Add(this.txtApellido);
			this.pnlData.Controls.Add(this.label4);
			this.pnlData.Controls.Add(this.txtNombre);
			this.pnlData.Controls.Add(this.label3);
			this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlData.Enabled = false;
			this.pnlData.Location = new System.Drawing.Point(0, 345);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(577, 199);
			this.pnlData.TabIndex = 7;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(132, 77);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(238, 20);
			this.txtUser.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(26, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Usuario";
			// 
			// cbxArea
			// 
			this.cbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxArea.FormattingEnabled = true;
			this.cbxArea.Location = new System.Drawing.Point(132, 156);
			this.cbxArea.Name = "cbxArea";
			this.cbxArea.Size = new System.Drawing.Size(238, 21);
			this.cbxArea.TabIndex = 5;
			// 
			// cbxRol
			// 
			this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxRol.FormattingEnabled = true;
			this.cbxRol.Location = new System.Drawing.Point(132, 129);
			this.cbxRol.Name = "cbxRol";
			this.cbxRol.Size = new System.Drawing.Size(238, 21);
			this.cbxRol.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(26, 156);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Área";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(26, 129);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Rol";
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(132, 103);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.PasswordChar = '*';
			this.txtContraseña.Size = new System.Drawing.Size(238, 20);
			this.txtContraseña.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Contraseña";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(132, 48);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(238, 20);
			this.txtApellido.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(26, 48);
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
			this.label3.Location = new System.Drawing.Point(26, 22);
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
			this.pnlMid.Size = new System.Drawing.Size(577, 299);
			this.pnlMid.TabIndex = 8;
			// 
			// gridDatos
			// 
			this.gridDatos.AllowUserToAddRows = false;
			this.gridDatos.AllowUserToDeleteRows = false;
			this.gridDatos.AllowUserToResizeRows = false;
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Nombre,
			this.Apellido,
			this.User,
			this.Rol,
			this.Area,
			this.usua_id,
			this.usua_contraseña});
			this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDatos.Location = new System.Drawing.Point(0, 0);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.ReadOnly = true;
			this.gridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridDatos.Size = new System.Drawing.Size(577, 299);
			this.gridDatos.TabIndex = 0;
			this.gridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosCellContentClick);
			this.gridDatos.SelectionChanged += new System.EventHandler(this.GridDatosSelectionChanged);
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.DataPropertyName = "usua_nombre";
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Apellido
			// 
			this.Apellido.DataPropertyName = "usua_apellido";
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			// 
			// User
			// 
			this.User.DataPropertyName = "usua_usuario";
			this.User.HeaderText = "User";
			this.User.Name = "User";
			this.User.ReadOnly = true;
			// 
			// Rol
			// 
			this.Rol.DataPropertyName = "rol_nombre";
			this.Rol.HeaderText = "Rol";
			this.Rol.Name = "Rol";
			this.Rol.ReadOnly = true;
			// 
			// Area
			// 
			this.Area.DataPropertyName = "area_descripcion";
			this.Area.HeaderText = "Area";
			this.Area.Name = "Area";
			this.Area.ReadOnly = true;
			// 
			// usua_id
			// 
			this.usua_id.DataPropertyName = "usua_id";
			this.usua_id.HeaderText = "usua_id";
			this.usua_id.Name = "usua_id";
			this.usua_id.ReadOnly = true;
			this.usua_id.Visible = false;
			// 
			// usua_contraseña
			// 
			this.usua_contraseña.DataPropertyName = "usua_contraseña";
			this.usua_contraseña.HeaderText = "usua_contraseña";
			this.usua_contraseña.Name = "usua_contraseña";
			this.usua_contraseña.ReadOnly = true;
			this.usua_contraseña.Visible = false;
			// 
			// FormUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 587);
			this.Controls.Add(this.pnlMid);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnButtons);
			this.Controls.Add(this.pnlTop);
			this.Name = "FormUsuario";
			this.Text = "Usuario";
			this.Load += new System.EventHandler(this.FormUsuarioLoad);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.btnButtons.ResumeLayout(false);
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			this.pnlMid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Area;
		private System.Windows.Forms.DataGridViewTextBoxColumn usua_contraseña;
		private System.Windows.Forms.DataGridViewTextBoxColumn usua_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
		private System.Windows.Forms.DataGridViewTextBoxColumn User;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.Panel pnlMid;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Panel btnButtons;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbxRol;
		private System.Windows.Forms.ComboBox cbxArea;
		private System.Windows.Forms.Panel pnlData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Panel pnlTop;
	}
}
