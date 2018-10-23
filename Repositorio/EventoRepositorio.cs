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
    public class EventoRepositorio : BaseRepositorioSQL<evento>
    {
        public bool InsertarEvento(evento evento)
        {
            try
            {
                Insertar(evento);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareEvento(evento evento)
        {
            try
            {
                Actualizar(evento);
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

        public bool EliminarEvento(evento evento)
        {
            try
            {
                Eliminar(evento);
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

        public List<evento> ObtenerEventos()
        {
            try
            {
                return ObtenerTodos().Cast<evento>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<evento> FiltrarEstadosEventos(long idEvento, long IdSolicitud, long idCliente, int tipoEvento, int idLugar
            , int cantidadPersonas, int cantidadMeseros, DateTime horaInicio , DateTime horaFin , DateTime fecha ,
            decimal precio, string observaciones , int estado)
        {
            List<evento> lista = null;
            try
            {
                Expression<Func<evento, bool>> expresion = c => true;
                if (idEvento != 0)
                {
                    expresion = expresion.And(m => m.id_evento == idEvento);
                }
                if (IdSolicitud != 0)
                {
                    expresion = expresion.And(m => m.solicitud_id_solicitud == IdSolicitud);
                }
                if (idCliente != 0)
                {
                    expresion = expresion.And(m => m.cliente_id_cliente == idCliente);
                }
                if (tipoEvento != 0)
                {
                    expresion = expresion.And(m => m.tipo_evento == tipoEvento);
                }
                if (idLugar != 0)
                {
                    expresion = expresion.And(m => m.id_lugar == idLugar);
                }
                if (cantidadPersonas != 0)
                {
                    expresion = expresion.And(m => m.cantidad_personas == cantidadPersonas);
                }
                if (cantidadMeseros != 0)
                {
                    expresion = expresion.And(m => m.cantidad_meseros == cantidadMeseros);
                }
                if (horaInicio != null)
                {
                    expresion = expresion.And(m => m.hora_inicio == horaInicio);
                }
                if (horaInicio != null)
                {
                    expresion = expresion.And(m => m.hora_inicio == horaInicio);
                }
                if (horaFin != null)
                {
                    expresion = expresion.And(m => m.hora_fin == horaFin);
                }
                if (fecha != null)
                {
                    expresion = expresion.And(m => m.fecha == fecha);
                }

                if (precio != 0)
                {
                    expresion = expresion.And(m => m.precio == precio);
                }
                if (string.IsNullOrEmpty(observaciones))
                {
                    expresion = expresion.And(m => m.observaciones.Contains(observaciones));
                }
                if (estado != 0)
                {
                    expresion = expresion.And(m => m.estado_evento == estado);
                }
                lista = Filtrar(expresion).Cast<evento>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
