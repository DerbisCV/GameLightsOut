using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class TipoExpedienteAccionMap : EntityTypeConfiguration<TipoExpedienteAccion>
    {
        public TipoExpedienteAccionMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoExpedienteAccion);

            // Properties
            // Table & Column Mappings
            ToTable("TipoExpedienteAccion");
            Property(t => t.IdTipoExpedienteAccion).HasColumnName("IdTipoExpedienteAccion");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            Property(t => t.IdTipoAccion).HasColumnName("IdTipoAccion");

            // Relationships
            HasRequired(t => t.Gnr_TipoExpediente)
                .WithMany(t => t.TipoExpedienteAccions)
                .HasForeignKey(d => d.IdTipoExpediente);
            HasRequired(t => t.TipoAccion)
                .WithMany(t => t.TipoExpedienteAccions)
                .HasForeignKey(d => d.IdTipoAccion);

        }
    }
}
