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
    public class PaqueteRepositorio : BaseRepositorioSQL<paquete>
    {
        public bool InsertarPaquete(paquete paquete)
        {
            try
            {
                Insertar(paquete);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }



        public bool ActualizarePaquete(paquete paquete)
        {
            try
            {
                Actualizar(paquete);
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

        public bool EliminarPaquete(paquete paquete)
        {
            try
            {
                Eliminar(paquete);
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

        public List<paquete> ObtenerPaquetes()
        {
            try
            {
                return ObtenerTodos().Cast<paquete>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }
        public List<paquete> FiltrarPaquetes(int idPaquete, string nombrePaquete , int idClasificacion, string descripcion , int idLugar
            , int cantidadPersonas, decimal precio, string pdf , string foto , string estado )
        {
            List<paquete> lista = null;
            try
            {
                Expression<Func<paquete, bool>> expresion = c => true;
                if (idPaquete != 0)
                {
                    expresion = expresion.And(m => m.id_paquete == idPaquete);
                }
                if (!string.IsNullOrEmpty(nombrePaquete))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombrePaquete));
                }
                if (idClasificacion != 0)
                {
                    expresion = expresion.And(m => m.clasificacion_id_clasificacion == idClasificacion);
                }
                if (!string.IsNullOrEmpty(descripcion))
                {
                    expresion = expresion.And(m => m.descripcion.Contains(descripcion));
                }
                if (idLugar != 0)
                {
                    expresion = expresion.And(m => m.id_lugar == idLugar);
                }
                if (cantidadPersonas != 0)
                {
                    expresion = expresion.And(m => m.cantidad_personas == cantidadPersonas);
                }
                if (precio != 0)
                {
                    expresion = expresion.And(m => m.precio == precio);
                }
                if (!string.IsNullOrEmpty(pdf))
                {
                    expresion = expresion.And(m => m.pdf.Contains(pdf));
                }
                if (!string.IsNullOrEmpty(foto))
                {
                    expresion = expresion.And(m => m.foto.Contains(foto));
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.estado.Contains(estado));
                }

                lista = Filtrar(expresion).Cast<paquete>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
