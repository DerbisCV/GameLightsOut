using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteDeudorMap : EntityTypeConfiguration<ExpedienteDeudor>
    {
        public ExpedienteDeudorMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteDeudor);

            // Properties
            // Table & Column Mappings
            ToTable("ExpedienteDeudor");
            Property(t => t.IdExpedienteDeudor).HasColumnName("IdExpedienteDeudor");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");
            Property(t => t.DomicilioNotificacion).HasColumnName("DomicilioNotificacion");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.ExpedienteDeudors)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.ExpedienteDeudors)
                .HasForeignKey(d => d.IdPersona);
            HasRequired(t => t.Gnr_TipoDeudor)
                .WithMany(t => t.ExpedienteDeudors)
                .HasForeignKey(d => d.IdTipoDeudor);

        }
    }
}
