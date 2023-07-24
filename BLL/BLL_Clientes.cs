using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Clientes
    {
        public static Clientes Insert(Clientes Entidad)
        {
            return DAL_Clientes.Insert(Entidad);
        }
        public static bool Update(Clientes Entidad)
        {
            return DAL_Clientes.Update(Entidad);
        }
        public static bool Anular(Clientes Entidad)
        {
            return DAL_Clientes.Anular(Entidad);
        }
        public static bool Existe(Clientes Entidad)
        {
            return DAL_Clientes.Existe(Entidad);
        }
        public static Clientes Registro(Clientes Entidad)
        {
            return DAL_Clientes.Registro(Entidad);
        }
        public static List<Clientes> Lista(bool Activo = true)
        {
            return DAL_Clientes.Lista(Activo);
        }
        public static bool ExisteNumero(string Numero, int IdRegistro)
        {
            return DAL_Clientes.ExisteNumero(Numero, IdRegistro);
        }
        public static bool ExisteCorreo(string Email, int IdRegistro)
        {
            return DAL_Clientes.ExisteCorreo(Email, IdRegistro);
        }

    }
}
