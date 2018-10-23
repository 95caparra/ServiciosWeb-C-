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
    public class SolicitudRepositorio : BaseRepositorioSQL<solicitud>
    {
        public bool InsertarSolicitud(solicitud solicitud)
        {
            try
            {
                Insertar(solicitud);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarSolicitud(solicitud solicitud)
        {
            try
            {
                Actualizar(solicitud);
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

        public bool EliminarSolicitud(solicitud solicitud)
        {
            try
            {
                Eliminar(solicitud);
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

        public List<solicitud> ObtenerSolicituds()
        {
            try
            {
                return ObtenerTodos().Cast<solicitud>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }


        public List<solicitud> FiltrarSolicitudes(int idSolicitud, string nombreCliente, int cantidadPersonas,string telefono,string email,int TipoEvento, string hora, 
            DateTime fecha,string observaciones, string estado, bool? visto)
        {
            List<solicitud> lista = null;
            try
            {
                Expression<Func<solicitud, bool>> expresion = c => true;
                if (idSolicitud != 0)
                {
                    expresion = expresion.And(m => m.id_solicitud == idSolicitud);
                }
                if (!string.IsNullOrEmpty(nombreCliente))
                {
                    expresion = expresion.And(m => m.nombre_cliente.Contains(nombreCliente));
                }
                if (cantidadPersonas!= 0)
                {
                    expresion = expresion.And(m => m.cantidad_personas== cantidadPersonas);
                }
                if (!string.IsNullOrEmpty(telefono))
                {
                    expresion = expresion.And(m => m.telefono.Contains(telefono));
                }
                if (!string.IsNullOrEmpty(email))
                {
                    expresion = expresion.And(m => m.email.Contains(email));
                }
                if (TipoEvento !=  0)
                {
                    expresion = expresion.And(m => m.id_tipo_evento == TipoEvento);
                }
                if (!string.IsNullOrEmpty(hora))
                {
                    expresion = expresion.And(m => m.hora.Contains(hora));
                }

                if (!string.IsNullOrEmpty(fecha.ToString()))
                {
                    expresion = expresion.And(m => m.fecha == fecha);
                }
                if (!string.IsNullOrEmpty(observaciones))
                {
                    expresion = expresion.And(m => m.observaciones.Contains(observaciones));
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.nombre_cliente.Contains(estado));
                }
                if (visto != null)
                {
                    expresion = expresion.And(m => m.visto == visto);
                }
                
                lista = Filtrar(expresion).Cast<solicitud>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
