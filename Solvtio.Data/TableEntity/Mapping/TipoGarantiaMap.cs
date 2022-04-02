using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class TipoGarantiaMap : EntityTypeConfiguration<TipoGarantia>
    {
        public TipoGarantiaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoGarantia);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("TipoGarantia");
            Property(t => t.IdTipoGarantia).HasColumnName("IdTipoGarantia");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
