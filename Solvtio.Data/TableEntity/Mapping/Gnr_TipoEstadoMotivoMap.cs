using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoEstadoMotivoMap : IEntityTypeConfiguration<Gnr_TipoEstadoMotivo>
    {
        public Gnr_TipoEstadoMotivoMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoEstadoMotivo> builder) {
           builder.HasKey(t => t.IdMotivo);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoEstadoMotivo");
           builder.Property(t => t.IdMotivo).HasColumnName("IdMotivo");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
        }
    }
}
