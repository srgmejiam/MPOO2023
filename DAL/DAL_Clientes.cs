using EL;

namespace DAL
{
    public static class DAL_Clientes
    {
        public static Clientes Insert(Clientes Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Clientes.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Clientes Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.Clientes.Find(Entidad.IdCliente);

                Registro.NombreCliente = Entidad.NombreCliente;
                Registro.Numero = Entidad.Numero;
                Registro.Correo = Entidad.Correo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(Clientes Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.Clientes.Find(Entidad.IdCliente);
                Registro.Activo = false;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(Clientes Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.Clientes.Where(a => a.IdCliente == Entidad.IdCliente).Count() > 0;
            }
        }
        public static Clientes Registro(Clientes Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.Clientes.Where(a => a.IdCliente == Entidad.IdCliente).SingleOrDefault();
            }
        }
        public static List<Clientes> Lista(bool Activo = true)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.Clientes.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
