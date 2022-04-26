using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoAreaMap : IEntityTypeConfiguration<Gnr_TipoArea>
    {
        public Gnr_TipoAreaMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoArea> builder) {
           builder.HasKey(t => t.IdTipoArea);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoArea");
           builder.Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
