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
    public class PedidoRepositorio :BaseRepositorioSQL<pedido>
    {
        public bool InsertarPedido(pedido pedido)
        {
            try
            {
                Insertar(pedido);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarePedido(pedido pedido)
        {
            try
            {
                Actualizar(pedido);
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

        public bool EliminarPedido(pedido pedido)
        {
            try
            {
                Eliminar(pedido);
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

        public List<pedido> ObtenerPedidos()
        {
            try
            {
                return ObtenerTodos().Cast<pedido>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<pedido> FiltrarPedidos(int idPedido, int idProducto, int idProveedor, DateTime? fechaPedido, string cantidad, int idMedidaProducto
            ,string observaciones, string fechaSugerida, string estado)
        {
            List<pedido> lista = null;
            try
            {
                Expression<Func<pedido, bool>> expresion = c => true;
                if (idPedido != 0)
                {
                    expresion = expresion.And(m => m.id_pedido == idPedido);
                }
                if (idProducto != 0)
                {
                    expresion = expresion.And(m => m.producto_id_producto == idProducto);
                }
                if (idProveedor != 0)
                {
                    expresion = expresion.And(m => m.proveedor_id_proveedor== idProveedor);
                }
                if (string.IsNullOrEmpty(fechaPedido.ToString()))
                {
                    expresion = expresion.And(m => m.fecha_pedido == fechaPedido);
                }
                if (string.IsNullOrEmpty(cantidad))
                {
                    expresion = expresion.And(m => m.cantidad.Contains(cantidad));
                }
                if (idMedidaProducto != 0)
                {
                    expresion = expresion.And(m => m.id_medida_producto== idMedidaProducto);
                }
                if (string.IsNullOrEmpty(observaciones))
                {
                    expresion = expresion.And(m => m.observaciones.Contains(observaciones));
                }
                if (string.IsNullOrEmpty(fechaSugerida))
                {
                    expresion = expresion.And(m => m.fecha_sugerida.Contains(fechaSugerida));
                }
                if (string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }
                lista = Filtrar(expresion).Cast<pedido>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
