using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BLL_Usuarios
	{
		 public static Usuarios Insert (Usuarios Entidad)
		{
			 return DAL_Usuarios.Insert(Entidad);
		}
		 public static bool Update (Usuarios Entidad)
		{
			 return DAL_Usuarios.Update(Entidad);
		}
		 public static bool Anular (Usuarios Entidad)
		{
			 return DAL_Usuarios.Anular(Entidad);
		}
		 public static bool Existe (Usuarios Entidad)
		{
			 return DAL_Usuarios.Existe(Entidad);
		}
		 public static Usuarios Registro (Usuarios Entidad)
		{
			 return DAL_Usuarios.Registro(Entidad);
		}
		 public static List<Usuarios> Lista (bool Activo = true)
		{
			 return DAL_Usuarios.Lista(Activo);
		}
	}
}
