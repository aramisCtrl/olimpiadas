﻿namespace Codigo_Azul
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
		    if (disposing && (components != null))
		    {
		        components.Dispose();
		    }
		    base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.lbl_contraseña = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_usuario
			// 
			this.txt_usuario.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txt_usuario.Location = new System.Drawing.Point(245, 250);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(121, 20);
			this.txt_usuario.TabIndex = 0;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txt_contraseña.Location = new System.Drawing.Point(245, 294);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.PasswordChar = '*';
			this.txt_contraseña.Size = new System.Drawing.Size(121, 20);
			this.txt_contraseña.TabIndex = 1;
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_usuario.Location = new System.Drawing.Point(163, 248);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(76, 23);
			this.lbl_usuario.TabIndex = 7;
			this.lbl_usuario.Text = "Usuario:";
			this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_contraseña
			// 
			this.lbl_contraseña.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_contraseña.Location = new System.Drawing.Point(163, 291);
			this.lbl_contraseña.Name = "lbl_contraseña";
			this.lbl_contraseña.Size = new System.Drawing.Size(76, 23);
			this.lbl_contraseña.TabIndex = 8;
			this.lbl_contraseña.Text = "Contraseña:";
			this.lbl_contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.SystemColors.Window;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnIngresar.Location = new System.Drawing.Point(245, 335);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(121, 33);
			this.btnIngresar.TabIndex = 2;
			this.btnIngresar.Text = "Aceptar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(79, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(362, 372);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(430, 453);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(517, 488);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.lbl_contraseña);
			this.Controls.Add(this.lbl_usuario);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_contraseña;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button button1;
	}
}
