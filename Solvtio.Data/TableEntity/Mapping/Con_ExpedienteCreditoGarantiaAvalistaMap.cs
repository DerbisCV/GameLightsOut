using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoGarantiaAvalistaMap : EntityTypeConfiguration<Con_ExpedienteCreditoGarantiaAvalista>
    {
        public Con_ExpedienteCreditoGarantiaAvalistaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteCreditoGarantiaAvalista);

            // Properties
            // Table & Column Mappings
            ToTable("Con_ExpedienteCreditoGarantiaAvalista");
            Property(t => t.IdExpedienteCreditoGarantiaAvalista).HasColumnName("IdExpedienteCreditoGarantiaAvalista");
            Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");

            // Relationships
            HasRequired(t => t.Con_ExpedienteCredito)
                .WithMany(t => t.Con_ExpedienteCreditoGarantiaAvalista)
                .HasForeignKey(d => d.IdExpedienteCredito);
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Con_ExpedienteCreditoGarantiaAvalista)
                .HasForeignKey(d => d.IdPersona);
            HasRequired(t => t.Gnr_TipoDeudor)
                .WithMany(t => t.Con_ExpedienteCreditoGarantiaAvalista)
                .HasForeignKey(d => d.IdTipoDeudor);

        }
    }
}
