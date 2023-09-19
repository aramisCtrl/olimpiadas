using System;

namespace Codigo_Azul
{
	public class Usuario
	{
		public int ID { get; set; }
		public string Nombre { get; set; } 
		public string Apellido { get; set; } 
		public string User { get; set; } 
		public string Contraseña { get; set; } 
		public int RolID { get; set; } 
		public int AreaID { get; set; }
		public string RolNombre { get; set; } 
		public string AreaDescripcion { get; set; } 

		// Constructor por defecto
		public Usuario()
		{
			ID				= 0;
			RolID 			= 0;
			AreaID 			= 0;		
			Nombre			= "";
			Apellido 		= "";
			User			= "";
			Contraseña  	= "";
			RolNombre 		= "";
			AreaDescripcion	= "";
		}

		// Constructor con parámetros para crear un paciente con datos iniciales
		public Usuario(string nombre, string apellido, string Usuario, string Contraseña,
		               int RolID, int AreaID, string RolNombre, string AreaDescripcion)
		{
			Nombre = nombre;
			Apellido = apellido;
			//Usuario = usuario;
			//Contraseña = Contraseña;
			//RolID = RolID;
			//AreaID = AreaID;
			//RolNombre = RolNombre;
			//AreaDescripcion	= AreaDescripcion;
		}
	}
}