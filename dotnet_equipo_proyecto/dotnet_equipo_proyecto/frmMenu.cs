/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 29/10/2026
 * Hora: 11:49 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_equipo_proyecto
{
	/// <summary>
	/// Description of frmMenu.
	/// </summary>
	public partial class frmMenu : Form
	{
		public frmMenu()
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
			frmDinero frm = new frmDinero();
			frm.Show();
			this.Hide();
		}
	}
}
