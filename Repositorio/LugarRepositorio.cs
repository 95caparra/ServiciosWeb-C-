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
    public class LugarRepositorio : BaseRepositorioSQL<lugar>
    {
        public bool InsertarLugar(lugar lugar)
        {
            try
            {
                Insertar(lugar);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar una categoria." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarLugar(lugar lugar)
        {
            try
            {
                Actualizar(lugar);
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

        public bool EliminarLugar(lugar lugar)
        {
            try
            {
                Eliminar(lugar);
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

        public List<lugar> ObtenerLugares()
        {
            try
            {
                return ObtenerTodos().Cast<lugar>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<lugar> FiltrarLugares(int idLugar, string nombreLugar , string descripcion, int cantMaxPersonas
            , string direccion , string ubicacion, string contacto, string telefonoContacto, int idCiudad)
        {
            List<lugar> lista = null;
            try
            {
                Expression<Func<lugar, bool>> expresion = c => true;
                if (idLugar != 0)
                {
                    expresion = expresion.And(m => m.id_lugar == idLugar);
                }
                if (!string.IsNullOrEmpty(nombreLugar))
                {
                    expresion = expresion.And(m => m.nombre.Contains(nombreLugar));
                }
                if (!string.IsNullOrEmpty(descripcion))
                {
                    expresion = expresion.And(m => m.descripcion.Contains(descripcion));
                }
                if (cantMaxPersonas != 0)
                {
                    expresion = expresion.And(m => m.cantidad_persona_max == cantMaxPersonas);
                }
                if (!string.IsNullOrEmpty(direccion))
                {
                    expresion = expresion.And(m => m.direccion.Contains(direccion));
                }
                if (!string.IsNullOrEmpty(ubicacion))
                {
                    expresion = expresion.And(m => m.ubicacion.Contains(ubicacion));
                }
                if (!string.IsNullOrEmpty(contacto))
                {
                    expresion = expresion.And(m => m.contacto.Contains(contacto));
                }
                if (!string.IsNullOrEmpty(telefonoContacto))
                {
                    expresion = expresion.And(m => m.telefono_contacto.Contains(telefonoContacto));
                }
                lista = Filtrar(expresion).Cast<lugar>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
