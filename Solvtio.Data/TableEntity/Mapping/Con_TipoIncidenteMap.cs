using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_TipoIncidenteMap : IEntityTypeConfiguration<Con_TipoIncidente>
    {

            public void Configure(EntityTypeBuilder<Con_TipoIncidente> builder) {
           builder.HasKey(t => t.IdTipoIncidente);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Con_TipoIncidente");
           builder.Property(t => t.IdTipoIncidente).HasColumnName("IdTipoIncidente");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
