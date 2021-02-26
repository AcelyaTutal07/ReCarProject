using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntitiyFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
      where TEntity : class, IEntity, new()
      where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())

            {
                var addedEntity = context.Entry(entity);// git veri kanağından bir tane nesneyi ekl.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }


        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())

            {
                var deletedEntity = context.Entry(entity);// git veri kanağından bir tane nesneyi ekl.
                deletedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter) { using (TContext context = new TContext()) { return context.Set<TEntity>().SingleOrDefault(filter); } }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }  
    }
}



