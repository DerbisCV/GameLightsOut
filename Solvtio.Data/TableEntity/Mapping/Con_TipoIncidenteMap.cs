using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_TipoIncidenteMap : EntityTypeConfiguration<Con_TipoIncidente>
    {
        public Con_TipoIncidenteMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoIncidente);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Con_TipoIncidente");
            Property(t => t.IdTipoIncidente).HasColumnName("IdTipoIncidente");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
