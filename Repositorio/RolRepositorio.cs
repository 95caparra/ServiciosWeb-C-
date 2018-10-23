using Dominio;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RolRepositorio : BaseRepositorioSQL<rol>
    {
        public bool InsertarRol(rol rol)
        {
            try
            {
                Insertar(rol);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un rol." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarRol(rol rol)
        {
            try
            {
                Actualizar(rol);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar un rol." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarRol(rol rol)
        {
            try
            {
                Eliminar(rol);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un rol." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<rol> ObtenerRoles()
        {
            try
            {
                return ObtenerTodos().Cast<rol>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un rol." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<rol> FiltrarRoles(int idrol, string nombrerol)
        {
            List<rol> lista = null;
            try
            {
                Expression<Func<rol, bool>> expresion = c => true;
                if (idrol != 0)
                {
                    expresion = expresion.And(m => m.id_rol == idrol);
                }
                if (!string.IsNullOrEmpty(nombrerol))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombrerol));
                }
                lista = Filtrar(expresion).Cast<rol>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
