
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Con_TipoCalificacionMap : IEntityTypeConfiguration<Con_TipoCalificacion>
    {

        public void Configure(EntityTypeBuilder<Con_TipoCalificacion> builder)
        {
            builder.HasKey(t => t.IdTipoCalificacion);

            // Properties
            builder.Property(t => t.Descripcion)
                 .IsRequired()
                 .HasMaxLength(500);

            // Table & Column Mappings
            builder.ToTable("Con_TipoCalificacion");
            builder.Property(t => t.IdTipoCalificacion).HasColumnName("IdTipoCalificacion");
            builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
