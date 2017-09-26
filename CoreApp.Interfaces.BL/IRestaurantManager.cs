using CoreApp.Data.Entities;
using System.Collections.Generic;

namespace CoreApp.Interfaces.BL
{
    public interface IRestaurantManager
    {
        ICollection<Restaurant> GetAll();
        ICollection<Restaurant> Find(string text);
    }
}