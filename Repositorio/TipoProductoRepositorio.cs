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
    public class TipoProductoRepositorio : BaseRepositorioSQL<tipo_producto>
    {
        public bool InsertarTipoProducto(tipo_producto tipoProducto)
        {
            try
            {
                Insertar(tipoProducto);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Tipo de Producto." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarTipoProducto(tipo_producto tipoProducto)
        {
            try
            {
                Actualizar(tipoProducto);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar un tipo de Producto." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarTipoProducto(tipo_producto tipoProducto)
        {
            try
            {
                Eliminar(tipoProducto);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un tipo de Producto." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<tipo_producto> ObtenerTipoProducto()
        {
            try
            {
                return ObtenerTodos().Cast<tipo_producto>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un tipo de Producto." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<tipo_producto> FiltrarTipoProductos(int idTipoProducto, string nombreTipoProducto)
        {
            List<tipo_producto> lista = null;
            try
            {
                Expression<Func<tipo_producto, bool>> expresion = c => true;
                if (idTipoProducto != 0)
                {
                    expresion = expresion.And(m => m.id_tipo_producto == idTipoProducto);
                }
                if (!string.IsNullOrEmpty(nombreTipoProducto))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreTipoProducto));
                }
                lista = Filtrar(expresion).Cast<tipo_producto>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
