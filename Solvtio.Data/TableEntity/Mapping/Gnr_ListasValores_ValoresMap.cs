using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_ListasValores_ValoresMap : IEntityTypeConfiguration<Gnr_ListasValores_Valores>
    {
      
            public void Configure(EntityTypeBuilder<Gnr_ListasValores_Valores> builder) {
           builder.HasKey(t => t.ID);

            // Properties
           builder.Property(t => t.Etiqueta)
                .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Gnr_ListasValores_Valores");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.IDlista).HasColumnName("IDlista");
           builder.Property(t => t.Etiqueta).HasColumnName("Etiqueta");
           builder.Property(t => t.ValorNumerico).HasColumnName("ValorNumerico");
           builder.Property(t => t.Orden).HasColumnName("Orden");
           builder.Property(t => t.Baja).HasColumnName("Baja");

            // Relationships
            //HasRequired(t => t.Gnr_ListasValores_Listas)
                //  .WithMany(t => t.Gnr_ListasValores_Valores)
                //  .HasForeignKey(d => d.IDlista);

        }
    }
}
