using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoTratamientoMap : IEntityTypeConfiguration<Gnr_TipoTratamiento>
    {
        public Gnr_TipoTratamientoMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoTratamiento> builder) {
           builder.HasKey(t => t.IdTratamiento);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoTratamiento");
           builder.Property(t => t.IdTratamiento).HasColumnName("IdTratamiento");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
