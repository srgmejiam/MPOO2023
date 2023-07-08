using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BLL_Permisos
	{
		 public static Permisos Insert (Permisos Entidad)
		{
			 return DAL_Permisos.Insert(Entidad);
		}
		 public static bool Update (Permisos Entidad)
		{
			 return DAL_Permisos.Update(Entidad);
		}
		 public static bool Anular (Permisos Entidad)
		{
			 return DAL_Permisos.Delete(Entidad);
		}
		
	}
}
