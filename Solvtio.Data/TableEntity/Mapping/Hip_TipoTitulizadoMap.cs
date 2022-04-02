using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TipoTitulizadoMap : EntityTypeConfiguration<Hip_TipoTitulizado>
    {
        public Hip_TipoTitulizadoMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoTitulizado);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("Hip_TipoTitulizado");
            Property(t => t.IdTipoTitulizado).HasColumnName("IdTipoTitulizado");
            Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
