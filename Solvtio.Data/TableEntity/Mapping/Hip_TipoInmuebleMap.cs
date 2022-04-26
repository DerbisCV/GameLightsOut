using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TipoInmuebleMap : IEntityTypeConfiguration<Hip_TipoInmueble>
    {
        public Hip_TipoInmuebleMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TipoInmueble> builder) {
           builder.HasKey(t => t.IdTipoInmueble);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Hip_TipoInmueble");
           builder.Property(t => t.IdTipoInmueble).HasColumnName("IdTipoInmueble");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
