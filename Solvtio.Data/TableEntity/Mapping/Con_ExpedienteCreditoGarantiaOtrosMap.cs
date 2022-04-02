using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoGarantiaOtrosMap : EntityTypeConfiguration<Con_ExpedienteCreditoGarantiaOtros>
    {
        public Con_ExpedienteCreditoGarantiaOtrosMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteCreditoGarantiaOtros);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired();

            Property(t => t.Lote)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Con_ExpedienteCreditoGarantiaOtros");
            Property(t => t.IdExpedienteCreditoGarantiaOtros).HasColumnName("IdExpedienteCreditoGarantiaOtros");
            Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Lote).HasColumnName("Lote");
            Property(t => t.ImporteSubasta).HasColumnName("ImporteSubasta");
            Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
            Property(t => t.Adjudicado).HasColumnName("Adjudicado");
            Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");

            // Relationships
            HasRequired(t => t.Con_ExpedienteCredito)
                .WithMany(t => t.Con_ExpedienteCreditoGarantiaOtros)
                .HasForeignKey(d => d.IdExpedienteCredito);

        }
    }
}
