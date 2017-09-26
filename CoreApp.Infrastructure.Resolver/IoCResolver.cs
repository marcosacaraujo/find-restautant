using CoreApp.Data.Entities;
using CoreApp.Data.Repositories;
using CoreApp.Infrastructure.BL;
using CoreApp.Interfaces.BL;
using CoreApp.Interfaces.Data;
using SimpleInjector;
using System.Data.Entity;

namespace CoreApp.Infrastructure.Resolver
{
    public class IoCResolver
    {
        public static void SetupDependencies(Container container)
        {
            RegisterRepositories(container);
            RegisterServices(container);
        }

        private static void RegisterRepositories(Container container)
        {
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<DbContext, AplicationContext>(Lifestyle.Scoped);

            // Repositories
            container.Register<IPositionRepository, PositionRepository>(Lifestyle.Scoped);
            container.Register<IRestaurantRepository, RestaurantRepository>(Lifestyle.Scoped);
        }

        private static void RegisterServices(Container container)
        {
            container.Register<IPositionManager, PositionManager>(Lifestyle.Scoped);
            container.Register<IRestaurantManager, RestaurantManager>(Lifestyle.Scoped);
        }
    }
}