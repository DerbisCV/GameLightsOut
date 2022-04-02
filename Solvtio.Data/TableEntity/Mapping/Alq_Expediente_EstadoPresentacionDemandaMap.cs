using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoPresentacionDemandaMap : EntityTypeConfiguration<Alq_Expediente_EstadoPresentacionDemanda>
    {
        public Alq_Expediente_EstadoPresentacionDemandaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.AdmitidaNoAuto)
                .HasMaxLength(100);

            Property(t => t.AdmitidaJuzgado)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Alq_Expediente_EstadoPresentacionDemanda");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.FechaPagoTasas).HasColumnName("FechaPagoTasas");
            Property(t => t.FechaPagoTasasAutomaticas).HasColumnName("FechaPagoTasasAutomaticas");
            Property(t => t.FechaEnvioProcurador).HasColumnName("FechaEnvioProcurador");
            Property(t => t.FechaPresentacion).HasColumnName("FechaPresentacion");
            Property(t => t.DocumentoTasasId).HasColumnName("DocumentoTasasId");
            Property(t => t.DocumentoPresentacionId).HasColumnName("DocumentoPresentacionId");
            Property(t => t.DocumentoAutoEjecucionId).HasColumnName("DocumentoAutoEjecucionId");
            //this.Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
            Property(t => t.AdmitidaDocumentoId).HasColumnName("AdmitidaDocumentoId");
            Property(t => t.AdmitidaNoAuto).HasColumnName("AdmitidaNoAuto");
            Property(t => t.AdmitidaJuzgado).HasColumnName("AdmitidaJuzgado");
            Property(t => t.NoAdmitidaFecha).HasColumnName("NoAdmitidaFecha");
            Property(t => t.NoAdmitidaFechaApelacion).HasColumnName("NoAdmitidaFechaApelacion");
            Property(t => t.NoAdmitidaApelacion).HasColumnName("NoAdmitidaApelacion");
            Property(t => t.NoAdmitidaDocumentoId).HasColumnName("NoAdmitidaDocumentoId");
            Property(t => t.NoAdmitidaDocumentoApelacionId).HasColumnName("NoAdmitidaDocumentoApelacionId");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Alq_Expediente_EstadoPresentacionDemanda);
            HasOptional(t => t.ExpedienteDocumento)
                .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda)
                .HasForeignKey(d => d.AdmitidaDocumentoId);
            HasOptional(t => t.ExpedienteDocumento1)
                .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda1)
                .HasForeignKey(d => d.NoAdmitidaDocumentoApelacionId);
            HasOptional(t => t.ExpedienteDocumento2)
                .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda2)
                .HasForeignKey(d => d.DocumentoAutoEjecucionId);
            HasOptional(t => t.ExpedienteDocumento3)
                .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda3)
                .HasForeignKey(d => d.NoAdmitidaDocumentoId);
            HasOptional(t => t.ExpedienteDocumento4)
                .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda4)
                .HasForeignKey(d => d.DocumentoPresentacionId);
            HasOptional(t => t.ExpedienteDocumento5)
                .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda5)
                .HasForeignKey(d => d.DocumentoTasasId);

        }
    }
}
