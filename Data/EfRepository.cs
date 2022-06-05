using Core.Data;
using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    /// <summary>
    /// Represents the Entity Framework repository
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public partial class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Fields

        private readonly IDbContext _context;

        private DbSet<TEntity> _entities;

        #endregion

        #region Ctor

        public EfRepository(IDbContext context)
        {
            this._context = context;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        public virtual TEntity GetById(object id)
        {
            var entity = Entities.Find(id);
            return entity;
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual void Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                Entities.Add(entity);
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                //ensure that the detailed error text is saved in the Log
                throw exception;
            }
        }

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Insert(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            try
            {
                Entities.AddRange(entities);
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                //ensure that the detailed error text is saved in the Log
                throw exception;
            }
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                Entities.Update(entity);
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                throw exception;
            }
        }

        public virtual void UpdateWithoutCommit(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            try
            {
                Entities.Update(entity);
            }
            catch (DbUpdateException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Update(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            try
            {
                Entities.UpdateRange(entities);
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual void Delete(TEntity entity, bool forceDelete)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            //var deletableEntity = entity as IDeletable;
            //if (deletableEntity != null && !forceDelete) deletableEntity.IsDeleted = true;
            Entities.Remove(entity);

            _context.SaveChanges();
        }

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            try
            {
                Entities.RemoveRange(entities);
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                throw exception;
            }
        }

        public void DeleteWithoutCommit(TEntity entity, bool forceDelete)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                //var deletableEntity = entity as IDeletable;
                //if (deletableEntity != null && !forceDelete) deletableEntity.IsDeleted = true;
                Entities.Remove(entity);
            }
            catch (DbUpdateException exception)
            {
                throw exception;
            }
        }

        public void InsertWithoutCommit(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                Entities.Add(entity);
            }
            catch (DbUpdateException exception)
            {
                throw exception;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public IDbContextTransaction BeginTransaction() => _context.BeginTransaction();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a table
        /// </summary>
        public virtual IQueryable<TEntity> Table
        {
            get { return Entities; }
        }

        /// <summary>
        /// Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only operations
        /// </summary>
        public virtual IQueryable<TEntity> TableNoTracking => Table.AsNoTracking();

        /// <summary>
        /// Gets an entity set
        /// </summary>
        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<TEntity>();

                return _entities;
            }
        }

        #endregion
    }
}
