using System;

namespace Codigo_Azul
{
	public class Sala
	{
		public int ID { get; set; }
		public string Descripcion { get; set; } 
		public int AreaID { get; set; }

		// Constructor por defecto
		public Sala()
		{
			ID				= 0;
			AreaID 			= 0;		
			Descripcion		= "";
		}

		// Constructor con parámetros para crear una sala con datos iniciales
		public Sala(string descripcion, int areaID)
		{
			Descripcion	= descripcion;
			AreaID = areaID;
		}
	}
}
