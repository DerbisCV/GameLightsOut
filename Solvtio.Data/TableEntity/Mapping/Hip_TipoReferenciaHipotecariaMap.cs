using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TipoReferenciaHipotecariaMap : IEntityTypeConfiguration<Hip_TipoReferenciaHipotecaria>
    {
        public Hip_TipoReferenciaHipotecariaMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TipoReferenciaHipotecaria> builder) {
           builder.HasKey(t => t.IdTipoIndiceReferenciaHipotecaria);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
           builder.ToTable("Hip_TipoReferenciaHipotecaria");
           builder.Property(t => t.IdTipoIndiceReferenciaHipotecaria).HasColumnName("IdTipoIndiceReferenciaHipotecaria");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
