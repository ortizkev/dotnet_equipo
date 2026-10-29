/*
 * Creado por SharpDevelop.
 * Usuario: kevin
 * Fecha: 29/10/2026
 * Hora: 12:14 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_equipo_proyecto
{
	/// <summary>
	/// Description of frmDinero.
	/// </summary>
	public partial class frmDinero : Form
	{
		public frmDinero()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		double c=0;
		void BtnCambiarClick(object sender, EventArgs e)
		{
			if (c==0){
				c++;
				lbl1.Text="Dólares";
				lbl2.Text="Pesos";
				return;
			}
			else if (c==1) {
				c--;
				lbl1.Text="Pesos";
				lbl2.Text="Dólares";
				return;
			}
						
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{

			
			if(string.IsNullOrWhiteSpace(txt1.Text)) {
			   	MessageBox.Show("Por favor, ingrese una cantidad","Campo vacío",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			   	return;
			}
			else {
				double valor=Convert.ToDouble(txt1.Text), n=0;
				if (c==0) {
				n=valor*0.053;
				txt2.Text=Convert.ToString(n);
				}
				else if (c==1) {
				n=valor*18.76;
				txt2.Text=Convert.ToString(n);
				}
			}
		}
	}
}
