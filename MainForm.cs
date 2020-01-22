/*
 * Creado por SharpDevelop.
 * Usuario: Propietario
 * Fecha: 04/01/2020
 * Hora: 09:14 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PromedioCalificaciones
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
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			//Objeto de la clase Promedio
			Promedio objP = new Promedio();
			
			//Enviando los valores a la clase
			objP.alumno = txtAlumno.Text;
			
			
			//Imprimiendo los valores
			try
			{
				objP.calif1 = int.Parse(txtCalif01.Text);
				objP.calif2 = int.Parse(txtCalif02.Text);
				objP.calif3 = int.Parse(txtCalif03.Text);
				objP.calif4 = int.Parse(txtCalif04.Text);
				
				if ((objP.calif1 <0) || (objP.calif2<0) || (objP.calif3<0) || (objP.calif4<0))
					BtnLimpiarClick();
				else 
				{
				lblPromedio.Text = objP.calculaPromedio().ToString("0.00");
				lblCalifMenor.Text = objP.masBaja().ToString("0.00");
				lblCondicion.Text = objP.asignaCondicion();
				}
			} 
			catch (Exception) 
			{   
				BtnLimpiarClick(); 
			}
			
		
		}
		
		void BtnLimpiarClick()
		{
			txtAlumno.Text = "";
			txtCalif01.Text= "";
			txtCalif02.Text= "";
			txtCalif03.Text="";
			txtCalif04.Text= "";
			lblPromedio.Text = "0.00";
			lblCalifMenor.Text = "0.00";
			lblCondicion.Text = "0.00";
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtAlumno.Text = "";
			txtCalif01.Text= "";
			txtCalif02.Text= "";
			txtCalif03.Text="";
			txtCalif04.Text= "";
			lblPromedio.Text = "0.00";
			lblCalifMenor.Text = "0.00";
			lblCondicion.Text = "0.00";
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
