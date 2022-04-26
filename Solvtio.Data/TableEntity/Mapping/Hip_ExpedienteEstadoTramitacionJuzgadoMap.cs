using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoTramitacionJuzgadoMap : IEntityTypeConfiguration<HipExpedienteEstadoTramitacionSubasta>
    {
        public Hip_ExpedienteEstadoTramitacionJuzgadoMap()
        {
           } public void Configure(EntityTypeBuilder<HipExpedienteEstadoTramitacionSubasta> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

            //this.Property(t => t.AdmitidaNoAuto)
            //    .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoTramitacionJuzgado");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaCertificacionCargas).HasColumnName("FechaCertificacionCargas");
           builder.Property(t => t.Oposicion).HasColumnName("Oposicion");
           builder.Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            //Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
           builder.Property(t => t.OposicionResolucionFecha).HasColumnName("OposicionResolucionFecha");
           builder.Property(t => t.RequerimientoPagoFecha).HasColumnName("RequerimientoPagoFecha");
           builder.Property(t => t.RequerimientoPagoPositivo).HasColumnName("RequerimientoPagoPositivo");

           builder.Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
        
           builder.Property(t => t.FechaSolicitudSubasta).HasColumnName("FechaSolicitudSubasta");
           builder.Property(t => t.DocumentoSolicitudSubastaId).HasColumnName("DocumentoSolicitudSubastaId");
           builder.Property(t => t.Apelacion).HasColumnName("Apelacion");
            //Property(t => t.ApelacionFecha).HasColumnName("ApelacionFecha");
           builder.Property(t => t.ApelacionPor).HasColumnName("ApelacionPor");
           builder.Property(t => t.OposicionResultado).HasColumnName("OposicionResultado");
           builder.Property(t => t.ApelacionResultado).HasColumnName("ApelacionResultado");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.HipExpedienteEstadoTramitacionSubasta);

        }
    }
}
