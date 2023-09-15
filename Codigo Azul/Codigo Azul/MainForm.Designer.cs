namespace Codigo_Azul
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
			this.pic_fondo = new System.Windows.Forms.PictureBox();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.lbl_contraseña = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_fondo
			// 
			this.pic_fondo.BackColor = System.Drawing.SystemColors.HighlightText;
			this.pic_fondo.Location = new System.Drawing.Point(119, 79);
			this.pic_fondo.Name = "pic_fondo";
			this.pic_fondo.Size = new System.Drawing.Size(272, 221);
			this.pic_fondo.TabIndex = 3;
			this.pic_fondo.TabStop = false;
			// 
			// txt_usuario
			// 
			this.txt_usuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.txt_usuario.Location = new System.Drawing.Point(227, 134);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(121, 20);
			this.txt_usuario.TabIndex = 6;
			this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.txt_contraseña.Location = new System.Drawing.Point(227, 178);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.Size = new System.Drawing.Size(121, 20);
			this.txt_contraseña.TabIndex = 5;
			this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_ingresar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_ingresar.Location = new System.Drawing.Point(202, 229);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(107, 33);
			this.btn_ingresar.TabIndex = 4;
			this.btn_ingresar.Text = "Ingresar";
			this.btn_ingresar.UseVisualStyleBackColor = false;
			this.btn_ingresar.Click += new System.EventHandler(this.Btn_ingresarClick);
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_usuario.Location = new System.Drawing.Point(145, 132);
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
			this.lbl_contraseña.Location = new System.Drawing.Point(145, 175);
			this.lbl_contraseña.Name = "lbl_contraseña";
			this.lbl_contraseña.Size = new System.Drawing.Size(76, 23);
			this.lbl_contraseña.TabIndex = 8;
			this.lbl_contraseña.Text = "Contraseña:";
			this.lbl_contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(517, 398);
			this.Controls.Add(this.lbl_contraseña);
			this.Controls.Add(this.lbl_usuario);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.btn_ingresar);
			this.Controls.Add(this.pic_fondo);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Codigo Azul";
			((System.ComponentModel.ISupportInitialize)(this.pic_fondo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lbl_contraseña;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.PictureBox pic_fondo;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.Button btn_ingresar;
	}
}
