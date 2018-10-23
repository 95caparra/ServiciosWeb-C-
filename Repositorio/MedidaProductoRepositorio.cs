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
   public class MedidaProductoRepositorio :BaseRepositorioSQL<medida_producto>
    {
        public bool InsertarMedidaProducto(medida_producto medidaProducto)
        {
            try
            {
                Insertar(medidaProducto);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareMedidaProducto(medida_producto medidaProducto)
        {
            try
            {
                Actualizar(medidaProducto);
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

        public bool EliminarMedidaProducto(medida_producto medidaProducto)
        {
            try
            {
                Eliminar(medidaProducto);
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

        public List<medida_producto> ObtenerMedidaProductos()
        {
            try
            {
                return ObtenerTodos().Cast<medida_producto>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<medida_producto> FiltrarMedidasProductos(int idMedidaProducto, string nombreMedidaProducto)
        {
            List<medida_producto> lista = null;
            try
            {
                Expression<Func<medida_producto, bool>> expresion = c => true;
                if (idMedidaProducto != 0)
                {
                    expresion = expresion.And(m => m.id_medida == idMedidaProducto);
                }
                if (!string.IsNullOrEmpty(nombreMedidaProducto))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreMedidaProducto));
                }
                lista = Filtrar(expresion).Cast<medida_producto>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
