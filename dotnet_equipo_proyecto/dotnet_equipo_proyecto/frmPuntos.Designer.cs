/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 04/11/2026
 * Hora: 7:26 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace dotnet_equipo_proyecto
{
	partial class frmPuntos
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
			this.txbX1 = new System.Windows.Forms.TextBox();
			this.txbX2 = new System.Windows.Forms.TextBox();
			this.txbY1 = new System.Windows.Forms.TextBox();
			this.txbY2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAtras = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "\" Distancia entre dos puntos\"";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Punto A";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(148, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Punto B";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txbX1
			// 
			this.txbX1.Location = new System.Drawing.Point(36, 80);
			this.txbX1.Name = "txbX1";
			this.txbX1.Size = new System.Drawing.Size(33, 20);
			this.txbX1.TabIndex = 3;
			// 
			// txbX2
			// 
			this.txbX2.Location = new System.Drawing.Point(148, 80);
			this.txbX2.Name = "txbX2";
			this.txbX2.Size = new System.Drawing.Size(33, 20);
			this.txbX2.TabIndex = 4;
			// 
			// txbY1
			// 
			this.txbY1.Location = new System.Drawing.Point(76, 80);
			this.txbY1.Name = "txbY1";
			this.txbY1.Size = new System.Drawing.Size(34, 20);
			this.txbY1.TabIndex = 5;
			// 
			// txbY2
			// 
			this.txbY2.Location = new System.Drawing.Point(189, 80);
			this.txbY2.Name = "txbY2";
			this.txbY2.Size = new System.Drawing.Size(33, 20);
			this.txbY2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(36, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "x1";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(77, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "y1";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(150, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "x2";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(189, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "y2";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAtras
			// 
			this.btnAtras.Location = new System.Drawing.Point(130, 119);
			this.btnAtras.Name = "btnAtras";
			this.btnAtras.Size = new System.Drawing.Size(75, 23);
			this.btnAtras.TabIndex = 14;
			this.btnAtras.Text = "Atras";
			this.btnAtras.UseVisualStyleBackColor = true;
			this.btnAtras.Click += new System.EventHandler(this.BtnAtrasClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(49, 119);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 13;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// frmPuntos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 154);
			this.Controls.Add(this.btnAtras);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txbY2);
			this.Controls.Add(this.txbY1);
			this.Controls.Add(this.txbX2);
			this.Controls.Add(this.txbX1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Name = "frmPuntos";
			this.Text = "frmPuntos";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnAtras;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbY2;
		private System.Windows.Forms.TextBox txbY1;
		private System.Windows.Forms.TextBox txbX2;
		private System.Windows.Forms.TextBox txbX1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
