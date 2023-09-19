using System;

namespace Codigo_Azul
{
	public class Suceso
	{
		public string Estado { get; set; }
		public DateTime FechaInicio { get; set; } 
		public string Tipo { get; set; } 
		public string Descripcion { get; set; } 
		public string Sala { get; set; } 
		public string Nombre { get; set; } 
		public string Apellido { get; set; }
		public int Dni { get; set; }
		public string GrupoSanguineo { get; set; } 
		public string ObraSocial{ get; set; }	
		public string Medico{ get; set; }	
		public string Origen{ get; set; }	
		public int Numero { get; set; }		
		public Suceso()
		{
		}
	}
}
