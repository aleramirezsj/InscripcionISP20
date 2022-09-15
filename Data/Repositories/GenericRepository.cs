using Data.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Data.Models;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal InscripciondbContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(InscripciondbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool ignoreQueryFilters = false)
        {
            IQueryable<TEntity> query = dbSet;// context.Set<TEntity>(); //

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (include != null)
            {
                query = include(query);
            }

            if (ignoreQueryFilters)
            {
                query = query.IgnoreQueryFilters();
            }

            if (orderBy != null)
            {
                return await orderBy(query).AsNoTracking().ToListAsync();
            }
            else
            {
                return await query.AsNoTracking().ToListAsync();
            }
        }

        /*public virtual async Task<IEnumerable<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool ignoreQueryFilters = false)
        {
            //IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                if (include != null)
                {
                    if (ignoreQueryFilters)
                    {
                        if (orderBy != null)
                            return await orderBy(include(context.Set<TEntity>().Where(filter)
                                   .IgnoreQueryFilters()
                                   .AsNoTracking())).ToListAsync();
                        else
                            return await include(context.Set<TEntity>().Where(filter)
                                   .IgnoreQueryFilters()
                                   .AsNoTracking()).ToListAsync();
                    }
                    else
                    {
                        if (orderBy != null)
                            return await orderBy(include(context.Set<TEntity>().Where(filter)
                                         .AsNoTracking())).ToListAsync();
                        else
                            return await include(context.Set<TEntity>().Where(filter)
                                         .AsNoTracking()).ToListAsync();
                    }
                }
                else
                {
                    if (ignoreQueryFilters)
                    {
                        if (orderBy != null)
                            return await orderBy(context.Set<TEntity>().Where(filter)
                                         .IgnoreQueryFilters()
                                         .AsNoTracking()).ToListAsync();
                        else
                            return await context.Set<TEntity>().Where(filter)
                                         .IgnoreQueryFilters()
                                         .AsNoTracking().ToListAsync();
                    }
                    else
                    {
                        if (orderBy != null)
                            return await orderBy(context.Set<TEntity>().Where(filter)
                                   .AsNoTracking()).ToListAsync();
                        else
                            return await context.Set<TEntity>().Where(filter)
                                   .AsNoTracking().ToListAsync();
                    }
                }
            }
            else
            {
                if (ignoreQueryFilters)
                {
                    if (orderBy != null)
                        return await orderBy(context.Set<TEntity>()
                                     .IgnoreQueryFilters()
                                     .AsNoTracking()).ToListAsync();
                    else
                        return await context.Set<TEntity>()
                                     .IgnoreQueryFilters()
                                     .AsNoTracking().ToListAsync();
                }
                else
                {
                    if (orderBy != null)
                        return await orderBy(context.Set<TEntity>()
                                     .AsNoTracking()).ToListAsync();
                    else
                        return await context.Set<TEntity>()
                                     .AsNoTracking().ToListAsync();
                }
            }
        }*/

        public virtual TEntity GetByID(object id)
        {
            var entidad = dbSet.Find(id);
            context.Entry(entidad).State = EntityState.Detached;
            return entidad;
        }

        public virtual void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {

            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            //context.ChangeTracker.Clear();
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
