using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Azzeton.Core;
using Azzeton.Shared;
using Azzeton.Core.Entity;

namespace Azzeton.Core
{
    /// <summary>
    /// Manages all entities
    /// </summary>
    public class Manager : Entity.EntityManager
    {
        /// <summary>
        /// Add/Save entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>ActionResult</returns>
        public override ActionResult Add<T>(ref T entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Edits/Updates entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Action Result</returns>
        public override ActionResult Edit<T>(ref T entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete/Removes entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Action Result</returns>
        public override ActionResult Delete<T>(ref T entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets/Retrieves 1 entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="id">Id of entity</param>
        /// <returns>Returns an entity of specified type</returns>
        public override T GetSingle<T>(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <returns>Returns an entity of specified type</returns>
        public override T GetSingle<T>(Collection<SearchParameter> criteria)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Collection of search parameters</param>
        /// <returns>Returns an entity of specified type</returns>
        public override T GetSingle<T>(params SearchParameter[] criteria)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <returns>Collection of entities</returns>
        public override Collection<T> GetMultiple<T>()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Collection of search parameters</param>
        /// <returns>Collection of entities</returns>
        public override Collection<T> GetMultiple<T>(Collection<SearchParameter> criteria)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Comma seperated list of parameters</param>
        /// <returns>Collection of entities</returns>
        public override Collection<T> GetMultiple<T>(params SearchParameter[] criteria)
        {
            throw new NotImplementedException();
        }
    }
}
