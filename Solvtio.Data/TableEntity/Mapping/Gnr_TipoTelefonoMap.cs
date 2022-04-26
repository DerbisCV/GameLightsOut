using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoTelefonoMap : IEntityTypeConfiguration<Gnr_TipoTelefono>
    {
        public Gnr_TipoTelefonoMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoTelefono> builder) {
           builder.HasKey(t => t.IdTipoTelefono);

            // Properties
           builder.Property(t => t.Abreviacion)
                .HasMaxLength(5);

           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoTelefono");
           builder.Property(t => t.IdTipoTelefono).HasColumnName("IdTipoTelefono");
           builder.Property(t => t.Abreviacion).HasColumnName("Abreviacion");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
