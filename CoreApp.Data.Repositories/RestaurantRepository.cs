using CoreApp.Data.Entities;
using CoreApp.Interfaces.Data;
using System.Data.Entity;

namespace CoreApp.Data.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(DbContext context) : base(context)
        {
        }
    }
}