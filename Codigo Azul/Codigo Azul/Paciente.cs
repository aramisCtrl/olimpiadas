/*
 * Created by SharpDevelop.
 * User: jerem
 * Date: 17/9/2023
 * Time: 13:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Codigo_Azul
{
	public class Paciente
	{
		public int ID { get; set; }
		public string Nombre { get; set; } 
		public string Apellido { get; set; } 
		public string Dni { get; set; } 
		public string GrupoSanguineo { get; set; } 
		public int ObraSocialID { get; set; } 
		public int CiudadID { get; set; }
		public int ProvinciaID { get; set; }
		public string Telefono { get; set; } 
		public string Email { get; set; }
		public string Direccion { get; set; } 
		public string ObraSocialDescripcion{ get; set; }
		public string CiudadNombre { get; set; } 	
		public string ProvinciaNombre { get; set; } 		

		// Constructor por defecto
		public Paciente()
		{
			ID				= 0;
			ObraSocialID 	= 0;
			CiudadID 		= 0;
			ProvinciaID 	= 0;			
			Nombre			= "";
			Apellido 		= "";
			Dni 			= "";
			GrupoSanguineo  = "";
			Telefono 		= "";
			Email  			= "";
			Direccion  		= "";
			 ObraSocialDescripcion = "";
			 CiudadNombre = "";
			 ProvinciaNombre ="";
		}

		// Constructor con parámetros para crear un paciente con datos iniciales
		public Paciente(string nombre, string apellido, string dni, string grupoSanguineo,
		                int obraSocialID, int ciudadID, int provinciaID, string telefono,
		                string email, string direccion)
		{
			Nombre = nombre;
			Apellido = apellido;
			Dni = dni;
			GrupoSanguineo = grupoSanguineo;
			ObraSocialID = obraSocialID;
			CiudadID = ciudadID;
			ProvinciaID = provinciaID;
			Telefono = telefono;
			Email = email;
			Direccion = direccion;
		}
	}

}
