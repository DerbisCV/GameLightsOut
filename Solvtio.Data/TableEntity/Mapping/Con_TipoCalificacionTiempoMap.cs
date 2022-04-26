using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_TipoCalificacionTiempoMap : IEntityTypeConfiguration<Con_TipoCalificacionTiempo>
    {

            public void Configure(EntityTypeBuilder<Con_TipoCalificacionTiempo> builder) {
           builder.HasKey(t => t.IdTipoCalificacion);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Con_TipoCalificacionTiempo");
           builder.Property(t => t.IdTipoCalificacion).HasColumnName("IdTipoCalificacion");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
