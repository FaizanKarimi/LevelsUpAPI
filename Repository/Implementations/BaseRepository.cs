using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DapperExtensions;
using Infrastructure.DatabaseModels;
using Infrastructure.ExtensionMethods.Framework;
using Microsoft.AspNetCore.Http;
using Repository.Interfaces;
using Repository.Provider;

namespace Repository.Implementations
{
    /// <summary>
    /// BaseRepository class
    /// </summary>
    /// <typeparam name="T">the entity type</typeparam>
    /// <seealso cref="IBaseRepository{T}" />
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Private Members
        /// <summary>
        /// The HTTP context accessor
        /// </summary>
        private readonly IHttpContextAccessor _httpContextAccessor; 
        #endregion

        #region Public Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public BaseRepository(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        } 
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the unit of work.
        /// </summary>
        /// <value>
        /// The unit of work.
        /// </value>
        public IUnitOfWork UnitOfWork { get; set; } 
        #endregion

        #region Public Methods
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool Delete(T entity)
        {
            return UnitOfWork.Connection.Delete<T>(entity, UnitOfWork.Transaction);
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// the entity
        /// </returns>
        public T Get(int id)
        {
            return UnitOfWork.Connection.Get<T>(id);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>
        /// the list of entity
        /// </returns>
        public List<T> GetAll()
        {
            return UnitOfWork.Connection.GetList<T>().ToList();
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// the entity
        /// </returns>
        public T Insert(T entity)
        {
            this._AddAuditInformation(entity);
            UnitOfWork.Connection.Insert<T>(entity, UnitOfWork.Transaction);
            return entity;
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool Update(T entity)
        {
            this._UpdateAuditInformation(entity);
            return UnitOfWork.Connection.Update<T>(entity, UnitOfWork.Transaction);
        }

        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool Update(List<T> entities)
        {
            foreach (T entity in entities)
            {
                this._UpdateAuditInformation(entity);
            }

            return UnitOfWork.Connection.Update<List<T>>(entities, UnitOfWork.Transaction);
        } 
        #endregion

        #region Private Methods
        /// <summary>
        /// Adds the audit information.
        /// </summary>
        /// <param name="entity">The entity.</param>
        private void _AddAuditInformation(T entity)
        {
            PropertyInfo CreatedByIdProperty = entity.GetType().GetProperty(nameof(BaseDatabaseModel.CreatedById));
            CreatedByIdProperty.SetValue(entity, this._httpContextAccessor.GetCurrentUserId());

            PropertyInfo CreatedOnProperty = entity.GetType().GetProperty(nameof(BaseDatabaseModel.CreatedOn));
            CreatedOnProperty.SetValue(entity, DateTime.Now);
        }

        /// <summary>
        /// Updates the audit information.
        /// </summary>
        /// <param name="entity">The entity.</param>
        private void _UpdateAuditInformation(T entity)
        {
            PropertyInfo UpdatedByIdProperty = entity.GetType().GetProperty(nameof(BaseDatabaseModel.UpdatedById));
            UpdatedByIdProperty.SetValue(entity, this._httpContextAccessor.GetCurrentUserId());

            PropertyInfo UpdatedOnProperty = entity.GetType().GetProperty(nameof(BaseDatabaseModel.UpdatedOn));
            UpdatedOnProperty.SetValue(entity, DateTime.Now);
        } 
        #endregion
    }
}