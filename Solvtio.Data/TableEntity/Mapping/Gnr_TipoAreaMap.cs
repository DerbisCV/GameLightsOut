using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoAreaMap : EntityTypeConfiguration<Gnr_TipoArea>
    {
        public Gnr_TipoAreaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoArea);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Gnr_TipoArea");
            Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
            Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
