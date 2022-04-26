using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoPresentacionDemandaMap : IEntityTypeConfiguration<HipExpedienteEstadoPresentacionDemanda>
    {
        public Hip_ExpedienteEstadoPresentacionDemandaMap()
        {
           } public void Configure(EntityTypeBuilder<HipExpedienteEstadoPresentacionDemanda> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

           builder.Property(t => t.AdmitidaNoAuto)
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoPresentacionDemanda");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaPagoTasas).HasColumnName("FechaPagoTasas");
           builder.Property(t => t.FechaEnvioProcurador).HasColumnName("FechaEnvioProcurador");
           builder.Property(t => t.FechaPresentacion).HasColumnName("FechaPresentacion");
           builder.Property(t => t.DocumentoTasasId).HasColumnName("DocumentoTasasId");
           builder.Property(t => t.DocumentoPresentacionId).HasColumnName("DocumentoPresentacionId");
           builder.Property(t => t.DocumentoAutoEjecucionId).HasColumnName("DocumentoAutoEjecucionId");
           builder.Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
           builder.Property(t => t.AdmitidaDocumentoId).HasColumnName("AdmitidaDocumentoId");
           builder.Property(t => t.AdmitidaNoAuto).HasColumnName("AdmitidaNoAuto");
           builder.Property(t => t.AdmitidaJuzgado).HasColumnName("AdmitidaJuzgado");
           builder.Property(t => t.NoAdmitidaFecha).HasColumnName("NoAdmitidaFecha");
           builder.Property(t => t.NoAdmitidaFechaApelacion).HasColumnName("NoAdmitidaFechaApelacion");
           builder.Property(t => t.NoAdmitidaApelacion).HasColumnName("NoAdmitidaApelacion");
           builder.Property(t => t.NoAdmitidaDocumentoId).HasColumnName("NoAdmitidaDocumentoId");
           builder.Property(t => t.NoAdmitidaDocumentoApelacionId).HasColumnName("NoAdmitidaDocumentoApelacionId");

            // Relationships
            //// HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda)
            //    //  .HasForeignKey(d => d.DocumentoTasasId);
            //// HasOptional(t => t.ExpedienteDocumento1)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda1)
            //    //  .HasForeignKey(d => d.DocumentoPresentacionId);
            //// HasOptional(t => t.ExpedienteDocumento2)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda2)
            //    //  .HasForeignKey(d => d.NoAdmitidaDocumentoId);
            //// HasOptional(t => t.ExpedienteDocumento3)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda3)
            //    //  .HasForeignKey(d => d.NoAdmitidaDocumentoApelacionId);
            //// HasOptional(t => t.ExpedienteDocumento4)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoPresentacionDemanda4)
            //    //  .HasForeignKey(d => d.DocumentoAutoEjecucionId);
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Hip_ExpedienteEstadoPresentacionDemanda);

        }
    }
}
