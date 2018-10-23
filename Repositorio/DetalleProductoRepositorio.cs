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
    public class DetalleProductoRepositorio : BaseRepositorioSQL<detalle_producto_suministro>
    {
        public bool InsertarDetallePoductoSuministro(detalle_producto_suministro detallePoductoSuministro)
        {
            try
            {
                Insertar(detallePoductoSuministro);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un detalle de suministro por producto." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarDetallePoductoSuministro(detalle_producto_suministro detallePoductoSuministro)
        {
            try
            {
                Actualizar(detallePoductoSuministro);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar un detalle de suministro por producto." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarDetallePoductoSuministro(detalle_producto_suministro detallePoductoSuministro)
        {
            try
            {
                Eliminar(detallePoductoSuministro);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un detalle de suministro por producto." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<detalle_producto_suministro> ObtenerDetallePoductoSuministros()
        {
            try
            {
                return ObtenerTodos().Cast<detalle_producto_suministro>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un detalle de suministro por producto." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<detalle_producto_suministro> FiltrarDetallePoductoSuministros(int? idProducto, int? idSuminstro, int? cantidad, int? estado, long? idProductoSuministro)
        {
            List<detalle_producto_suministro> lista = null;
            try
            {
                Expression<Func<detalle_producto_suministro, bool>> expresion = c => true;
                if (idProducto != 0)
                {
                    expresion = expresion.And(m => m.id_producto == idProducto);
                }
                if (idSuminstro != 0)
                {
                    expresion = expresion.And(m => m.id_suministro == idSuminstro);
                }
                if (cantidad != 0)
                {
                    expresion = expresion.And(m => m.cantidad == cantidad);
                }
                if (estado != 0)
                {
                    expresion = expresion.And(m => m.estado == estado);
                }
                if (idProductoSuministro != 0)
                {
                    expresion = expresion.And(m => m.id_producto_suministro == idProductoSuministro);
                }
                lista = Filtrar(expresion).Cast<detalle_producto_suministro>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error filtrando el detalle de suministro por producto " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
