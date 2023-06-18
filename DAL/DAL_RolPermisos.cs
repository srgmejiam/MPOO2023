using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_RolPermisos
    {
        public static RolPermisos Insert(RolPermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.RolPermisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RolPermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.IdRol = Entidad.IdRol;
                Registro.IdPermiso = Entidad.IdPermiso;
                Registro.IdRolForumulario = Entidad.IdRolForumulario;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(RolPermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(RolPermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolPermisos.Where(a => a.IdRolPermiso == Entidad.IdRolPermiso).Count() > 0;
            }
        }
        public static RolPermisos Registro(RolPermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolPermisos.Where(a => a.IdRolPermiso == Entidad.IdRolPermiso).SingleOrDefault();
            }
        }
        public static List<RolPermisos> Lista(bool Activo = true)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolPermisos.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
