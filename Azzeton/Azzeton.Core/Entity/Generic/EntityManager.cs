using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Runtime.InteropServices;
using Azzeton.Shared;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Abstract class to be implemented by manages all entities
    /// </summary>
    public abstract class EntityManager
    {
        /// <summary>
        /// Add/Save entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>ActionResult</returns>
        public abstract ActionResult Add<T>(ref T entity);
        /// <summary>
        /// Edits/Updates entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Action Result</returns>
        public abstract ActionResult Edit<T>(ref T entity);
        /// <summary>
        /// Delete/Removes entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Action Result</returns>
        public abstract ActionResult Delete<T>(ref T entity);
        /// <summary>
        /// Gets/Retrieves 1 entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="id">Id of entity</param>
        /// <returns>Entity</returns>
        public abstract T GetSingle<T>(int id);
        /// <summary>
        /// Get an entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Collection of search parameters</param>
        /// <returns>Type to return</returns>
        public abstract T GetSingle<T>(Collection<SearchParameter> criteria);
        /// <summary>
        /// Get an entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Collection of search parameters</param>
        /// <returns>Type to return</returns>
        public abstract T GetSingle<T>(params SearchParameter[] criteria);
        /// <summary>
        /// Gets a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <returns>Collection of entities</returns>
        public abstract Collection<T> GetMultiple<T>();
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Collection of search parameters</param>
        /// <returns>Collection of entities</returns>
        public abstract Collection<T> GetMultiple<T>(Collection<SearchParameter> criteria);
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Comma seperated list of parameters</param>
        /// <returns>Collection of entities</returns>
        public abstract Collection<T> GetMultiple<T>(params SearchParameter[] criteria);
    }
}
