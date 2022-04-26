using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoIdentidadMap : IEntityTypeConfiguration<Gnr_TipoIdentidad>
    {
        public Gnr_TipoIdentidadMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoIdentidad> builder) {
           builder.HasKey(t => t.IdTipoIdentidad);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoIdentidad");
           builder.Property(t => t.IdTipoIdentidad).HasColumnName("IdTipoIdentidad");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
