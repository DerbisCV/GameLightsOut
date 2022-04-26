using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TipoLugarEjecucionMap : IEntityTypeConfiguration<Hip_TipoLugarEjecucion>
    {
        public Hip_TipoLugarEjecucionMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TipoLugarEjecucion> builder) {
           builder.HasKey(t => t.IdTipoLugarEjecucion);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("Hip_TipoLugarEjecucion");
           builder.Property(t => t.IdTipoLugarEjecucion).HasColumnName("IdTipoLugarEjecucion");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
