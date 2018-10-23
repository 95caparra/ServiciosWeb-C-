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
    public class ClasificacionRepositorio : BaseRepositorioSQL<clasificacion>
    {

        public bool InsertarClasificacion(clasificacion clasificacion)
        {
            try
            {
                Insertar(clasificacion);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar una clasificacion." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarClasificacion(clasificacion clasificacion)
        {
            try
            {
                Actualizar(clasificacion);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar una clasificacion." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarClasificacion(clasificacion clasificacion)
        {
            try
            {
                Eliminar(clasificacion);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una clasificacion." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<clasificacion> ObtenerClasificaciones()
        {
            try
            {
                return ObtenerTodos().Cast<clasificacion>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una clasificacion." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<clasificacion> FiltrarClasificaciones(int? idClasificacion, string nombreClasificacion = "")
        {
            List<clasificacion> lista = null;
            try
            {
                Expression<Func<clasificacion, bool>> expresion = c => true;
                if (idClasificacion != 0)
                {
                    expresion = expresion.And(m => m.id_clasificacion == idClasificacion);
                }
                if (!string.IsNullOrEmpty(nombreClasificacion))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreClasificacion));
                }
                lista = Filtrar(expresion).Cast<clasificacion>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
