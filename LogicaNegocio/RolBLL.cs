using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class RolBLL
    {
        private RolRepositorio repositorio = new RolRepositorio();

        public bool InsertarRol(rol Rol)
        {
            return repositorio.InsertarRol(Rol);
        }

        public bool ActualizarRol(rol Rol)
        {
            return repositorio.ActualizarRol(Rol);

        }

        public bool EliminarRol(rol rol)
        {
            return repositorio.EliminarRol(rol);

        }

        public List<rol> ObtenerRoles()
        {
            return repositorio.ObtenerRoles();

        }

        public List<rol> FiltrarRoles(int idRol, string nombreRol)
        {
            return repositorio.FiltrarRoles(idRol, nombreRol);
        }
    }
}
