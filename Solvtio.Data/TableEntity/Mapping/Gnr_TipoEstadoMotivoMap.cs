using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoEstadoMotivoMap : EntityTypeConfiguration<Gnr_TipoEstadoMotivo>
    {
        public Gnr_TipoEstadoMotivoMap()
        {
            // Primary Key
            HasKey(t => t.IdMotivo);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_TipoEstadoMotivo");
            Property(t => t.IdMotivo).HasColumnName("IdMotivo");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
        }
    }
}
