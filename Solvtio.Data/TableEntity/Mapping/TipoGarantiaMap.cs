using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class TipoGarantiaMap : IEntityTypeConfiguration<TipoGarantia>
    {
        public TipoGarantiaMap()
        {
           } public void Configure(EntityTypeBuilder<TipoGarantia> builder) {
           builder.HasKey(t => t.IdTipoGarantia);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("TipoGarantia");
           builder.Property(t => t.IdTipoGarantia).HasColumnName("IdTipoGarantia");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
