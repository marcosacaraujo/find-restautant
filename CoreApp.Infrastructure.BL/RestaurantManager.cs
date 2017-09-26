using System;
using System.Collections.Generic;
using CoreApp.Data.Entities;
using CoreApp.Interfaces.BL;
using CoreApp.Interfaces.Data;
using System.Linq;

namespace CoreApp.Infrastructure.BL
{
    public class RestaurantManager : IRestaurantManager
    {
        private IRestaurantRepository _repository;

        public RestaurantManager(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public ICollection<Restaurant> Find(string text)
        {
            return _repository.Find(r => r.Name.Contains(text)).ToList();
        }

        public ICollection<Restaurant> GetAll()
        {
            return _repository.Find(IncludeProperties: "Position").ToList();
        }
    }
}