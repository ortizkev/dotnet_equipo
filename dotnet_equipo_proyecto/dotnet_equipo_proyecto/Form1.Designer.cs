/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC40
 * Fecha: 04/11/2026
 * Hora: 07:50 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace dotnet_equipo_proyecto
{
	partial class Form1
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
			this.lblX = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblX
			// 
			this.lblX.Location = new System.Drawing.Point(13, 13);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(100, 23);
			this.lblX.TabIndex = 0;
			this.lblX.Text = "Cordenada X";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cordenada Y";
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(93, 10);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(146, 20);
			this.txtX.TabIndex = 2;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(93, 46);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(146, 20);
			this.txtY.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(93, 121);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblX);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblX;
	}
}
