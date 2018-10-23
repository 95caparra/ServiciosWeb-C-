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
    public class SuministroRepositorio : BaseRepositorioSQL<suministro>
    {
        public bool InsertarSuministro(suministro suministro)
        {
            try
            {
                Insertar(suministro);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareSuministro(suministro suministro)
        {
            try
            {
                Actualizar(suministro);
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

        public bool EliminarSuministro(suministro suministro)
        {
            try
            {
                Eliminar(suministro);
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

        public List<suministro> ObtenerSuministros()
        {
            try
            {
                return ObtenerTodos().Cast<suministro>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<suministro> FiltrarSuministros(int idSuministro, string nombreSuministro, string foto, int? cantidad, int? cantidadMinima, int? medida, decimal? precioUnidad
            ,string observaciones = "", string estado = "")
        {
            List<suministro> lista = null;
            try
            {
                Expression<Func<suministro, bool>> expresion = c => true;
                if (idSuministro != 0)
                {
                    expresion = expresion.And(m => m.id_suministro == idSuministro);
                }
                if (!string.IsNullOrEmpty(nombreSuministro))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreSuministro));
                }
                if (!string.IsNullOrEmpty(foto))
                {
                    expresion = expresion.And(m => m.foto.Contains(foto));
                }
                if (cantidad != 0)
                {
                    expresion = expresion.And(m => m.cantidad == cantidad);
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
                lista = Filtrar(expresion).Cast<suministro>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
