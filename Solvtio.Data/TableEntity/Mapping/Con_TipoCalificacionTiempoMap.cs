using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_TipoCalificacionTiempoMap : EntityTypeConfiguration<Con_TipoCalificacionTiempo>
    {
        public Con_TipoCalificacionTiempoMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoCalificacion);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Con_TipoCalificacionTiempo");
            Property(t => t.IdTipoCalificacion).HasColumnName("IdTipoCalificacion");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
