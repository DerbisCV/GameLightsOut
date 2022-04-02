using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class TipoCalificacionCreditoTiempoMap : EntityTypeConfiguration<TipoCalificacionCreditoTiempo>
    {
        public TipoCalificacionCreditoTiempoMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoCalificacionCreditoTiempo);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("TipoCalificacionCreditoTiempo");
            Property(t => t.IdTipoCalificacionCreditoTiempo).HasColumnName("IdTipoCalificacionCreditoTiempo");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
