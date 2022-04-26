using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TipoPeriodicidadMap : IEntityTypeConfiguration<Hip_TipoPeriodicidad>
    {
        public Hip_TipoPeriodicidadMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TipoPeriodicidad> builder) {
           builder.HasKey(t => t.IdPeriodicidad);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Hip_TipoPeriodicidad");
           builder.Property(t => t.IdPeriodicidad).HasColumnName("IdPeriodicidad");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
