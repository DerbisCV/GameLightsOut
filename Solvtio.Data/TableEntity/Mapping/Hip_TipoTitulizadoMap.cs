using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TipoTitulizadoMap : IEntityTypeConfiguration<Hip_TipoTitulizado>
    {
        public Hip_TipoTitulizadoMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TipoTitulizado> builder) {
           builder.HasKey(t => t.IdTipoTitulizado);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
           builder.ToTable("Hip_TipoTitulizado");
           builder.Property(t => t.IdTipoTitulizado).HasColumnName("IdTipoTitulizado");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
