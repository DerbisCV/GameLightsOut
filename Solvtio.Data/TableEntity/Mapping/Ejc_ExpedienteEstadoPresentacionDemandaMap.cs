using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoPresentacionDemandaMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoPresentacionDemanda>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoPresentacionDemanda> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoPresentacionDemanda");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //this.Property(t => t.FechaPagoTasas).HasColumnName("FechaPagoTasas");
            //this.Property(t => t.FechaEnvioProcurador).HasColumnName("FechaEnvioProcurador");
           builder.Property(t => t.FechaPresentacion).HasColumnName("FechaPresentacion");
            //this.Property(t => t.DocumentoTasasId).HasColumnName("DocumentoTasasId");
            //this.Property(t => t.DocumentoPresentacionId).HasColumnName("DocumentoPresentacionId");
           builder.Property(t => t.NoAdmitidaFecha).HasColumnName("NoAdmitidaFecha");
           builder.Property(t => t.NoAdmitidaFechaApelacion).HasColumnName("NoAdmitidaFechaApelacion");
           builder.Property(t => t.NoAdmitidaApelacion).HasColumnName("NoAdmitidaApelacion");
            //this.Property(t => t.NoAdmitidaDocumentoId).HasColumnName("NoAdmitidaDocumentoId");
            //this.Property(t => t.NoAdmitidaDocumentoApelacionId).HasColumnName("NoAdmitidaDocumentoApelacionId");

            // Relationships
            //this.// HasOptional(t => t.ExpedienteDocumentoPresentacionDemanda)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda)
            //    //  .HasForeignKey(d => d.DocumentoPresentacionId);
            //this.// HasOptional(t => t.ExpedienteDocumentoTasasPagadas)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda1)
            //    //  .HasForeignKey(d => d.DocumentoTasasId);
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoPresentacionDemanda);
            //this.// HasOptional(t => t.ExpedienteDocumentoNoAdmisión)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda2)
            //    //  .HasForeignKey(d => d.NoAdmitidaDocumentoApelacionId);
            //this.// HasOptional(t => t.ExpedienteDocumentoApelacion)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoPresentacionDemanda3)
            //    //  .HasForeignKey(d => d.NoAdmitidaDocumentoId);

        }
    }
}
