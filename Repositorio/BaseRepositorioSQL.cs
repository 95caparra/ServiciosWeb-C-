//-----------------------------------------------------------------------
// <copyright file="BaseRepositorioSQL.cs" company="Samtel">
//     Fecha 24/08/2018
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Repositorio
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the <see cref="BaseRepositorioSQL{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepositorioSQL<T> : IBaseRepositorio<T> where T : class
    {
        /// <summary>
        /// Defines the contexto
        /// </summary>
        internal DbContext contexto = new Datos.ProyectoGradoEntities();

        /// <summary>
        /// Defines the obj
        /// </summary>
        internal Datos.ProyectoGradoEntities modelo = new Datos.ProyectoGradoEntities();

        /// <summary>
        /// Defines the dbSet
        /// </summary>
        protected DbSet<T> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepositorioSQL{T}"/> class.
        /// </summary>
        public BaseRepositorioSQL()
        {
            dbSet = contexto.Set<T>();
        }

        /// <summary>
        /// The Eliminar
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        public void Eliminar(T entidad)
        {
            contexto.Entry(entidad).State = EntityState.Deleted;
        }

        /// <summary>
        /// The Filtrar
        /// </summary>
        /// <param name="expresion">The expresion<see cref="Expression{Func{T, bool}}"/></param>
        /// <returns>The <see cref="IQueryable"/></returns>
        public IQueryable Filtrar(Expression<Func<T, bool>> expresion)
        {
            return dbSet.Where(expresion);
        }

        /// <summary>
        /// The GuardarCambios
        /// </summary>
        public void GuardarCambios()
        {
            contexto.SaveChanges();
        }

        /// <summary>
        /// The Insertar
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        public void Insertar(T entidad)
        {
            contexto.Entry(entidad).State = EntityState.Added;
        }

        /// <summary>
        /// The ObtenerPorId
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        public T ObtenerPorId(string id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// The ObtenerTodos
        /// </summary>
        /// <returns>The <see cref="IQueryable"/></returns>
        public IQueryable ObtenerTodos()
        {
            return dbSet;
        }

        /// <summary>
        /// The Actualizar
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        public void Actualizar(T entidad)
        {
            contexto.Entry(entidad).State = EntityState.Modified;
        }
    }
}
