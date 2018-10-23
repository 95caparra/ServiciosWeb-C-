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
    public class DetalleProveedorRepositorio :BaseRepositorioSQL<Dominio.detalle_proveedor>
    {
        public bool InsertarDetalleProveedor(detalle_proveedor detalleProveedor)
        {
            try
            {
                Insertar(detalleProveedor);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar una categoria." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarDetalleProveedor(detalle_proveedor detalleProveedor)
        {
            try
            {
                Actualizar(detalleProveedor);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar una categoria." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarDetalleProveedor(detalle_proveedor detalleProveedor)
        {
            try
            {
                Eliminar(detalleProveedor);
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

        public List<detalle_proveedor> ObtenerDetalleProveedores()
        {
            try
            {
                return ObtenerTodos().Cast<detalle_proveedor>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<detalle_proveedor> FiltrarDetalleProveedores(int? idDetalleProveedor, int? proveedorIdProvedor,int? productoIdSuministro,string estado = "")
        {
            List<detalle_proveedor> lista = null;
            try
            {
                Expression<Func<detalle_proveedor, bool>> expresion = c => true;
                if (idDetalleProveedor != 0)
                {
                    expresion = expresion.And(m => m.Id == idDetalleProveedor);
                }
                if (proveedorIdProvedor != 0)
                {
                    expresion = expresion.And(m => m.proveedor_id_proveedor == proveedorIdProvedor);
                }
                if (productoIdSuministro != 0)
                {
                    expresion = expresion.And(m => m.producto_id_suministro == productoIdSuministro);
                }
                if (string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }
                lista = Filtrar(expresion).Cast<detalle_proveedor>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
