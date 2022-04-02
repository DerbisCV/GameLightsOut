using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoPersonaMap : EntityTypeConfiguration<Gnr_TipoPersona>
    {
        public Gnr_TipoPersonaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoPersona);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_TipoPersona");
            Property(t => t.IdTipoPersona).HasColumnName("IdTipoPersona");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
