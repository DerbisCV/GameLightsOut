using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_JuzgadoMap : EntityTypeConfiguration<Gnr_Juzgado>
    {
        public Gnr_JuzgadoMap()
        {
            // Primary Key
            HasKey(t => t.IdJuzgado);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Gnr_Juzgado");
            Property(t => t.IdJuzgado).HasColumnName("IdJuzgado");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
