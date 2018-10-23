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
    public class TipoEventoRepositorio : BaseRepositorioSQL<tipo_evento>
    {
        public bool InsertarTipoEvento(tipo_evento tipoEvento)
        {
            try
            {
                Insertar(tipoEvento);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareTipoEvento(tipo_evento tipoEvento)
        {
            try
            {
                Actualizar(tipoEvento);
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

        public bool EliminarTipoEvento(tipo_evento tipoEvento)
        {
            try
            {
                Eliminar(tipoEvento);
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

        public List<tipo_evento> ObtenerTipoEventos()
        {
            try
            {
                return ObtenerTodos().Cast<tipo_evento>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<tipo_evento> FiltrarTiposEvento(int idTipoEvento, string nombreTipoEvento)
        {
            List<tipo_evento> lista = null;
            try
            {
                Expression<Func<tipo_evento, bool>> expresion = c => true;
                if (idTipoEvento != 0)
                {
                    expresion = expresion.And(m => m.id_tipo_evento == idTipoEvento);
                }
                if (!string.IsNullOrEmpty(nombreTipoEvento))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreTipoEvento));
                }
                lista = Filtrar(expresion).Cast<tipo_evento>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
