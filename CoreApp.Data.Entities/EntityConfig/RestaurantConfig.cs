using System.Data.Entity.ModelConfiguration;

namespace CoreApp.Data.Entities.EntityConfig
{
    public class RestaurantConfig : EntityTypeConfiguration<Restaurant>
    {
        public RestaurantConfig()
        {
            HasKey(t => t.Id).Property(t => t.Id).HasColumnName("id").IsRequired();
            Property(t => t.Name).HasColumnName("name").IsRequired().HasMaxLength(100);
                   
            ToTable("Restaurants");
        }
    }
}