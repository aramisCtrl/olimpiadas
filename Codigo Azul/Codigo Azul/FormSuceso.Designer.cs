/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 14/09/2023
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Codigo_Azul
{
	partial class FormSuceso
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblNumero = new System.Windows.Forms.Label();
			this.pnlDatos = new System.Windows.Forms.Panel();
			this.cbxArea2 = new System.Windows.Forms.ComboBox();
			this.lbl_area = new System.Windows.Forms.Label();
			this.lbl_obra_social1 = new System.Windows.Forms.Label();
			this.lbl_obra_social = new System.Windows.Forms.Label();
			this.lbl_grupo_sanguineo1 = new System.Windows.Forms.Label();
			this.lbl_grupo_sanguineo = new System.Windows.Forms.Label();
			this.cbxOrigen = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxEstado = new System.Windows.Forms.ComboBox();
			this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
			this.cbxSala = new System.Windows.Forms.ComboBox();
			this.cbxTipo = new System.Windows.Forms.ComboBox();
			this.btnBuscarPaciente = new System.Windows.Forms.Button();
			this.btnBuscarUsuario = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPaciente = new System.Windows.Forms.TextBox();
			this.lbl_dni1 = new System.Windows.Forms.Label();
			this.lbl_dni = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.RichTextBox();
			this.lbl_sala = new System.Windows.Forms.Label();
			this.lbl_descripcion = new System.Windows.Forms.Label();
			this.lbl_medico = new System.Windows.Forms.Label();
			this.lbl_paciente = new System.Windows.Forms.Label();
			this.lbl_inicio = new System.Windows.Forms.Label();
			this.lbl_tipo = new System.Windows.Forms.Label();
			this.lbl_estado = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnAceptar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 517);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(647, 50);
			this.panel1.TabIndex = 37;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(547, 15);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(466, 15);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblNumero);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(647, 45);
			this.panel2.TabIndex = 38;
			// 
			// lblNumero
			// 
			this.lblNumero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(0, 0);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(647, 45);
			this.lblNumero.TabIndex = 1;
			this.lblNumero.Text = "Suceso Nº 123456";
			this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlDatos
			// 
			this.pnlDatos.Controls.Add(this.cbxArea2);
			this.pnlDatos.Controls.Add(this.lbl_area);
			this.pnlDatos.Controls.Add(this.lbl_obra_social1);
			this.pnlDatos.Controls.Add(this.lbl_obra_social);
			this.pnlDatos.Controls.Add(this.lbl_grupo_sanguineo1);
			this.pnlDatos.Controls.Add(this.lbl_grupo_sanguineo);
			this.pnlDatos.Controls.Add(this.cbxOrigen);
			this.pnlDatos.Controls.Add(this.label3);
			this.pnlDatos.Controls.Add(this.cbxEstado);
			this.pnlDatos.Controls.Add(this.dtp_fecha);
			this.pnlDatos.Controls.Add(this.cbxSala);
			this.pnlDatos.Controls.Add(this.cbxTipo);
			this.pnlDatos.Controls.Add(this.btnBuscarPaciente);
			this.pnlDatos.Controls.Add(this.btnBuscarUsuario);
			this.pnlDatos.Controls.Add(this.txtUsuario);
			this.pnlDatos.Controls.Add(this.txtPaciente);
			this.pnlDatos.Controls.Add(this.lbl_dni1);
			this.pnlDatos.Controls.Add(this.lbl_dni);
			this.pnlDatos.Controls.Add(this.txtDescripcion);
			this.pnlDatos.Controls.Add(this.lbl_sala);
			this.pnlDatos.Controls.Add(this.lbl_descripcion);
			this.pnlDatos.Controls.Add(this.lbl_medico);
			this.pnlDatos.Controls.Add(this.lbl_paciente);
			this.pnlDatos.Controls.Add(this.lbl_inicio);
			this.pnlDatos.Controls.Add(this.lbl_tipo);
			this.pnlDatos.Controls.Add(this.lbl_estado);
			this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDatos.Location = new System.Drawing.Point(0, 45);
			this.pnlDatos.Name = "pnlDatos";
			this.pnlDatos.Size = new System.Drawing.Size(647, 472);
			this.pnlDatos.TabIndex = 39;
			// 
			// cbxArea2
			// 
			this.cbxArea2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxArea2.FormattingEnabled = true;
			this.cbxArea2.Location = new System.Drawing.Point(149, 132);
			this.cbxArea2.Name = "cbxArea2";
			this.cbxArea2.Size = new System.Drawing.Size(298, 21);
			this.cbxArea2.TabIndex = 62;
			// 
			// lbl_area
			// 
			this.lbl_area.Location = new System.Drawing.Point(43, 128);
			this.lbl_area.Name = "lbl_area";
			this.lbl_area.Size = new System.Drawing.Size(100, 23);
			this.lbl_area.TabIndex = 61;
			this.lbl_area.Text = "Area:";
			this.lbl_area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_obra_social1
			// 
			this.lbl_obra_social1.Location = new System.Drawing.Point(268, 285);
			this.lbl_obra_social1.Name = "lbl_obra_social1";
			this.lbl_obra_social1.Size = new System.Drawing.Size(179, 23);
			this.lbl_obra_social1.TabIndex = 60;
			this.lbl_obra_social1.Text = "-";
			// 
			// lbl_obra_social
			// 
			this.lbl_obra_social.Location = new System.Drawing.Point(149, 280);
			this.lbl_obra_social.Name = "lbl_obra_social";
			this.lbl_obra_social.Size = new System.Drawing.Size(100, 23);
			this.lbl_obra_social.TabIndex = 59;
			this.lbl_obra_social.Text = "Obra social:";
			this.lbl_obra_social.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_grupo_sanguineo1
			// 
			this.lbl_grupo_sanguineo1.Location = new System.Drawing.Point(268, 262);
			this.lbl_grupo_sanguineo1.Name = "lbl_grupo_sanguineo1";
			this.lbl_grupo_sanguineo1.Size = new System.Drawing.Size(179, 23);
			this.lbl_grupo_sanguineo1.TabIndex = 58;
			this.lbl_grupo_sanguineo1.Text = "-";
			// 
			// lbl_grupo_sanguineo
			// 
			this.lbl_grupo_sanguineo.Location = new System.Drawing.Point(149, 257);
			this.lbl_grupo_sanguineo.Name = "lbl_grupo_sanguineo";
			this.lbl_grupo_sanguineo.Size = new System.Drawing.Size(100, 23);
			this.lbl_grupo_sanguineo.TabIndex = 57;
			this.lbl_grupo_sanguineo.Text = "Grupo sanguíneo:";
			this.lbl_grupo_sanguineo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbxOrigen
			// 
			this.cbxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOrigen.FormattingEnabled = true;
			this.cbxOrigen.Location = new System.Drawing.Point(149, 78);
			this.cbxOrigen.Name = "cbxOrigen";
			this.cbxOrigen.Size = new System.Drawing.Size(298, 21);
			this.cbxOrigen.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(43, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 55;
			this.label3.Text = "Origen:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbxEstado
			// 
			this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxEstado.FormattingEnabled = true;
			this.cbxEstado.Location = new System.Drawing.Point(149, 50);
			this.cbxEstado.Name = "cbxEstado";
			this.cbxEstado.Size = new System.Drawing.Size(298, 21);
			this.cbxEstado.TabIndex = 0;
			// 
			// dtp_fecha
			// 
			this.dtp_fecha.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtp_fecha.Enabled = false;
			this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_fecha.Location = new System.Drawing.Point(149, 24);
			this.dtp_fecha.Name = "dtp_fecha";
			this.dtp_fecha.Size = new System.Drawing.Size(298, 20);
			this.dtp_fecha.TabIndex = 53;
			// 
			// cbxSala
			// 
			this.cbxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSala.FormattingEnabled = true;
			this.cbxSala.Location = new System.Drawing.Point(149, 157);
			this.cbxSala.Name = "cbxSala";
			this.cbxSala.Size = new System.Drawing.Size(298, 21);
			this.cbxSala.TabIndex = 4;
			// 
			// cbxTipo
			// 
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.Location = new System.Drawing.Point(149, 105);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(298, 21);
			this.cbxTipo.TabIndex = 2;
			// 
			// btnBuscarPaciente
			// 
			this.btnBuscarPaciente.Location = new System.Drawing.Point(453, 210);
			this.btnBuscarPaciente.Name = "btnBuscarPaciente";
			this.btnBuscarPaciente.Size = new System.Drawing.Size(32, 25);
			this.btnBuscarPaciente.TabIndex = 50;
			this.btnBuscarPaciente.Text = "...";
			this.btnBuscarPaciente.UseVisualStyleBackColor = true;
			this.btnBuscarPaciente.Click += new System.EventHandler(this.BtnBuscarPacienteClick);
			// 
			// btnBuscarUsuario
			// 
			this.btnBuscarUsuario.Location = new System.Drawing.Point(453, 181);
			this.btnBuscarUsuario.Name = "btnBuscarUsuario";
			this.btnBuscarUsuario.Size = new System.Drawing.Size(32, 25);
			this.btnBuscarUsuario.TabIndex = 49;
			this.btnBuscarUsuario.Text = "...";
			this.btnBuscarUsuario.UseVisualStyleBackColor = true;
			this.btnBuscarUsuario.Click += new System.EventHandler(this.BtnBuscarUsuarioClick);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(149, 184);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.ReadOnly = true;
			this.txtUsuario.Size = new System.Drawing.Size(298, 20);
			this.txtUsuario.TabIndex = 5;
			// 
			// txtPaciente
			// 
			this.txtPaciente.Location = new System.Drawing.Point(149, 210);
			this.txtPaciente.Name = "txtPaciente";
			this.txtPaciente.ReadOnly = true;
			this.txtPaciente.Size = new System.Drawing.Size(298, 20);
			this.txtPaciente.TabIndex = 6;
			// 
			// lbl_dni1
			// 
			this.lbl_dni1.Location = new System.Drawing.Point(268, 238);
			this.lbl_dni1.Name = "lbl_dni1";
			this.lbl_dni1.Size = new System.Drawing.Size(179, 23);
			this.lbl_dni1.TabIndex = 46;
			this.lbl_dni1.Text = "-";
			// 
			// lbl_dni
			// 
			this.lbl_dni.Location = new System.Drawing.Point(149, 233);
			this.lbl_dni.Name = "lbl_dni";
			this.lbl_dni.Size = new System.Drawing.Size(100, 23);
			this.lbl_dni.TabIndex = 45;
			this.lbl_dni.Text = "DNI:";
			this.lbl_dni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(149, 315);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(460, 137);
			this.txtDescripcion.TabIndex = 7;
			this.txtDescripcion.Text = "";
			// 
			// lbl_sala
			// 
			this.lbl_sala.Location = new System.Drawing.Point(43, 154);
			this.lbl_sala.Name = "lbl_sala";
			this.lbl_sala.Size = new System.Drawing.Size(100, 23);
			this.lbl_sala.TabIndex = 43;
			this.lbl_sala.Text = "Sala:";
			this.lbl_sala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_descripcion
			// 
			this.lbl_descripcion.Location = new System.Drawing.Point(43, 313);
			this.lbl_descripcion.Name = "lbl_descripcion";
			this.lbl_descripcion.Size = new System.Drawing.Size(100, 23);
			this.lbl_descripcion.TabIndex = 42;
			this.lbl_descripcion.Text = "Descripción:";
			this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_medico
			// 
			this.lbl_medico.Location = new System.Drawing.Point(43, 188);
			this.lbl_medico.Name = "lbl_medico";
			this.lbl_medico.Size = new System.Drawing.Size(100, 23);
			this.lbl_medico.TabIndex = 41;
			this.lbl_medico.Text = "Médico";
			this.lbl_medico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_paciente
			// 
			this.lbl_paciente.Location = new System.Drawing.Point(43, 211);
			this.lbl_paciente.Name = "lbl_paciente";
			this.lbl_paciente.Size = new System.Drawing.Size(100, 23);
			this.lbl_paciente.TabIndex = 40;
			this.lbl_paciente.Text = "Paciente:";
			this.lbl_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_inicio
			// 
			this.lbl_inicio.Location = new System.Drawing.Point(43, 19);
			this.lbl_inicio.Name = "lbl_inicio";
			this.lbl_inicio.Size = new System.Drawing.Size(100, 23);
			this.lbl_inicio.TabIndex = 39;
			this.lbl_inicio.Text = "Fecha de inicio:";
			this.lbl_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_tipo
			// 
			this.lbl_tipo.Location = new System.Drawing.Point(43, 102);
			this.lbl_tipo.Name = "lbl_tipo";
			this.lbl_tipo.Size = new System.Drawing.Size(100, 23);
			this.lbl_tipo.TabIndex = 38;
			this.lbl_tipo.Text = "Tipo:";
			this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_estado
			// 
			this.lbl_estado.Location = new System.Drawing.Point(43, 48);
			this.lbl_estado.Name = "lbl_estado";
			this.lbl_estado.Size = new System.Drawing.Size(100, 23);
			this.lbl_estado.TabIndex = 37;
			this.lbl_estado.Text = "Estado:";
			this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormSuceso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 567);
			this.Controls.Add(this.pnlDatos);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormSuceso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormSuceso";
			this.Load += new System.EventHandler(this.FormSucesoLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnlDatos.ResumeLayout(false);
			this.pnlDatos.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lbl_area;
		private System.Windows.Forms.RichTextBox txtDescripcion;
		private System.Windows.Forms.Label lbl_dni;
		private System.Windows.Forms.Label lbl_dni1;
		private System.Windows.Forms.TextBox txtPaciente;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button btnBuscarUsuario;
		private System.Windows.Forms.Button btnBuscarPaciente;
		private System.Windows.Forms.ComboBox cbxTipo;
		private System.Windows.Forms.ComboBox cbxSala;
		private System.Windows.Forms.DateTimePicker dtp_fecha;
		private System.Windows.Forms.ComboBox cbxEstado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxOrigen;
		private System.Windows.Forms.Label lbl_grupo_sanguineo;
		private System.Windows.Forms.Label lbl_grupo_sanguineo1;
		private System.Windows.Forms.Label lbl_obra_social;
		private System.Windows.Forms.Label lbl_obra_social1;
		private System.Windows.Forms.Panel pnlDatos;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_sala;
		private System.Windows.Forms.Label lbl_descripcion;
		private System.Windows.Forms.Label lbl_medico;
		private System.Windows.Forms.Label lbl_paciente;
		private System.Windows.Forms.Label lbl_inicio;
		private System.Windows.Forms.Label lbl_tipo;
		private System.Windows.Forms.Label lbl_estado;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.ComboBox cbxArea2;
	}
}
