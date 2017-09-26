using CoreApp.Data.Entities;
using CoreApp.Interfaces.Data;
using System.Data.Entity;

namespace CoreApp.Data.Repositories
{
    public class PositionRepository : GenericRepository<Position>, IPositionRepository
    {
        public PositionRepository(DbContext context) : base(context)
        {
        }
    }
}