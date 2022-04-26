using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_ListasValores_ListasMap : IEntityTypeConfiguration<Gnr_ListasValores_Listas>
    {
       
            public void Configure(EntityTypeBuilder<Gnr_ListasValores_Listas> builder) {
           builder.HasKey(t => t.ID);

            // Properties
           builder.Property(t => t.Clave)
                .HasMaxLength(50);

           builder.Property(t => t.Nombre)
                .HasMaxLength(50);

           builder.Property(t => t.Descripción)
                .HasMaxLength(250);

           builder.Property(t => t.Familia)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_ListasValores_Listas");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.Clave).HasColumnName("Clave");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.Descripción).HasColumnName("Descripción");
           builder.Property(t => t.Familia).HasColumnName("Familia");
           builder.Property(t => t.Orden).HasColumnName("Orden");
        }
    }
}
