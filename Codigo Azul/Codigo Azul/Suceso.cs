using System;

namespace Codigo_Azul
{
	public class Suceso
	{
		public int Id { get; set; }		
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
		public int SuceAreaId{ get; set; }
		public int SuceSuesId{ get; set; }
		public int SucePaciId{ get; set; }
		public int SuceSutiId{ get; set; }
		public int SuceUsuaId{ get; set; }
		public int SuceSuorId{ get; set; }
		public int SucePaciSalaId{ get; set; }
		
		public Suceso()
		{
		Id=0;		
		Estado="";
		Tipo="";
		Descripcion=""; 
		Sala=""; 
		Nombre=""; 
		Apellido="";
		Dni=0;
		GrupoSanguineo=""; 
		ObraSocial="";
		Medico="";	
		Origen="";	
		SuceAreaId=0;
		SuceSuesId=0;
		SucePaciId=0;
		SuceSutiId=0;
		SuceUsuaId=0;
		SuceSuorId=0;
		SucePaciSalaId=0;
		}
	}
}
