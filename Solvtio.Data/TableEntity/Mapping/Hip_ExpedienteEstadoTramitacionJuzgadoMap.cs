using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoTramitacionJuzgadoMap : EntityTypeConfiguration<HipExpedienteEstadoTramitacionSubasta>
    {
        public Hip_ExpedienteEstadoTramitacionJuzgadoMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //this.Property(t => t.AdmitidaNoAuto)
            //    .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoTramitacionJuzgado");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaCertificacionCargas).HasColumnName("FechaCertificacionCargas");
            Property(t => t.Oposicion).HasColumnName("Oposicion");
            Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            //Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
            Property(t => t.OposicionResolucionFecha).HasColumnName("OposicionResolucionFecha");
            Property(t => t.RequerimientoPagoFecha).HasColumnName("RequerimientoPagoFecha");
            Property(t => t.RequerimientoPagoPositivo).HasColumnName("RequerimientoPagoPositivo");

            Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
        
            Property(t => t.FechaSolicitudSubasta).HasColumnName("FechaSolicitudSubasta");
            Property(t => t.DocumentoSolicitudSubastaId).HasColumnName("DocumentoSolicitudSubastaId");
            Property(t => t.Apelacion).HasColumnName("Apelacion");
            //Property(t => t.ApelacionFecha).HasColumnName("ApelacionFecha");
            Property(t => t.ApelacionPor).HasColumnName("ApelacionPor");
            Property(t => t.OposicionResultado).HasColumnName("OposicionResultado");
            Property(t => t.ApelacionResultado).HasColumnName("ApelacionResultado");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.HipExpedienteEstadoTramitacionSubasta);

        }
    }
}
