/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 14/09/2023
 * Time: 20:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Codigo_Azul
{
	partial class FormDatos
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Apellido:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "DNI: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(40, 77);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(100, 23);
			this.lbl_nombre.TabIndex = 3;
			this.lbl_nombre.Text = "Nombre:";
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_titulo.Location = new System.Drawing.Point(0, 0);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(356, 47);
			this.lbl_titulo.TabIndex = 4;
			this.lbl_titulo.Text = "Ingresar datos";
			this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 381);
			this.Controls.Add(this.lbl_titulo);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormDatos";
			this.Text = "FormDatos";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_titulo;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
