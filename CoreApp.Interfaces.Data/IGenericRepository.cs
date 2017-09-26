using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreApp.Interfaces.Data
{
    public interface IGenericRepository<T> where T : class
    {
        T FindById(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> Filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy = null, string IncludeProperties = "");
        void Remove(int id);
        void Create(T entity);
    }
}