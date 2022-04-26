using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TipoSubastaMap : IEntityTypeConfiguration<Hip_TipoSubasta>
    {
        public Hip_TipoSubastaMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TipoSubasta> builder) {
           builder.HasKey(t => t.IdTipoSubasta);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Hip_TipoSubasta");
           builder.Property(t => t.IdTipoSubasta).HasColumnName("IdTipoSubasta");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
