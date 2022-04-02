using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoSubastaMap : EntityTypeConfiguration<Hip_ExpedienteEstadoSubasta>
    {
        public Hip_ExpedienteEstadoSubastaMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Nota)
                .HasMaxLength(2000);

            Property(t => t.Autorizado)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoSubasta");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaSolicitudSubasta).HasColumnName("FechaSolicitudSubasta");
            Property(t => t.TipoModeloSubastaId).HasColumnName("TipoModeloSubastaId");
            Property(t => t.DocumentoSolicitudSubastaId).HasColumnName("DocumentoSolicitudSubastaId");
            Property(t => t.DocumentoCelebracionSubastaId1).HasColumnName("DocumentoCelebracionSubastaId1");
            Property(t => t.SubastaSuspension).HasColumnName("SubastaSuspension");
            Property(t => t.FechaCelebracionSubasta1).HasColumnName("FechaCelebracionSubasta1");
            Property(t => t.FechaCelebracionSubasta2).HasColumnName("FechaCelebracionSubasta2");
            Property(t => t.DocumentoCelebracionSubastaId2).HasColumnName("DocumentoCelebracionSubastaId2");
            Property(t => t.FechaEnvioInstruccionesProcurador).HasColumnName("FechaEnvioInstruccionesProcurador");
            Property(t => t.FechaResultadoSubasta).HasColumnName("FechaResultadoSubasta");
            Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
            Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
            Property(t => t.FechaActaSubasta).HasColumnName("FechaActaSubasta");
            Property(t => t.DocumentoActaSubastaId).HasColumnName("DocumentoActaSubastaId");
            Property(t => t.Postores).HasColumnName("Postores");
            Property(t => t.Titulizado).HasColumnName("Titulizado");
            Property(t => t.DocumentoCesionRemateId).HasColumnName("DocumentoCesionRemateId");
            Property(t => t.TasacionCostes).HasColumnName("TasacionCostes");
            Property(t => t.LiquidacionIntereses).HasColumnName("LiquidacionIntereses");
            Property(t => t.DocumentoMandamientoPagoId).HasColumnName("DocumentoMandamientoPagoId");
            Property(t => t.AdjudicacionCliente).HasColumnName("AdjudicacionCliente");
            Property(t => t.DocumentoLiquidacionInteresesId).HasColumnName("DocumentoLiquidacionInteresesId");
            Property(t => t.MotivoSuspension).HasColumnName("MotivoSuspension");
            Property(t => t.Oposicion).HasColumnName("Oposicion");
            Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            Property(t => t.OposicionDocumentoId).HasColumnName("OposicionDocumentoId");
            Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
            Property(t => t.OposicionVistaDocumentoId).HasColumnName("OposicionVistaDocumentoId");
            Property(t => t.OposicionResolucionFecha).HasColumnName("OposicionResolucionFecha");
            Property(t => t.OposicionResolucionDocumentoId).HasColumnName("OposicionResolucionDocumentoId");
            Property(t => t.AutorizadoEnvioGestor).HasColumnName("AutorizadoEnvioGestor");
            Property(t => t.IdTipoTitulizado).HasColumnName("IdTipoTitulizado");
            Property(t => t.Consignar).HasColumnName("Consignar");
            Property(t => t.DecisionPociento).HasColumnName("DecisionPociento");
            Property(t => t.Nota).HasColumnName("Nota");
            Property(t => t.Autorizado).HasColumnName("Autorizado");
            Property(t => t.IVA).HasColumnName("IVA");
            Property(t => t.FechaDecretoSubasta).HasColumnName("FechaDecretoSubasta");
            Property(t => t.FechaBoe).HasColumnName("FechaBoe");
            Property(t => t.FechaCierrePuja).HasColumnName("FechaCierrePuja");
            Property(t => t.FechaFinMejoraPuja).HasColumnName("FechaFinMejoraPuja");
            Property(t => t.FestivoFinDeSemana).HasColumnName("FestivoFinDeSemana");
            Property(t => t.Puja).HasColumnName("Puja");
            Property(t => t.ImportePuja).HasColumnName("ImportePuja");
            Property(t => t.FechaSolicitudAdjudicacionLimite).HasColumnName("FechaSolicitudAdjudicacionLimite");
            Property(t => t.FechaAperturaSubasta).HasColumnName("FechaAperturaSubasta");
            Property(t => t.SubastaSuspension2).HasColumnName("SubastaSuspension2");
            Property(t => t.PublicadoBoe).HasColumnName("PublicadoBoe");
            Property(t => t.FechaCierrePuja2).HasColumnName("FechaCierrePuja2");
            Property(t => t.SuspendidaCierrePuja1).HasColumnName("SuspendidaCierrePuja1");
            Property(t => t.SuspendidaCierrePuja2).HasColumnName("SuspendidaCierrePuja2");
            Property(t => t.FechaSolicitudAdjudicacion).HasColumnName("FechaSolicitudAdjudicacion");
            Property(t => t.ImporteSolicitudAdjudicacion).HasColumnName("ImporteSolicitudAdjudicacion");
            Property(t => t.FechaCelebracionSubasta2o1).HasColumnName("FechaCelebracionSubasta2o1");
            Property(t => t.SuspendidaCierrePuja2o1).HasColumnName("SuspendidaCierrePuja2o1");
            Property(t => t.SubastaSuspension2o1).HasColumnName("SubastaSuspension2o1");
            Property(t => t.FechaCierrePuja2o1).HasColumnName("FechaCierrePuja2o1");
            Property(t => t.IdMotivoSuspension).HasColumnName("IdMotivoSuspension");

            // Relationships
            HasOptional(t => t.ExpedienteDocumento)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta)
                .HasForeignKey(d => d.DocumentoCelebracionSubastaId1);
            HasOptional(t => t.ExpedienteDocumento1)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta1)
                .HasForeignKey(d => d.DocumentoCelebracionSubastaId2);
            HasOptional(t => t.ExpedienteDocumento2)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta2)
                .HasForeignKey(d => d.DocumentoActaSubastaId);
            HasOptional(t => t.ExpedienteDocumento3)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta3)
                .HasForeignKey(d => d.DocumentoCesionRemateId);
            HasOptional(t => t.ExpedienteDocumento4)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta4)
                .HasForeignKey(d => d.DocumentoMandamientoPagoId);
            HasOptional(t => t.ExpedienteDocumento5)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta5)
                .HasForeignKey(d => d.DocumentoLiquidacionInteresesId);
            HasOptional(t => t.ExpedienteDocumento6)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta6)
                .HasForeignKey(d => d.OposicionDocumentoId);
            HasOptional(t => t.ExpedienteDocumento7)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta7)
                .HasForeignKey(d => d.OposicionResolucionDocumentoId);
            HasOptional(t => t.ExpedienteDocumento8)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta8)
                .HasForeignKey(d => d.OposicionVistaDocumentoId);
            HasOptional(t => t.ExpedienteDocumento9)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta9)
                .HasForeignKey(d => d.DocumentoSolicitudSubastaId);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Hip_ExpedienteEstadoSubasta);
            HasRequired(t => t.Hip_TipoSubasta)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta)
                .HasForeignKey(d => d.TipoModeloSubastaId);
            HasOptional(t => t.Hip_TipoTitulizado)
                .WithMany(t => t.Hip_ExpedienteEstadoSubasta)
                .HasForeignKey(d => d.IdTipoTitulizado);

        }
    }
}
