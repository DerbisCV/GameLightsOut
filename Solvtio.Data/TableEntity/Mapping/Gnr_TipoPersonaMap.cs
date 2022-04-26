using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoPersonaMap : IEntityTypeConfiguration<Gnr_TipoPersona>
    {
        public Gnr_TipoPersonaMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoPersona> builder) {
           builder.HasKey(t => t.IdTipoPersona);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoPersona");
           builder.Property(t => t.IdTipoPersona).HasColumnName("IdTipoPersona");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
