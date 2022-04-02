using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TipoLugarEjecucionMap : EntityTypeConfiguration<Hip_TipoLugarEjecucion>
    {
        public Hip_TipoLugarEjecucionMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoLugarEjecucion);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Hip_TipoLugarEjecucion");
            Property(t => t.IdTipoLugarEjecucion).HasColumnName("IdTipoLugarEjecucion");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
