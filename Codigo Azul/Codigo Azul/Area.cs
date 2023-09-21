//
using System;

namespace Codigo_Azul
{
	/// <summary>
	/// Description of Area.
	/// </summary>
		public class Area
	{
		public int ID { get; set; }
		public string Nombre { get; set; } 
		

		// Constructor por defecto
		public Area()
		{
			ID				= 0;			
			Nombre			= "";
		}
		
		// Constructor con parámetros para crear un paciente con datos iniciales
		public Area(string nombre)
		{
			Nombre = nombre;
		}
	}
}

