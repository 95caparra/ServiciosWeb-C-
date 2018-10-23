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
    public class ProveedorRepositorio : BaseRepositorioSQL<proveedor>
    {
        public bool InsertarProveedor(proveedor proveedor)
        {
            try
            {
                Insertar(proveedor);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareProveedor(proveedor proveedor)
        {
            try
            {
                Actualizar(proveedor);
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

        public bool EliminarProveedor(proveedor proveedor)
        {
            try
            {
                Eliminar(proveedor);
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

        public List<proveedor> ObtenerProveedors()
        {
            try
            {
                return ObtenerTodos().Cast<proveedor>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<proveedor> FiltrarProveedores(int idProveedor, string razonSocial,string direccion,string telefono,string correo,string estado)
        {
            List<proveedor> lista = null;
            try
            {
                Expression<Func<proveedor, bool>> expresion = c => true;
                if (idProveedor != 0)
                {
                    expresion = expresion.And(m => m.id_proveedor == idProveedor);
                }
                if (!string.IsNullOrEmpty(razonSocial))
                {
                    expresion = expresion.And(m => m.razon_social.Contains(razonSocial));
                }
                if (!string.IsNullOrEmpty(direccion))
                {
                    expresion = expresion.And(m => m.direccion.Contains(direccion));
                }
                if (!string.IsNullOrEmpty(telefono))
                {
                    expresion = expresion.And(m => m.telefono.Contains(telefono));
                }
                if (!string.IsNullOrEmpty(correo))
                {
                    expresion = expresion.And(m => m.correo.Contains(correo));
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }
                lista = Filtrar(expresion).Cast<proveedor>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
