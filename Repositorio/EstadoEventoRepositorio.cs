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
    public class EstadoEventoRepositorio : BaseRepositorioSQL<estado_evento>
    {
        public bool InsertarEstadoEvento(estado_evento estadoEvento)
        {
            try
            {
                Insertar(estadoEvento);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareEstadoEvento(estado_evento estadoEvento)
        {
            try
            {
                Actualizar(estadoEvento);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar una Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarEstadoEvento(estado_evento estadoEvento)
        {
            try
            {
                Eliminar(estadoEvento);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<estado_evento> ObtenerEstadoEventos()
        {
            try
            {
                return ObtenerTodos().Cast<estado_evento>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<estado_evento> FiltrarEstadosEventos(int idEstadoEvento, string nombreEstadoEvento)
        {
            List<estado_evento> lista = null;
            try
            {
                Expression<Func<estado_evento, bool>> expresion = c => true;
                if (idEstadoEvento != 0)
                {
                    expresion = expresion.And(m => m.id_estado_evento == idEstadoEvento);
                }
                if (!string.IsNullOrEmpty(nombreEstadoEvento))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreEstadoEvento));
                }
                lista = Filtrar(expresion).Cast<estado_evento>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
