/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 29/10/2026
 * Hora: 12:14 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace dotnet_equipo_proyecto
{
	partial class frmDinero
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnCambiar = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(13, 13);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(249, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "\" Pesos a Dolares \"";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(12, 71);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 20);
			this.txt1.TabIndex = 1;
			// 
			// txt2
			// 
			this.txt2.Enabled = false;
			this.txt2.Location = new System.Drawing.Point(162, 70);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 20);
			this.txt2.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(99, 106);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnCambiar
			// 
			this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCambiar.Location = new System.Drawing.Point(117, 39);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(39, 28);
			this.btnCambiar.TabIndex = 4;
			this.btnCambiar.Text = "⇄";
			this.btnCambiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCambiar.UseVisualStyleBackColor = true;
			this.btnCambiar.Click += new System.EventHandler(this.BtnCambiarClick);
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(13, 61);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(100, 11);
			this.lbl1.TabIndex = 5;
			this.lbl1.Text = "Pesos";
			// 
			// lbl2
			// 
			this.lbl2.Location = new System.Drawing.Point(162, 61);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(100, 11);
			this.lbl2.TabIndex = 6;
			this.lbl2.Text = "Dolares";
			// 
			// frmDinero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 153);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btnCambiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lblTitulo);
			this.Name = "frmDinero";
			this.Text = "Equivalencias";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btnCambiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lblTitulo;
	}
}
