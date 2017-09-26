using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using CoreApp.Interfaces.Data;

namespace CoreApp.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbSet<T> _dbSet;
        private DbContext _context;

        protected GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            T entity = FindById(id);
            _dbSet.Remove(entity);
        }
    }
}