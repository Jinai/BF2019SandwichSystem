using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineServices.Shared.DataAccessHelpers
{
    public class GenericRepository<TEntity, TIdType> : IRepositoryToDelete<TEntity, TIdType>
        where TEntity : class, IEntity<TIdType>
    {
        private readonly DbContext dbContext;

        public GenericRepository(DbContext dBContext)
        {
            this.dbContext = dBContext;
        }

        void IRepositoryToDelete<TEntity, TIdType>.Create(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        void IRepositoryToDelete<TEntity, TIdType>.Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        //private bool Equalite(TIdType a, TIdType b)
        //{
        //    return EqualityComparer<TIdType>.Default.Equals(a,b);
        //}

        void IRepositoryToDelete<TEntity, TIdType>.Delete(TIdType id)
        {
            var entityToDelete = dbContext.Set<TEntity>().FirstOrDefault(e => e.Id.Equals(id));
            if (entityToDelete != null)
            {
                dbContext.Set<TEntity>().Remove(entityToDelete);
            }
        }

        void IRepositoryToDelete<TEntity, TIdType>.Edit(TEntity entity)
        {
            var editedEntity = dbContext.Set<TEntity>().FirstOrDefault(e => e.Id.Equals(entity.Id));
            editedEntity = entity;
        }

        IEnumerable<TEntity> IRepositoryToDelete<TEntity, TIdType>.GetAll()
        {
            return dbContext.Set<TEntity>();
        }

        IEnumerable<TEntity> IRepositoryToDelete<TEntity, TIdType>.Filter(Func<TEntity, bool> predicate)
        {
            return dbContext.Set<TEntity>().Where(predicate);
        }

        TEntity IRepositoryToDelete<TEntity, TIdType>.GetById(TIdType id)
        {
            return dbContext.Set<TEntity>().FirstOrDefault(e => e.Id.Equals(id));
        }

        int IRepositoryToDelete<TEntity, TIdType>.SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public delegate TEntity ToEntity(TEntity a);
        public delegate TEntity ToTransfertObject(TEntity a);
    }
}

