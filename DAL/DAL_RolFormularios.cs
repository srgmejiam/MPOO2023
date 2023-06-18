using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_RolFormularios
    {
        public static RolFormularios Insert(RolFormularios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.RolFormularios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RolFormularios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.RolFormularios.Find(Entidad.IdRolFormulario);
                Registro.IdRol = Entidad.IdRol;
                Registro.IdFormulario = Entidad.IdFormulario;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(RolFormularios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.RolFormularios.Find(Entidad.IdRolFormulario);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(RolFormularios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolFormularios.Where(a => a.IdRolFormulario == Entidad.IdRolFormulario).Count() > 0;
            }
        }
        public static RolFormularios Registro(RolFormularios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolFormularios.Where(a => a.IdRolFormulario == Entidad.IdRolFormulario).SingleOrDefault();
            }
        }
        public static List<RolFormularios> Lista(bool Activo = true)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolFormularios.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
