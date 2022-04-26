
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoRequerimientoPagoMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoRequerimientoPago>
    {

        public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoRequerimientoPago> builder)
        {
            builder.HasKey(t => t.IdExpedienteEstadoRequerimientoPago);

            // Properties
            builder.Property(t => t.RequerimientoDeudor)
                 .IsRequired()
                 .HasMaxLength(250);

            // Table & Column Mappings
            builder.ToTable("Ejc_ExpedienteEstadoRequerimientoPago");
            builder.Property(t => t.IdExpedienteEstadoRequerimientoPago).HasColumnName("IdExpedienteEstadoRequerimientoPago");
            builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            builder.Property(t => t.FechaRequerimientoPago).HasColumnName("FechaRequerimientoPago");
            builder.Property(t => t.Positivo).HasColumnName("Positivo");
            builder.Property(t => t.RequerimientoDeudor).HasColumnName("RequerimientoDeudor");
            builder.Property(t => t.IdDocumentoRequerimientoPago).HasColumnName("IdDocumentoRequerimientoPago");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
            //  .WithMany(t => t.Ejc_ExpedienteEstadoRequerimientoPago)
            //  .HasForeignKey(d => d.IdExpedienteEstado);
            //// HasOptional(t => t.ExpedienteDocumentoRequerimientoPago)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoRequerimientoPago)
            //    //  .HasForeignKey(d => d.IdDocumentoRequerimientoPago);

        }
    }
}
