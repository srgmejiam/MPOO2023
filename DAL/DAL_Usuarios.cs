using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_Usuarios
    {
        public static Usuarios Insert(Usuarios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Usuarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Usuarios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.Usuarios.Find(Entidad.IdUsuario);
                Registro.NombreCompleto = Entidad.NombreCompleto;
                Registro.Correo = Entidad.Correo;
                Registro.UserName = Entidad.UserName;
                Registro.Password = Entidad.Password;
                Registro.Bloqueado = Entidad.Bloqueado;
                Registro.IntentosFallidos = Entidad.IntentosFallidos;
                Registro.IdRol = Entidad.IdRol;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(Usuarios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.Usuarios.Find(Entidad.IdUsuario);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(Usuarios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.Usuarios.Where(a => a.IdUsuario == Entidad.IdUsuario).Count() > 0;
            }
        }
        public static Usuarios Registro(Usuarios Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.Usuarios.Where(a => a.IdUsuario == Entidad.IdUsuario).SingleOrDefault();
            }
        }
        public static List<Usuarios> Lista(bool Activo = true)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.Usuarios.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
