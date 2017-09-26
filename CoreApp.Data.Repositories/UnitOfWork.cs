using CoreApp.Interfaces.Data;
using System.Data.Entity;

namespace CoreApp.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public UnitOfWork(DbContext context)
        {
            this._context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}