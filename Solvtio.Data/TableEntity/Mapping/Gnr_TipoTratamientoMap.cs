using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoTratamientoMap : EntityTypeConfiguration<Gnr_TipoTratamiento>
    {
        public Gnr_TipoTratamientoMap()
        {
            // Primary Key
            HasKey(t => t.IdTratamiento);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_TipoTratamiento");
            Property(t => t.IdTratamiento).HasColumnName("IdTratamiento");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
