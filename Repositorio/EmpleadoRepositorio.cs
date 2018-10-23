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
    public class EmpleadoRepositorio : BaseRepositorioSQL<empleado>
    {
        public bool InsertarEmpleado(empleado empleado)
        {
            try
            {
                Insertar(empleado);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar una categoria." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarEmpleado(empleado empleado)
        {
            try
            {
                Actualizar(empleado);
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

        public bool EliminarEmpleado(empleado empleado)
        {
            try
            {
                Eliminar(empleado);
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

        public List<empleado> ObtenerEmpleadoes()
        {
            try
            {
                return ObtenerTodos().Cast<empleado>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<empleado> FiltrarEmpleadoes(long idEmpleado,string numeroIdentificacion,int tipoDocumento,
            string nombreEmpleado,string apellidoEmpleado,int idRol,string correo ,string direccion ,string telefono 
            ,string barrio ,string estado )
        {
            List<empleado> lista = null;
            try
            {
                Expression<Func<empleado, bool>> expresion = c => true;
                if (idEmpleado != 0)
                {
                    expresion = expresion.And(m => m.Id_empleado == idEmpleado);
                }
                if (!string.IsNullOrEmpty(numeroIdentificacion))
                {
                    expresion = expresion.And(m => m.n_identificacion.Contains(numeroIdentificacion));
                }
                if (tipoDocumento != 0)
                {
                    expresion = expresion.And(m => m.id_tipo_documento == tipoDocumento);
                }
                if (!string.IsNullOrEmpty(nombreEmpleado))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreEmpleado));
                }
                if (!string.IsNullOrEmpty(apellidoEmpleado))
                {
                    expresion = expresion.And(m => m.apellido.Contains(apellidoEmpleado));
                }
                if (idRol != 0)
                {
                    expresion = expresion.And(m => m.empleado_id_rol == idRol);
                }
                if (!string.IsNullOrEmpty(correo))
                {
                    expresion = expresion.And(m => m.correo.Contains(correo));
                }
                if (!string.IsNullOrEmpty(direccion))
                {
                    expresion = expresion.And(m => m.direccion.Contains(direccion));
                }
                if (!string.IsNullOrEmpty(telefono))
                {
                    expresion = expresion.And(m => m.telefono.Contains(telefono));
                }
                if (!string.IsNullOrEmpty(barrio))
                {
                    expresion = expresion.And(m => m.barrio.Contains(barrio));
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }
                lista = Filtrar(expresion).Cast<empleado>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
