using CoreApp.Data.Entities.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CoreApp.Data.Entities
{
    public class AplicationContext : DbContext
    {
        public AplicationContext() : base("AppConnection")
        {
            /// Desable LazyLoading
            Configuration.LazyLoadingEnabled = false;            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new RestaurantConfig());
            modelBuilder.Configurations.Add(new PositionConfig());
            /// Add Config outhers Entities

            base.OnModelCreating(modelBuilder);
        }
    }
}