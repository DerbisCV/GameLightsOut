using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class TipoAccionMap : IEntityTypeConfiguration<TipoAccion>
    {
        public TipoAccionMap()
        {
           } public void Configure(EntityTypeBuilder<TipoAccion> builder) {
           builder.HasKey(t => t.IdTipoAccion);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("TipoAccion");
           builder.Property(t => t.IdTipoAccion).HasColumnName("IdTipoAccion");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
           builder.Property(t => t.Inactivo).HasColumnName("Inactivo");
        }
    }
}
