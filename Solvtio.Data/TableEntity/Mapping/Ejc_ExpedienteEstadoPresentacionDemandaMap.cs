using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoPresentacionDemandaMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoPresentacionDemanda>
    {
        public Ejc_ExpedienteEstadoPresentacionDemandaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoPresentacionDemanda");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //this.Property(t => t.FechaPagoTasas).HasColumnName("FechaPagoTasas");
            //this.Property(t => t.FechaEnvioProcurador).HasColumnName("FechaEnvioProcurador");
            Property(t => t.FechaPresentacion).HasColumnName("FechaPresentacion");
            //this.Property(t => t.DocumentoTasasId).HasColumnName("DocumentoTasasId");
            //this.Property(t => t.DocumentoPresentacionId).HasColumnName("DocumentoPresentacionId");
            Property(t => t.NoAdmitidaFecha).HasColumnName("NoAdmitidaFecha");
            Property(t => t.NoAdmitidaFechaApelacion).HasColumnName("NoAdmitidaFechaApelacion");
            Property(t => t.NoAdmitidaApelacion).HasColumnName("NoAdmitidaApelacion");
            //this.Property(t => t.NoAdmitidaDocumentoId).HasColumnName("NoAdmitidaDocumentoId");
            //this.Property(t => t.NoAdmitidaDocumentoApelacionId).HasColumnName("NoAdmitidaDocumentoApelacionId");

            // Relationships
            //this.HasOptional(t => t.ExpedienteDocumentoPresentacionDemanda)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda)
            //    .HasForeignKey(d => d.DocumentoPresentacionId);
            //this.HasOptional(t => t.ExpedienteDocumentoTasasPagadas)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda1)
            //    .HasForeignKey(d => d.DocumentoTasasId);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoPresentacionDemanda);
            //this.HasOptional(t => t.ExpedienteDocumentoNoAdmisión)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda2)
            //    .HasForeignKey(d => d.NoAdmitidaDocumentoApelacionId);
            //this.HasOptional(t => t.ExpedienteDocumentoApelacion)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda3)
            //    .HasForeignKey(d => d.NoAdmitidaDocumentoId);

        }
    }
}
