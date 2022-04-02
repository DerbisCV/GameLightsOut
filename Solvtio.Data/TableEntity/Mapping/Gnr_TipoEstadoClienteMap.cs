using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoEstadoClienteMap : EntityTypeConfiguration<Gnr_TipoEstadoCliente>
    {
        public Gnr_TipoEstadoClienteMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoEstadoCliente);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Gnr_TipoEstadoCliente");
            Property(t => t.IdTipoEstadoCliente).HasColumnName("IdTipoEstadoCliente");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
