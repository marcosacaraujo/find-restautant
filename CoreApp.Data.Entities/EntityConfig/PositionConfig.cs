using System.Data.Entity.ModelConfiguration;

namespace CoreApp.Data.Entities.EntityConfig
{
    public class PositionConfig : EntityTypeConfiguration<Position>
    {
        public PositionConfig()
        {
            HasKey(t => t.Id).Property(t => t.Id).HasColumnName("id").IsRequired();
            HasOptional(p => p.Restaurant).WithOptionalDependent(p => p.Position).WillCascadeOnDelete(false);

            ToTable("Positions");
        }
    }
}