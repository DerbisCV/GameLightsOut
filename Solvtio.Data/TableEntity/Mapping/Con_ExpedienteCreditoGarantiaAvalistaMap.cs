using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoGarantiaAvalistaMap : IEntityTypeConfiguration<Con_ExpedienteCreditoGarantiaAvalista>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteCreditoGarantiaAvalista> builder) {
           builder.HasKey(t => t.IdExpedienteCreditoGarantiaAvalista);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteCreditoGarantiaAvalista");
           builder.Property(t => t.IdExpedienteCreditoGarantiaAvalista).HasColumnName("IdExpedienteCreditoGarantiaAvalista");
           builder.Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");

            // Relationships
            //HasRequired(t => t.Con_ExpedienteCredito)
            //    .WithMany(t => t.Con_ExpedienteCreditoGarantiaAvalista)
            //    .HasForeignKey(d => d.IdExpedienteCredito);
            //HasRequired(t => t.Gnr_Persona)
            //    .WithMany(t => t.Con_ExpedienteCreditoGarantiaAvalista)
            //    .HasForeignKey(d => d.IdPersona);
            //HasRequired(t => t.Gnr_TipoDeudor)
            //    .WithMany(t => t.Con_ExpedienteCreditoGarantiaAvalista)
            //    .HasForeignKey(d => d.IdTipoDeudor);

        }
    }
}
