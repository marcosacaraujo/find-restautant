using System;

namespace CoreApp.Interfaces.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }
}