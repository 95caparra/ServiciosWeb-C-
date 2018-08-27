//-----------------------------------------------------------------------
// <copyright file="Service1.svc.cs" company="Samtel">
//     Fecha 24/08/2018
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace SpartaServices
{
    using SpartaDominio;
    using SpartaRepositorio.Categoria;
    using System;
    using System.Collections.Generic;

    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    /// <summary>
    /// Defines the <see cref="Service1" />
    /// </summary>
    public class Service1 : IService1
    {
        /// <summary>
        /// The ActualizarCategoria
        /// </summary>
        /// <param name="categoria">The categoria<see cref="Categoria"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string ActualizarCategoria(Categoria categoria)
        {
            CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
            return categoriaRepositorio.ActualizarCategoria(categoria);
        }

        /// <summary>
        /// The CrearCategoria
        /// </summary>
        /// <param name="categoria">The categoria<see cref="Categoria"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string CrearCategoria(Categoria categoria)
        {
            CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
            return categoriaRepositorio.CrearCategoria(categoria);
        }

        /// <summary>
        /// The GetData
        /// </summary>
        /// <param name="value">The value<see cref="int"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetData(int value)
        {
            CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
            SpartaDominio.Categoria categoria = new SpartaDominio.Categoria();
            categoria.DescripcionCategoria = "Esta es un prueba";
            categoria.VentaMax = 150000;
            categoria.VentaMin = 150000;
            categoria.IdCategoria = 1;

            categoriaRepositorio.CrearCategoria(categoria);
            return "S";
        }

        /// <summary>
        /// The GetDataUsingDataContract
        /// </summary>
        /// <param name="composite">The composite<see cref="CompositeType"/></param>
        /// <returns>The <see cref="CompositeType"/></returns>
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        /// <summary>
        /// The TraerCategorias
        /// </summary>
        /// <returns>The <see cref="List{Categoria}"/></returns>
        public List<Categoria> TraerCategorias()
        {
            CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
            return categoriaRepositorio.TraerCategorias();
        }
    }
}
