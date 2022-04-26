using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoEstadoClienteMap : IEntityTypeConfiguration<Gnr_TipoEstadoCliente>
    {
        public Gnr_TipoEstadoClienteMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoEstadoCliente> builder) {
           builder.HasKey(t => t.IdTipoEstadoCliente);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoEstadoCliente");
           builder.Property(t => t.IdTipoEstadoCliente).HasColumnName("IdTipoEstadoCliente");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
