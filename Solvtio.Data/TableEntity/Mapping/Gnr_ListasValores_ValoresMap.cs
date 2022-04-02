using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_ListasValores_ValoresMap : EntityTypeConfiguration<Gnr_ListasValores_Valores>
    {
        public Gnr_ListasValores_ValoresMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Etiqueta)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Gnr_ListasValores_Valores");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IDlista).HasColumnName("IDlista");
            Property(t => t.Etiqueta).HasColumnName("Etiqueta");
            Property(t => t.ValorNumerico).HasColumnName("ValorNumerico");
            Property(t => t.Orden).HasColumnName("Orden");
            Property(t => t.Baja).HasColumnName("Baja");

            // Relationships
            HasRequired(t => t.Gnr_ListasValores_Listas)
                .WithMany(t => t.Gnr_ListasValores_Valores)
                .HasForeignKey(d => d.IDlista);

        }
    }
}
