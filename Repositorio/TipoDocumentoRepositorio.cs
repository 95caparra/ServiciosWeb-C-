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
    public class TipoDocumentoRepositorio : BaseRepositorioSQL<tipo_documento>
    {
        public bool InsertarTipoDocumento(tipo_documento tipoDocumento)
        {
            try
            {
                Insertar(tipoDocumento);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareTipoDocumento(tipo_documento tipoDocumento)
        {
            try
            {
                Actualizar(tipoDocumento);
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

        public bool EliminarTipoDocumento(tipo_documento tipoDocumento)
        {
            try
            {
                Eliminar(tipoDocumento);
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

        public List<tipo_documento> ObtenerTipoDocumentos()
        {
            try
            {
                return ObtenerTodos().Cast<tipo_documento>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<tipo_documento> FiltrarTiposDocumento(int idTipoDocumento, string nombreTipoDocumento,string abreviatura)
        {
            List<tipo_documento> lista = null;
            try
            {
                Expression<Func<tipo_documento, bool>> expresion = c => true;
                if (idTipoDocumento != 0)
                {
                    expresion = expresion.And(m => m.id_tipo_documento == idTipoDocumento);
                }
                if (!string.IsNullOrEmpty(nombreTipoDocumento))
                {
                    expresion = expresion.And(m => m.descripcion_documento.Contains(nombreTipoDocumento));
                }

                if (!string.IsNullOrEmpty(abreviatura))
                {
                    expresion = expresion.And(m => m.abreviatura.Contains(abreviatura));
                }
                lista = Filtrar(expresion).Cast<tipo_documento>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
