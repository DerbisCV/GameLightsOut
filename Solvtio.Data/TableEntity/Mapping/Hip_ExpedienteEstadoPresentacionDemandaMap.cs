using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoPresentacionDemandaMap : EntityTypeConfiguration<HipExpedienteEstadoPresentacionDemanda>
    {
        public Hip_ExpedienteEstadoPresentacionDemandaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.AdmitidaNoAuto)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoPresentacionDemanda");
            Property(t => t.IdExpedienteEstado).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaPagoTasas).HasColumnName("FechaPagoTasas");
            Property(t => t.FechaEnvioProcurador).HasColumnName("FechaEnvioProcurador");
            Property(t => t.FechaPresentacion).HasColumnName("FechaPresentacion");
            Property(t => t.DocumentoTasasId).HasColumnName("DocumentoTasasId");
            Property(t => t.DocumentoPresentacionId).HasColumnName("DocumentoPresentacionId");
            Property(t => t.DocumentoAutoEjecucionId).HasColumnName("DocumentoAutoEjecucionId");
            Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
            Property(t => t.AdmitidaDocumentoId).HasColumnName("AdmitidaDocumentoId");
            Property(t => t.AdmitidaNoAuto).HasColumnName("AdmitidaNoAuto");
            Property(t => t.AdmitidaJuzgado).HasColumnName("AdmitidaJuzgado");
            Property(t => t.NoAdmitidaFecha).HasColumnName("NoAdmitidaFecha");
            Property(t => t.NoAdmitidaFechaApelacion).HasColumnName("NoAdmitidaFechaApelacion");
            Property(t => t.NoAdmitidaApelacion).HasColumnName("NoAdmitidaApelacion");
            Property(t => t.NoAdmitidaDocumentoId).HasColumnName("NoAdmitidaDocumentoId");
            Property(t => t.NoAdmitidaDocumentoApelacionId).HasColumnName("NoAdmitidaDocumentoApelacionId");

            // Relationships
            HasOptional(t => t.ExpedienteDocumento)
                .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda)
                .HasForeignKey(d => d.DocumentoTasasId);
            HasOptional(t => t.ExpedienteDocumento1)
                .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda1)
                .HasForeignKey(d => d.DocumentoPresentacionId);
            HasOptional(t => t.ExpedienteDocumento2)
                .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda2)
                .HasForeignKey(d => d.NoAdmitidaDocumentoId);
            HasOptional(t => t.ExpedienteDocumento3)
                .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda3)
                .HasForeignKey(d => d.NoAdmitidaDocumentoApelacionId);
            HasOptional(t => t.ExpedienteDocumento4)
                .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda4)
                .HasForeignKey(d => d.DocumentoAutoEjecucionId);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Hip_ExpedienteEstadoPresentacionDemanda);

        }
    }
}
