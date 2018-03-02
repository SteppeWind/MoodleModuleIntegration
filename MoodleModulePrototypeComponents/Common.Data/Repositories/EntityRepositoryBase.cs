﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Common.Data.Infrastructure;
using Common.Domain;

namespace Common.Data.Repositories
{
    public interface IEntityRepository<TEntity> where TEntity : IEntityBase
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector);
        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
        IQueryable<TResult> GetMany<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> selector);
    }

    public class EntityRepositoryBase<TEntity, TDbFactory> : IEntityRepository<TEntity> where TEntity : class, IEntityBase where TDbFactory : IDbFactory 
    {
        protected IDbContext DataContext { get; }
        protected DbSet<TEntity> Entities { get; }

        public EntityRepositoryBase(TDbFactory dbFactory)
        {
            DataContext = dbFactory.Get();
            Entities = DataContext.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            Entities.Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Entities.AsQueryable();
        }

        public IQueryable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector)
        {
            return GetAll().Select(selector);
        }

        public IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return GetAll().Where(where);
        }

        public IQueryable<TResult> GetMany<TResult>(Expression<Func<TEntity, bool>> @where, Expression<Func<TEntity, TResult>> selector)
        {
            return GetAll().Where(where).Select(selector);
        }

        protected virtual void Update(TEntity entity)
        {
            var entityState = DataContext.GetEntityState(entity);

            if (entityState == EntityState.Detached)
            {
                entityState = EntityState.Modified;
                DataContext.AttachEntity(entity, entityState);
            }
        }
    }
}