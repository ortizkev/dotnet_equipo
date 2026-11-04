/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC40
 * Fecha: 04/11/2026
 * Hora: 07:50 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_equipo_proyecto
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
			double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);

            if (x > 0 && y > 0)
            {
                MessageBox.Show("Cuadrante 1");
            }
            else if (x < 0 && y > 0)
            {
                MessageBox.Show("Cuadrante 2");
            }
            else if (x < 0 && y < 0)
            {
                MessageBox.Show("Cuadrante 3");
            }
            else if (x > 0 && y < 0)
			{
                MessageBox.Show("Cuadrante 4");
            }
            else
            {
                MessageBox.Show("Centro o Eje");
            }            	
		}
	}
}
