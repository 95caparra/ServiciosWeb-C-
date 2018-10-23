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
    public class ClienteRepositorio : BaseRepositorioSQL<cliente>
    {
        public bool InsertarCliente(cliente cliente)
        {
            try
            {
                Insertar(cliente);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un cliente." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarCliente(cliente cliente)
        {
            try
            {
                Actualizar(cliente);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar un cliente." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarCliente(cliente cliente)
        {
            try
            {
                Eliminar(cliente);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un cliente." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<cliente> ObtenerClientes()
        {
            try
            {
                return ObtenerTodos().Cast<cliente>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar un cliente." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<cliente> FiltrarClientes(int idCliente, string numeroIdentificacion, int tipoDocumento ,string nombre,string apellido ,string telefono , string celular , string direccion , int ciudad,string correo , string estado)
        {
            List<cliente> lista = null;
            try
            {
                Expression<Func<cliente, bool>> expresion = c => true;
                if (idCliente != 0)
                {
                    expresion = expresion.And(m => m.id_cliente == idCliente);
                }
                if (!string.IsNullOrEmpty(numeroIdentificacion))
                {
                    expresion = expresion.And(m => m.n_identificacion.Contains(numeroIdentificacion));
                }
                if (tipoDocumento != 0)
                {
                    expresion = expresion.And(m => m.tipo_documento == tipoDocumento);
                }
                if (!string.IsNullOrEmpty(nombre))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombre));
                }
                if (!string.IsNullOrEmpty(apellido))
                {
                    expresion = expresion.And(m => m.apellido.Contains(apellido));
                }
                if (!string.IsNullOrEmpty(telefono))
                {
                    expresion = expresion.And(m => m.telefono.Contains(telefono));
                }
                if (!string.IsNullOrEmpty(celular))
                {
                    expresion = expresion.And(m => m.celular.Contains(celular));
                }
                if (!string.IsNullOrEmpty(direccion))
                {
                    expresion = expresion.And(m => m.direccion.Contains(direccion));
                }
                if(ciudad != 0)
                {
                    expresion = expresion.And(m => m.ciudad == ciudad);
                }
                if (!string.IsNullOrEmpty(correo))
                {
                    expresion = expresion.And(m => m.correo.Contains(correo));
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }
                lista = Filtrar(expresion).Cast<cliente>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error filtrando clientes" + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
