using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_JuzgadoMap : IEntityTypeConfiguration<Gnr_Juzgado>
    {
     
            public void Configure(EntityTypeBuilder<Gnr_Juzgado> builder) {
           builder.HasKey(t => t.IdJuzgado);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Gnr_Juzgado");
           builder.Property(t => t.IdJuzgado).HasColumnName("IdJuzgado");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
