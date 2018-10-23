using Dominio;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio
{
    public class CiudadRepositorio : BaseRepositorioSQL<ciudad>
    {
        public bool InsertarCiudad(ciudad ciudad)
        {
            try
            {
                Insertar(ciudad);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar una ciudad." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizarCiudad(ciudad ciudad)
        {
            try
            {
                Actualizar(ciudad);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al actualizar una ciudad." +ex.Message +" en "+ ex.StackTrace);
                return false;

                throw;
            }
        }

        public bool EliminarCiudad(ciudad ciudad)
        {
            try
            {
                Eliminar(ciudad);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una ciudad." + ex.Message + " en " + ex.StackTrace);
                return false;

                throw;
            }
        }

        public List<ciudad> ObtenerCiudades()
        {
            try
            {
                return ObtenerTodos().Cast<ciudad>().Select(x => x ).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una ciudad." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<ciudad> FiltrarCiudades(int? idCiudad, string nombreCiudad = "")
        {
            List<ciudad> lista = null;
            try
            {
                Expression<Func<ciudad, bool>> expresion = c => true;
                if (idCiudad != 0)
                {
                    expresion = expresion.And(m => m.Id_ciudad == idCiudad);
                }
                if (!string.IsNullOrEmpty(nombreCiudad))
                {
                    expresion = expresion.And(m => m.Nombre.Contains(nombreCiudad));
                }
                lista = Filtrar(expresion).Cast<ciudad>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error filtrando ciudades " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
