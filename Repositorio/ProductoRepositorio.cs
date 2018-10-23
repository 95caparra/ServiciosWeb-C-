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
    public class ProductoRepositorio : BaseRepositorioSQL<producto>
    {
        public bool InsertarProducto(producto producto)
        {
            try
            {
                Insertar(producto);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareProducto(producto producto)
        {
            try
            {
                Actualizar(producto);
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

        public bool EliminarProducto(producto producto)
        {
            try
            {
                Eliminar(producto);
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

        public List<producto> ObtenerProductos()
        {
            try
            {
                return ObtenerTodos().Cast<producto>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<producto> FiltrarProductos(int idProducto, string nombre, string foto, int tipo, int cantidadMinima,int medida,decimal precioUnidad,
            string observaciones, string estado)
        {
            List<producto> lista = null;
            try
            {
                Expression<Func<producto, bool>> expresion = c => true;
                if (idProducto != 0)
                {
                    expresion = expresion.And(m => m.id_producto == idProducto);
                }
                if (!string.IsNullOrEmpty(nombre))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombre));
                }
                if (!string.IsNullOrEmpty(foto))
                {
                    expresion = expresion.And(m => m.foto.Contains(foto));
                }
                if (tipo != 0)
                {
                    expresion = expresion.And(m => m.tipo == tipo);
                }
                if (cantidadMinima != 0)
                {
                    expresion = expresion.And(m => m.cantidad_minima == cantidadMinima);
                }
                if (medida != 0)
                {
                    expresion = expresion.And(m => m.medida == medida);
                }
                if (precioUnidad != 0)
                {
                    expresion = expresion.And(m => m.precio_unidad == precioUnidad);
                }
                if (!string.IsNullOrEmpty(observaciones))
                {
                    expresion = expresion.And(m => m.observaciones.Contains(observaciones));
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }
                lista = Filtrar(expresion).Cast<producto>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
