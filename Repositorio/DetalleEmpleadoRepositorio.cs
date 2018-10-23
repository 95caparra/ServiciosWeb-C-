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
    public class DetalleEmpleadoRepositorio : BaseRepositorioSQL<detalle_empleado>
    {
        public bool InsertarDetalleEmpleado(detalle_empleado detalleEmpleado)
        {
            try
            {
                Insertar(detalleEmpleado);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar una detalle de evento y empleado." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarDetalleEmpleado(detalle_empleado detalleEmpleado)
        {
            try
            {
                Actualizar(detalleEmpleado);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar una detalle de evento y empleado." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarDetalleEmpleado(detalle_empleado detalleEmpleado)
        {
            try
            {
                Eliminar(detalleEmpleado);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una detalle de evento y empleado." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<detalle_empleado> ObtenerDetalleEmpleados()
        {
            try
            {
                return ObtenerTodos().Cast<detalle_empleado>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una detalle de evento y empleado." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<detalle_empleado> FiltrarDetalleEmpleados(long idEvento, long idEmpleado,double calificacion,string estado,long idDetalleEmpleado)
        {
            List<detalle_empleado> lista = null;
            try
            {
                Expression<Func<detalle_empleado, bool>> expresion = c => true;
                if (idEvento != 0)
                {
                    expresion = expresion.And(m => m.evento_id_evento == idEvento);
                }
                if (idEmpleado != 0)
                {
                    expresion = expresion.And(m => m.empleado_id_empleado == idEmpleado);
                }

                if (calificacion != 0)
                {
                    expresion = expresion.And(m => m.calificacion == calificacion);
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }
                if (idDetalleEmpleado != 0)
                {
                    expresion = expresion.And(m => m.id_detalle_empleado == idDetalleEmpleado);
                }
                lista = Filtrar(expresion).Cast<detalle_empleado>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error filtrando el detalle del evento por empleado" + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
