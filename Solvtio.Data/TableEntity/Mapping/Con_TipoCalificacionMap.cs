using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_TipoCalificacionMap : EntityTypeConfiguration<Con_TipoCalificacion>
    {
        public Con_TipoCalificacionMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoCalificacion);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Con_TipoCalificacion");
            Property(t => t.IdTipoCalificacion).HasColumnName("IdTipoCalificacion");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
