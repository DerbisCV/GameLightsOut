using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoRequerimientoPagoMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoRequerimientoPago>
    {
        public Ejc_ExpedienteEstadoRequerimientoPagoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstadoRequerimientoPago);

            // Properties
            Property(t => t.RequerimientoDeudor)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoRequerimientoPago");
            Property(t => t.IdExpedienteEstadoRequerimientoPago).HasColumnName("IdExpedienteEstadoRequerimientoPago");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.FechaRequerimientoPago).HasColumnName("FechaRequerimientoPago");
            Property(t => t.Positivo).HasColumnName("Positivo");
            Property(t => t.RequerimientoDeudor).HasColumnName("RequerimientoDeudor");
            Property(t => t.IdDocumentoRequerimientoPago).HasColumnName("IdDocumentoRequerimientoPago");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithMany(t => t.Ejc_ExpedienteEstadoRequerimientoPago)
                .HasForeignKey(d => d.IdExpedienteEstado);
            HasOptional(t => t.ExpedienteDocumentoRequerimientoPago)
                .WithMany(t => t.Ejc_ExpedienteEstadoRequerimientoPago)
                .HasForeignKey(d => d.IdDocumentoRequerimientoPago);

        }
    }
}
