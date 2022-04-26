using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoDireccionMap : IEntityTypeConfiguration<Gnr_TipoDireccion>
    {
        public Gnr_TipoDireccionMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoDireccion> builder) {
           builder.HasKey(t => t.IdTipoDireccion);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoDireccion");
           builder.Property(t => t.IdTipoDireccion).HasColumnName("IdTipoDireccion");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
