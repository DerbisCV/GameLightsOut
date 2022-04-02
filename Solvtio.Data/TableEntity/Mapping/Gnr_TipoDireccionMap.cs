using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoDireccionMap : EntityTypeConfiguration<Gnr_TipoDireccion>
    {
        public Gnr_TipoDireccionMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoDireccion);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_TipoDireccion");
            Property(t => t.IdTipoDireccion).HasColumnName("IdTipoDireccion");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
