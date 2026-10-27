/*
 * Created by SharpDevelop.
 * User: CC2_PC18
 * Date: 27/10/2026
 * Time: 07:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PracticaGit2
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
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtNum1.Text);
    		double n2 = Convert.ToDouble(txtNum2.Text);
    		lblResultado.Text = "Resultado: " + (n1 + n2);			
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtNum1.Text);
    		double n2 = Convert.ToDouble(txtNum2.Text);
    		lblResultado.Text = "Resultado: " + (n1 - n2);			
		}
		
		void BtnMultiClick(object sender, EventArgs e)
		{
			 double n1 = Convert.ToDouble(txtNum1.Text);
    		double n2 = Convert.ToDouble(txtNum2.Text);
    		lblResultado.Text = "Resultado: " + (n1 * n2);			
		}
		
		void BtnDividClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtNum1.Text);
    		double n2 = Convert.ToDouble(txtNum2.Text);
    		if (n2 != 0)
        	lblResultado.Text = "Resultado: " + (n1 / n2);
    	else
        	lblResultado.Text = "No se puede dividir entre cero";			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtNum1.Text);
    		double n2 = Convert.ToDouble(txtNum2.Text);
    		lblResultado.Text = "Resultado Modulo: " + (n1 % n2);			
		}
		
		void BtnFormulaClick(object sender, EventArgs e)
		{
			FormFormula ventana = new FormFormula();
    		ventana.Show();			
		}
	}
}
