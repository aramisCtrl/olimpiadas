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
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_suceso = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.lbl_sala = new System.Windows.Forms.Label();
			this.lbl_descripcion = new System.Windows.Forms.Label();
			this.lbl_medico = new System.Windows.Forms.Label();
			this.lbl_paciente = new System.Windows.Forms.Label();
			this.lbl_inicio = new System.Windows.Forms.Label();
			this.lbl_tipo = new System.Windows.Forms.Label();
			this.lbl_estado = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 503);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1062, 65);
			this.panel1.TabIndex = 37;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(953, 19);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(841, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lbl_suceso);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1062, 45);
			this.panel2.TabIndex = 38;
			// 
			// lbl_suceso
			// 
			this.lbl_suceso.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_suceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_suceso.Location = new System.Drawing.Point(0, 0);
			this.lbl_suceso.Name = "lbl_suceso";
			this.lbl_suceso.Size = new System.Drawing.Size(1062, 45);
			this.lbl_suceso.TabIndex = 1;
			this.lbl_suceso.Text = "Suceso Nº 123456";
			this.lbl_suceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.comboBox4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.comboBox3);
			this.panel3.Controls.Add(this.dateTimePicker1);
			this.panel3.Controls.Add(this.comboBox2);
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.richTextBox1);
			this.panel3.Controls.Add(this.lbl_sala);
			this.panel3.Controls.Add(this.lbl_descripcion);
			this.panel3.Controls.Add(this.lbl_medico);
			this.panel3.Controls.Add(this.lbl_paciente);
			this.panel3.Controls.Add(this.lbl_inicio);
			this.panel3.Controls.Add(this.lbl_tipo);
			this.panel3.Controls.Add(this.lbl_estado);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 45);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1062, 458);
			this.panel3.TabIndex = 39;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(312, 262);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(179, 23);
			this.label6.TabIndex = 60;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(193, 257);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 59;
			this.label7.Text = "datos del paciente:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(312, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 23);
			this.label4.TabIndex = 58;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(193, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 57;
			this.label5.Text = "datos del paciente:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox4
			// 
			this.comboBox4.Enabled = false;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(773, 37);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(203, 21);
			this.comboBox4.TabIndex = 56;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(721, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 55;
			this.label3.Text = "Origen:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox3
			// 
			this.comboBox3.Enabled = false;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(465, 35);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(203, 21);
			this.comboBox3.TabIndex = 54;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new System.Drawing.Point(193, 36);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
			this.dateTimePicker1.TabIndex = 53;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(193, 108);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(298, 21);
			this.comboBox2.TabIndex = 52;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(193, 78);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(298, 21);
			this.comboBox1.TabIndex = 51;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(497, 175);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 25);
			this.button2.TabIndex = 50;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(497, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 25);
			this.button1.TabIndex = 49;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(193, 143);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(298, 20);
			this.textBox2.TabIndex = 48;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(193, 178);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(298, 20);
			this.textBox1.TabIndex = 47;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(312, 216);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 23);
			this.label1.TabIndex = 46;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(193, 211);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 45;
			this.label2.Text = "datos del paciente:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(193, 291);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(460, 137);
			this.richTextBox1.TabIndex = 44;
			this.richTextBox1.Text = "";
			// 
			// lbl_sala
			// 
			this.lbl_sala.Location = new System.Drawing.Point(87, 111);
			this.lbl_sala.Name = "lbl_sala";
			this.lbl_sala.Size = new System.Drawing.Size(100, 23);
			this.lbl_sala.TabIndex = 43;
			this.lbl_sala.Text = "Sala:";
			this.lbl_sala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_descripcion
			// 
			this.lbl_descripcion.Location = new System.Drawing.Point(87, 289);
			this.lbl_descripcion.Name = "lbl_descripcion";
			this.lbl_descripcion.Size = new System.Drawing.Size(100, 23);
			this.lbl_descripcion.TabIndex = 42;
			this.lbl_descripcion.Text = "Descripción:";
			this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_medico
			// 
			this.lbl_medico.Location = new System.Drawing.Point(87, 140);
			this.lbl_medico.Name = "lbl_medico";
			this.lbl_medico.Size = new System.Drawing.Size(100, 23);
			this.lbl_medico.TabIndex = 41;
			this.lbl_medico.Text = "Médico";
			this.lbl_medico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_paciente
			// 
			this.lbl_paciente.Location = new System.Drawing.Point(87, 175);
			this.lbl_paciente.Name = "lbl_paciente";
			this.lbl_paciente.Size = new System.Drawing.Size(100, 23);
			this.lbl_paciente.TabIndex = 40;
			this.lbl_paciente.Text = "Paciente:";
			this.lbl_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_inicio
			// 
			this.lbl_inicio.Location = new System.Drawing.Point(87, 31);
			this.lbl_inicio.Name = "lbl_inicio";
			this.lbl_inicio.Size = new System.Drawing.Size(100, 23);
			this.lbl_inicio.TabIndex = 39;
			this.lbl_inicio.Text = "Fecha de inicio:";
			this.lbl_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_tipo
			// 
			this.lbl_tipo.Location = new System.Drawing.Point(87, 76);
			this.lbl_tipo.Name = "lbl_tipo";
			this.lbl_tipo.Size = new System.Drawing.Size(100, 23);
			this.lbl_tipo.TabIndex = 38;
			this.lbl_tipo.Text = "Tipo:";
			this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_estado
			// 
			this.lbl_estado.Location = new System.Drawing.Point(412, 31);
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
			this.ClientSize = new System.Drawing.Size(1062, 568);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormSuceso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormSuceso";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_sala;
		private System.Windows.Forms.Label lbl_descripcion;
		private System.Windows.Forms.Label lbl_medico;
		private System.Windows.Forms.Label lbl_paciente;
		private System.Windows.Forms.Label lbl_inicio;
		private System.Windows.Forms.Label lbl_tipo;
		private System.Windows.Forms.Label lbl_estado;
		private System.Windows.Forms.Label lbl_suceso;
	}
}
