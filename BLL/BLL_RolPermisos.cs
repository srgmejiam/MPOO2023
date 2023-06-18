using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BLL_RolPermisos
	{
		 public static RolPermisos Insert (RolPermisos Entidad)
		{
			 return DAL_RolPermisos.Insert(Entidad);
		}
		 public static bool Update (RolPermisos Entidad)
		{
			 return DAL_RolPermisos.Update(Entidad);
		}
		 public static bool Anular (RolPermisos Entidad)
		{
			 return DAL_RolPermisos.Anular(Entidad);
		}
		 public static bool Existe (RolPermisos Entidad)
		{
			 return DAL_RolPermisos.Existe(Entidad);
		}
		 public static RolPermisos Registro (RolPermisos Entidad)
		{
			 return DAL_RolPermisos.Registro(Entidad);
		}
		 public static List<RolPermisos> Lista (bool Activo = true)
		{
			 return DAL_RolPermisos.Lista(Activo);
		}
	}
}
