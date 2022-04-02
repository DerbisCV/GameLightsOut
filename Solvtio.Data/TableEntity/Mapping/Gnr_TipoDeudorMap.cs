using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoDeudorMap : EntityTypeConfiguration<Gnr_TipoDeudor>
    {
        public Gnr_TipoDeudorMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoDeudor);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.DescripcionDemanda)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Gnr_TipoDeudor");
            Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.DescripcionDemanda).HasColumnName("DescripcionDemanda");
            Property(t => t.Activo).HasColumnName("Activo");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");

            // Relationships
            HasOptional(t => t.Gnr_TipoExpediente)
                .WithMany(t => t.Gnr_TipoDeudor)
                .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
