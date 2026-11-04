/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 04/11/2026
 * Hora: 7:26 a. m. 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_equipo_proyecto
{
	/// <summary>
	/// Description of frmPuntos.
	/// </summary>
	public partial class frmPuntos : Form
	{
		public frmPuntos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double x1=Convert.ToDouble(txbX1.Text), y1=Convert.ToDouble(txbY1.Text);
			double x2=Convert.ToDouble(txbX2.Text), y2=Convert.ToDouble(txbY2.Text);
			double distancia=0, xs=0, ys=0;
			xs=Math.Pow((x1+x2),2);
			ys=Math.Pow((y1+y2),2);
			distancia=Math.Sqrt(xs+ys);
			MessageBox.Show("La distancia entre el punto A y el punto B es:"+distancia);
		}
		
		void BtnAtrasClick(object sender, EventArgs e)
		{
			frmMenu menu = new frmMenu();
			menu.Show();
			this.Hide();			
		}
	}
}
