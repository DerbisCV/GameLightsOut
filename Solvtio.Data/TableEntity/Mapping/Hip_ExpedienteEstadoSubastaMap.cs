using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoSubastaMap : IEntityTypeConfiguration<Hip_ExpedienteEstadoSubasta>
    {
        public Hip_ExpedienteEstadoSubastaMap()
        {
        }
        public void Configure(EntityTypeBuilder<Hip_ExpedienteEstadoSubasta> builder)
        {
            builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
            builder.Property(t => t.ExpedienteEstadoId)
                 .ValueGeneratedNever();

            builder.Property(t => t.Nota)
                 .HasMaxLength(2000);

            builder.Property(t => t.Autorizado)
                 .HasMaxLength(500);

            // Table & Column Mappings
            builder.ToTable("Hip_ExpedienteEstadoSubasta");
            builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            builder.Property(t => t.FechaSolicitudSubasta).HasColumnName("FechaSolicitudSubasta");
            builder.Property(t => t.TipoModeloSubastaId).HasColumnName("TipoModeloSubastaId");
            builder.Property(t => t.DocumentoSolicitudSubastaId).HasColumnName("DocumentoSolicitudSubastaId");
            builder.Property(t => t.DocumentoCelebracionSubastaId1).HasColumnName("DocumentoCelebracionSubastaId1");
            builder.Property(t => t.SubastaSuspension).HasColumnName("SubastaSuspension");
            builder.Property(t => t.FechaCelebracionSubasta1).HasColumnName("FechaCelebracionSubasta1");
            builder.Property(t => t.FechaCelebracionSubasta2).HasColumnName("FechaCelebracionSubasta2");
            builder.Property(t => t.DocumentoCelebracionSubastaId2).HasColumnName("DocumentoCelebracionSubastaId2");
            builder.Property(t => t.FechaEnvioInstruccionesProcurador).HasColumnName("FechaEnvioInstruccionesProcurador");
            builder.Property(t => t.FechaResultadoSubasta).HasColumnName("FechaResultadoSubasta");
            builder.Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
            builder.Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
            builder.Property(t => t.FechaActaSubasta).HasColumnName("FechaActaSubasta");
            builder.Property(t => t.DocumentoActaSubastaId).HasColumnName("DocumentoActaSubastaId");
            builder.Property(t => t.Postores).HasColumnName("Postores");
            builder.Property(t => t.Titulizado).HasColumnName("Titulizado");
            builder.Property(t => t.DocumentoCesionRemateId).HasColumnName("DocumentoCesionRemateId");
            builder.Property(t => t.TasacionCostes).HasColumnName("TasacionCostes");
            builder.Property(t => t.LiquidacionIntereses).HasColumnName("LiquidacionIntereses");
            builder.Property(t => t.DocumentoMandamientoPagoId).HasColumnName("DocumentoMandamientoPagoId");
            builder.Property(t => t.AdjudicacionCliente).HasColumnName("AdjudicacionCliente");
            builder.Property(t => t.DocumentoLiquidacionInteresesId).HasColumnName("DocumentoLiquidacionInteresesId");
            builder.Property(t => t.MotivoSuspension).HasColumnName("MotivoSuspension");
            builder.Property(t => t.Oposicion).HasColumnName("Oposicion");
            builder.Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            builder.Property(t => t.OposicionDocumentoId).HasColumnName("OposicionDocumentoId");
            builder.Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
            builder.Property(t => t.OposicionVistaDocumentoId).HasColumnName("OposicionVistaDocumentoId");
            builder.Property(t => t.OposicionResolucionFecha).HasColumnName("OposicionResolucionFecha");
            builder.Property(t => t.OposicionResolucionDocumentoId).HasColumnName("OposicionResolucionDocumentoId");
            builder.Property(t => t.AutorizadoEnvioGestor).HasColumnName("AutorizadoEnvioGestor");
            builder.Property(t => t.IdTipoTitulizado).HasColumnName("IdTipoTitulizado");
            builder.Property(t => t.Consignar).HasColumnName("Consignar");
            builder.Property(t => t.DecisionPociento).HasColumnName("DecisionPociento");
            builder.Property(t => t.Nota).HasColumnName("Nota");
            builder.Property(t => t.Autorizado).HasColumnName("Autorizado");
            builder.Property(t => t.IVA).HasColumnName("IVA");
            builder.Property(t => t.FechaDecretoSubasta).HasColumnName("FechaDecretoSubasta");
            builder.Property(t => t.FechaBoe).HasColumnName("FechaBoe");
            builder.Property(t => t.FechaCierrePuja).HasColumnName("FechaCierrePuja");
            builder.Property(t => t.FechaFinMejoraPuja).HasColumnName("FechaFinMejoraPuja");
            builder.Property(t => t.FestivoFinDeSemana).HasColumnName("FestivoFinDeSemana");
            builder.Property(t => t.Puja).HasColumnName("Puja");
            builder.Property(t => t.ImportePuja).HasColumnName("ImportePuja");
            builder.Property(t => t.FechaSolicitudAdjudicacionLimite).HasColumnName("FechaSolicitudAdjudicacionLimite");
            builder.Property(t => t.FechaAperturaSubasta).HasColumnName("FechaAperturaSubasta");
            builder.Property(t => t.SubastaSuspension2).HasColumnName("SubastaSuspension2");
            builder.Property(t => t.PublicadoBoe).HasColumnName("PublicadoBoe");
            builder.Property(t => t.FechaCierrePuja2).HasColumnName("FechaCierrePuja2");
            builder.Property(t => t.SuspendidaCierrePuja1).HasColumnName("SuspendidaCierrePuja1");
            builder.Property(t => t.SuspendidaCierrePuja2).HasColumnName("SuspendidaCierrePuja2");
            builder.Property(t => t.FechaSolicitudAdjudicacion).HasColumnName("FechaSolicitudAdjudicacion");
            builder.Property(t => t.ImporteSolicitudAdjudicacion).HasColumnName("ImporteSolicitudAdjudicacion");
            builder.Property(t => t.FechaCelebracionSubasta2o1).HasColumnName("FechaCelebracionSubasta2o1");
            builder.Property(t => t.SuspendidaCierrePuja2o1).HasColumnName("SuspendidaCierrePuja2o1");
            builder.Property(t => t.SubastaSuspension2o1).HasColumnName("SubastaSuspension2o1");
            builder.Property(t => t.FechaCierrePuja2o1).HasColumnName("FechaCierrePuja2o1");
            builder.Property(t => t.IdMotivoSuspension).HasColumnName("IdMotivoSuspension");

            // Relationships
            //// HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta)
            //    //  .HasForeignKey(d => d.DocumentoCelebracionSubastaId1);
            //// HasOptional(t => t.ExpedienteDocumento1)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta1)
            //    //  .HasForeignKey(d => d.DocumentoCelebracionSubastaId2);
            //// HasOptional(t => t.ExpedienteDocumento2)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta2)
            //    //  .HasForeignKey(d => d.DocumentoActaSubastaId);
            //// HasOptional(t => t.ExpedienteDocumento3)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta3)
            //    //  .HasForeignKey(d => d.DocumentoCesionRemateId);
            //// HasOptional(t => t.ExpedienteDocumento4)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta4)
            //    //  .HasForeignKey(d => d.DocumentoMandamientoPagoId);
            //// HasOptional(t => t.ExpedienteDocumento5)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta5)
            //    //  .HasForeignKey(d => d.DocumentoLiquidacionInteresesId);
            //// HasOptional(t => t.ExpedienteDocumento6)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta6)
            //    //  .HasForeignKey(d => d.OposicionDocumentoId);
            //// HasOptional(t => t.ExpedienteDocumento7)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta7)
            //    //  .HasForeignKey(d => d.OposicionResolucionDocumentoId);
            //// HasOptional(t => t.ExpedienteDocumento8)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta8)
            //    //  .HasForeignKey(d => d.OposicionVistaDocumentoId);
            //// HasOptional(t => t.ExpedienteDocumento9)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta9)
            //    //  .HasForeignKey(d => d.DocumentoSolicitudSubastaId);
            //HasRequired(t => t.ExpedienteEstado)
            //  .WithOptional(t => t.Hip_ExpedienteEstadoSubasta);
            //HasRequired(t => t.Hip_TipoSubasta)
            //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta)
            //  .HasForeignKey(d => d.TipoModeloSubastaId);
            // HasOptional(t => t.Hip_TipoTitulizado)
            //  .WithMany(t => t.Hip_ExpedienteEstadoSubasta)
            //  .HasForeignKey(d => d.IdTipoTitulizado);

        }
    }
}
