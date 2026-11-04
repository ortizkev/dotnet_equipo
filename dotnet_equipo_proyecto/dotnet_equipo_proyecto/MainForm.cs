/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 28/10/2026
 * Hora: 7:53 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_equipo_proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(txtUsuario.Text == "admin" && txtContraseña.Text == "1234")
			{
				MessageBox.Show("¡Acceso Correcto!","Bienvenido",MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			{
			frmMenu frm = new frmMenu();
			frm.Show();
			this.Hide();
			}
		}
	}
}
