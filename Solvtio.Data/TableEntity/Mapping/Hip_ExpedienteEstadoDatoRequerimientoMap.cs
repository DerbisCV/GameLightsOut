using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoDatoRequerimientoMap : EntityTypeConfiguration<Hip_ExpedienteEstadoDatoRequerimiento>
    {
        public Hip_ExpedienteEstadoDatoRequerimientoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstadoRequerimiento);

            // Properties
            Property(t => t.RequerimientoDeudor)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoDatoRequerimiento");
            Property(t => t.IdExpedienteEstadoRequerimiento).HasColumnName("IdExpedienteEstadoRequerimiento");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaRequerimientoPago).HasColumnName("FechaRequerimientoPago");
            //this.Property(t => t.DocumentoRequerimientoPagoId).HasColumnName("DocumentoRequerimientoPagoId");
            //this.Property(t => t.DocumentoSolicitudEdictosId).HasColumnName("DocumentoSolicitudEdictosId");
            Property(t => t.Positivo).HasColumnName("Positivo");
            Property(t => t.RequerimientoDeudor).HasColumnName("RequerimientoDeudor");
            //this.Property(t => t.Positivo_Default).HasColumnName("Positivo_Default");
            Property(t => t.TipoDeudor).HasColumnName("TipoDeudor");
            Property(t => t.ResultadoApelacion).HasColumnName("ResultadoApelacion");

            //// Relationships
            //this.HasOptional(t => t.ExpedienteDocumento)
            //    .WithMany(t => t.Hip_ExpedienteEstadoDatoRequerimiento)
            //    .HasForeignKey(d => d.DocumentoRequerimientoPagoId);
            //this.HasOptional(t => t.ExpedienteDocumento1)
            //    .WithMany(t => t.Hip_ExpedienteEstadoDatoRequerimiento1)
            //    .HasForeignKey(d => d.DocumentoSolicitudEdictosId);
            HasRequired(t => t.ExpedienteEstado)
                .WithMany(t => t.Hip_ExpedienteEstadoDatoRequerimiento)
                .HasForeignKey(d => d.ExpedienteEstadoId);

        }
    }
}
