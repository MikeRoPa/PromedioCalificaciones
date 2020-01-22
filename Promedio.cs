/*
 * Creado por SharpDevelop.
 * Usuario: Propietario
 * Fecha: 04/01/2020
 * Hora: 09:38 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace PromedioCalificaciones
{
	/// <summary>
	/// Description of Promedio.
	/// </summary>
	public class Promedio
	{
		//Atributos públicos de la clase
			public string alumno;
			public int calif1;
			public int calif2;
			public int calif3;
			public int calif4;
			
		//Metodos de la clase
			public int masBaja()
			{
				int menor=int.MaxValue;
				if (calif1 < calif2) menor = calif1; else menor = calif2;
				if (calif3 < menor) menor = calif3;
				if (calif4 < menor) menor = calif4;
				return menor;
			}
			
			public double calculaPromedio()
			{
				return (calif1+calif2+calif3+calif4) / 4.0;
			}
			
			public string asignaCondicion()
			{
				double promedio = calculaPromedio();
				if (promedio < 6)
					return "Desaprobado";
				else if (promedio >= 6 && promedio <= 8)
					return "Recuperación";
				else
					return "Aprobado";
			}
	}
}
