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
    public class UsuarioRepositorio : BaseRepositorioSQL<usuario>
    {
        public bool InsertarUsuario(usuario usuario)
        {
            try
            {
                Insertar(usuario);
                GuardarCambios();
                return true;
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al insertar un Estado de Evento." + ex.Message + " en " + ex.StackTrace);
                return false;
            }


        }

        public bool ActualizareUsuario(usuario usuario)
        {
            try
            {
                Actualizar(usuario);
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

        public bool EliminarUsuario(usuario usuario)
        {
            try
            {
                Eliminar(usuario);
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

        public List<usuario> ObtenerUsuarios()
        {
            try
            {
                return ObtenerTodos().Cast<usuario>().Select(x => x).ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error al eliminar una categoria." + ex.Message + " en " + ex.StackTrace);
                return null;
            }
        }

        public List<usuario> FiltrarUsuarios(int idUsuario, long idEmpleado, string nombreUsuario,string estado)
        {
            List<usuario> lista = null;
            try
            {
                Expression<Func<usuario, bool>> expresion = c => true;
                if (idUsuario != 0)
                {
                    expresion = expresion.And(m => m.id_usuario == idUsuario);
                }
                if (idEmpleado != 0)
                {
                    expresion = expresion.And(m => m.id_usuario == idUsuario);
                }
                if (!string.IsNullOrEmpty(nombreUsuario))
                {
                    expresion = expresion.And(m => m.usuario1.Contains(nombreUsuario));
                }
                if (!string.IsNullOrEmpty(estado))
                {
                    expresion = expresion.And(m => m.usuario1.Contains(estado));
                }

                lista = Filtrar(expresion).Cast<usuario>().ToList();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
            }
            return lista;
        }
    }
}
