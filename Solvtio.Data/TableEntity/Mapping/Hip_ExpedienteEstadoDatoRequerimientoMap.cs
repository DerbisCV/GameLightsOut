using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoDatoRequerimientoMap : IEntityTypeConfiguration<Hip_ExpedienteEstadoDatoRequerimiento>
    {
        public Hip_ExpedienteEstadoDatoRequerimientoMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_ExpedienteEstadoDatoRequerimiento> builder) {
           builder.HasKey(t => t.IdExpedienteEstadoRequerimiento);

            // Properties
           builder.Property(t => t.RequerimientoDeudor)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoDatoRequerimiento");
           builder.Property(t => t.IdExpedienteEstadoRequerimiento).HasColumnName("IdExpedienteEstadoRequerimiento");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaRequerimientoPago).HasColumnName("FechaRequerimientoPago");
            //this.Property(t => t.DocumentoRequerimientoPagoId).HasColumnName("DocumentoRequerimientoPagoId");
            //this.Property(t => t.DocumentoSolicitudEdictosId).HasColumnName("DocumentoSolicitudEdictosId");
           builder.Property(t => t.Positivo).HasColumnName("Positivo");
           builder.Property(t => t.RequerimientoDeudor).HasColumnName("RequerimientoDeudor");
            //this.Property(t => t.Positivo_Default).HasColumnName("Positivo_Default");
           builder.Property(t => t.TipoDeudor).HasColumnName("TipoDeudor");
           builder.Property(t => t.ResultadoApelacion).HasColumnName("ResultadoApelacion");

            //// Relationships
            //this.// HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoDatoRequerimiento)
            //    //  .HasForeignKey(d => d.DocumentoRequerimientoPagoId);
            //this.// HasOptional(t => t.ExpedienteDocumento1)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoDatoRequerimiento1)
            //    //  .HasForeignKey(d => d.DocumentoSolicitudEdictosId);
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithMany(t => t.Hip_ExpedienteEstadoDatoRequerimiento)
                //  .HasForeignKey(d => d.ExpedienteEstadoId);

        }
    }
}
