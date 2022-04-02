using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TipoInmuebleMap : EntityTypeConfiguration<Hip_TipoInmueble>
    {
        public Hip_TipoInmuebleMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoInmueble);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Hip_TipoInmueble");
            Property(t => t.IdTipoInmueble).HasColumnName("IdTipoInmueble");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
