using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_Permisos
    {
        //Insertar
        public static Permisos Insert(Permisos Entidad)
        {
            using BDMPOO bd = new();
            Entidad.Activo = true;
            Entidad.FechaRegistro = DateTime.Now;
            bd.Permisos.Add(Entidad);
            bd.SaveChanges();
            return Entidad;
        }

        //Actualizar
        public static bool Update(Permisos Entidad)
        {
            using BDMPOO bd = new();
            var Registro = bd.Permisos.Find(Entidad.IdPermiso);
            if (Registro == null)
            {
                return false;
            }
            Registro.Permiso = Entidad.Permiso;
            Registro.FechaActualizacion = DateTime.Now;
            return bd.SaveChanges() > 0;
        }

        //Anular
        public static bool Delete(Permisos Entidad)
        {
            using BDMPOO bd = new();
            var Registro = bd.Permisos.Find(Entidad.IdPermiso);
            if (Registro == null)
            {
                return false;
            }
            Registro.Activo = false;
            Registro.FechaActualizacion = DateTime.Now;
            return bd.SaveChanges() > 0;
        }

        //Seleccionar un Registro
        public static Permisos Registro(short IdRegistro)
        {
            using BDMPOO bd = new();
            return bd.Permisos.Find(IdRegistro);
        }

        //Listar todos los registros
        public static List<Permisos> Listar(bool Activo = true)
        {
            using BDMPOO bd = new();
            return bd.Permisos.Where(a => a.Activo == Activo && a.FechaRegistro > DateTime.Now).ToList();
        }
    }
}
