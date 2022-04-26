using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class TipoClasificacionCreditoMap : IEntityTypeConfiguration<TipoClasificacionCredito>
    {
        public TipoClasificacionCreditoMap()
        {
           } public void Configure(EntityTypeBuilder<TipoClasificacionCredito> builder) {
           builder.HasKey(t => t.IdTipoCalificacionCredito);

            // Properties
           builder.Property(t => t.Descripcion)
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("TipoClasificacionCredito");
           builder.Property(t => t.IdTipoCalificacionCredito).HasColumnName("IdTipoCalificacionCredito");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
