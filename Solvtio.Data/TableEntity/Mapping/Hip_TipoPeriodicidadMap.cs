using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TipoPeriodicidadMap : EntityTypeConfiguration<Hip_TipoPeriodicidad>
    {
        public Hip_TipoPeriodicidadMap()
        {
            // Primary Key
            HasKey(t => t.IdPeriodicidad);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Hip_TipoPeriodicidad");
            Property(t => t.IdPeriodicidad).HasColumnName("IdPeriodicidad");
            Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
