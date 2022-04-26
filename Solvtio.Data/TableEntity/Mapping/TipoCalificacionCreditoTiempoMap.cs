using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class TipoCalificacionCreditoTiempoMap : IEntityTypeConfiguration<TipoCalificacionCreditoTiempo>
    {
        public TipoCalificacionCreditoTiempoMap()
        {
           } public void Configure(EntityTypeBuilder<TipoCalificacionCreditoTiempo> builder) {
           builder.HasKey(t => t.IdTipoCalificacionCreditoTiempo);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("TipoCalificacionCreditoTiempo");
           builder.Property(t => t.IdTipoCalificacionCreditoTiempo).HasColumnName("IdTipoCalificacionCreditoTiempo");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
