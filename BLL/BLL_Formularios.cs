using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BLL_Formularios
	{
		 public static Formularios Insert (Formularios Entidad)
		{
			 return DAL_Formularios.Insert(Entidad);
		}
		 public static bool Update (Formularios Entidad)
		{
			 return DAL_Formularios.Update(Entidad);
		}
		 public static bool Anular (Formularios Entidad)
		{
			 return DAL_Formularios.Anular(Entidad);
		}
		 public static bool Existe (Formularios Entidad)
		{
			 return DAL_Formularios.Existe(Entidad);
		}
		 public static Formularios Registro (Formularios Entidad)
		{
			 return DAL_Formularios.Registro(Entidad);
		}
		 public static List<Formularios> Lista (bool Activo = true)
		{
			 return DAL_Formularios.Lista(Activo);
		}
	}
}
