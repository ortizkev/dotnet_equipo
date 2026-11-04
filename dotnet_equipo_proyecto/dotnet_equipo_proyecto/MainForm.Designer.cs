/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 28/10/2026
 * Hora: 7:53 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace dotnet_equipo_proyecto
{
	partial class MainForm
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
			this.btnIngresar = new System.Windows.Forms.Button();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(26, 126);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(75, 23);
			this.btnIngresar.TabIndex = 0;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(26, 13);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(100, 23);
			this.lblUsuario.TabIndex = 1;
			this.lblUsuario.Text = "Usuario :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Contraseña :";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(92, 10);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(169, 20);
			this.txtUsuario.TabIndex = 3;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(92, 66);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(169, 20);
			this.txtContraseña.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 264);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.btnIngresar);
			this.Name = "MainForm";
			this.Text = "dotnet_equipo_proyecto";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Button btnIngresar;
	}
}
