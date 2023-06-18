using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Roles
    {
        public static Roles Insert(Roles Entidad)
        {
            return DAL_Roles.Insert(Entidad);
        }
        public static bool Update(Roles Entidad)
        {
            return DAL_Roles.Update(Entidad);
        }
        public static bool Delete(Roles Entidad)
        {
            return DAL_Roles.Delete(Entidad);
        }
        public static Roles Registro(short IdRegistro)
        {
            return DAL_Roles.Registro(IdRegistro);
        }
        public static List<Roles> Listar(bool Activo = true)
        {
            return DAL_Roles.Listar(Activo);
        }
    }
}
