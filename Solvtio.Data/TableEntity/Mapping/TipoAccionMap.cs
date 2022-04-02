using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class TipoAccionMap : EntityTypeConfiguration<TipoAccion>
    {
        public TipoAccionMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoAccion);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("TipoAccion");
            Property(t => t.IdTipoAccion).HasColumnName("IdTipoAccion");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
            Property(t => t.Inactivo).HasColumnName("Inactivo");
        }
    }
}
