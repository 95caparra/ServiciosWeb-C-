//-----------------------------------------------------------------------
// <copyright file="CategoriaRepositorio.cs" company="Samtel">
//     Fecha 27/08/2018
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace SpartaRepositorio.Categoria
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="CategoriaRepositorio" />
    /// </summary>
    public class CategoriaRepositorio : BaseRepositorioSQL<SpartaDominio.Categoria>
    {
        /// <summary>
        /// The CrearCategoria
        /// </summary>
        /// <param name="entidad">The entidad<see cref="SpartaDominio.Categoria"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string CrearCategoria(SpartaDominio.Categoria entidad)
        {
            try
            {
                BaseRepositorioSQL<SpartaDominio.Categoria> repo = new BaseRepositorioSQL<SpartaDominio.Categoria>();
                repo.Insertar(entidad);
                repo.GuardarCambios();
                Utilidades.UtilidadesAuditoria.GenerarLog(string.Format("Categoria {0} Insertada Exitosamente", entidad.DescripcionCategoria));
                return string.Format("Categoria {0} Insertada Exitosamente", entidad.DescripcionCategoria);

            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Se presento un error " + ex.Message + " - " + ex.StackTrace);
                return "Categoria no Insertada Se presento un error al crearla";
            }
        }

        /// <summary>
        /// The TraerCategorias
        /// </summary>
        /// <returns>The <see cref="List{SpartaDominio.Categoria}"/></returns>
        public List<SpartaDominio.Categoria> TraerCategorias()
        {
            BaseRepositorioSQL<SpartaDominio.Categoria> repo = new BaseRepositorioSQL<SpartaDominio.Categoria>();
            return repo.ObtenerTodos().Cast<SpartaDominio.Categoria>().ToList();
        }

        /// <summary>
        /// The ActualizarCategoria
        /// </summary>
        /// <param name="entidad">The entidad<see cref="SpartaDominio.Categoria"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string ActualizarCategoria(SpartaDominio.Categoria entidad)
        {
            try
            {
                BaseRepositorioSQL<SpartaDominio.Categoria> repo = new BaseRepositorioSQL<SpartaDominio.Categoria>();
                repo.Actualizar(entidad);
                repo.GuardarCambios();

                return string.Format("Categoria {0} Actualizada Exitosamente", entidad.DescripcionCategoria);

            }
            catch (Exception)
            {
                return "Categoria no Insertada Se presento un error al crearla";
            }
        }
    }
}
