using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_ListasValores_ListasMap : EntityTypeConfiguration<Gnr_ListasValores_Listas>
    {
        public Gnr_ListasValores_ListasMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Clave)
                .HasMaxLength(50);

            Property(t => t.Nombre)
                .HasMaxLength(50);

            Property(t => t.Descripción)
                .HasMaxLength(250);

            Property(t => t.Familia)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_ListasValores_Listas");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.Clave).HasColumnName("Clave");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.Descripción).HasColumnName("Descripción");
            Property(t => t.Familia).HasColumnName("Familia");
            Property(t => t.Orden).HasColumnName("Orden");
        }
    }
}
