using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TipoSubastaMap : EntityTypeConfiguration<Hip_TipoSubasta>
    {
        public Hip_TipoSubastaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoSubasta);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Hip_TipoSubasta");
            Property(t => t.IdTipoSubasta).HasColumnName("IdTipoSubasta");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
