using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class TipoClasificacionCreditoMap : EntityTypeConfiguration<TipoClasificacionCredito>
    {
        public TipoClasificacionCreditoMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoCalificacionCredito);

            // Properties
            Property(t => t.Descripcion)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("TipoClasificacionCredito");
            Property(t => t.IdTipoCalificacionCredito).HasColumnName("IdTipoCalificacionCredito");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
