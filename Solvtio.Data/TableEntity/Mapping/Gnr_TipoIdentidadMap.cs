using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoIdentidadMap : EntityTypeConfiguration<Gnr_TipoIdentidad>
    {
        public Gnr_TipoIdentidadMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoIdentidad);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Gnr_TipoIdentidad");
            Property(t => t.IdTipoIdentidad).HasColumnName("IdTipoIdentidad");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
