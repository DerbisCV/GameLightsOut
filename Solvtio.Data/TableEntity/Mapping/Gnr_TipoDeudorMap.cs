using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoDeudorMap : IEntityTypeConfiguration<Gnr_TipoDeudor>
    {
        public Gnr_TipoDeudorMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoDeudor> builder) {
           builder.HasKey(t => t.IdTipoDeudor);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

           builder.Property(t => t.DescripcionDemanda)
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoDeudor");
           builder.Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.DescripcionDemanda).HasColumnName("DescripcionDemanda");
           builder.Property(t => t.Activo).HasColumnName("Activo");
           builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");

            // Relationships
            // HasOptional(t => t.Gnr_TipoExpediente)
                //  .WithMany(t => t.Gnr_TipoDeudor)
                //  .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
