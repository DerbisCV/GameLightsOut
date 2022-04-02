using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoSubastaMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoSubasta>
    {
        public Ejc_ExpedienteEstadoSubastaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Autorizados)
                .HasMaxLength(1000);

            Property(t => t.SubastaSuspensionMotivo)
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoSubasta");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.FechaCelebracion1).HasColumnName("FechaCelebracion1");
            Property(t => t.FechaCelebracion2).HasColumnName("FechaCelebracion2");
            Property(t => t.FechaEnvioInstruccionesProcurador).HasColumnName("FechaEnvioInstruccionesProcurador");
            Property(t => t.Autorizados).HasColumnName("Autorizados");
            Property(t => t.SubastaSuspension).HasColumnName("SubastaSuspension");
            Property(t => t.SubastaSuspensionMotivo).HasColumnName("SubastaSuspensionMotivo");
            Property(t => t.FechaActaSubasta).HasColumnName("FechaActaSubasta");
            Property(t => t.IVA).HasColumnName("IVA");
            Property(t => t.Postores).HasColumnName("Postores");
            Property(t => t.LiquidacionIntereses).HasColumnName("LiquidacionIntereses");
            Property(t => t.TasacionCostes).HasColumnName("TasacionCostes");
            Property(t => t.DecisionPociento).HasColumnName("DecisionPociento");
            Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
            Property(t => t.Consignar).HasColumnName("Consignar");
            Property(t => t.Oposicion).HasColumnName("Oposicion");
            Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            Property(t => t.OposicionFechaVista).HasColumnName("OposicionFechaVista");
            Property(t => t.OposicionFechaResolucion).HasColumnName("OposicionFechaResolucion");
            Property(t => t.IdDocumentoCelebracion1).HasColumnName("IdDocumentoCelebracion1");
            Property(t => t.IdDocumentoCelebracion2).HasColumnName("IdDocumentoCelebracion2");
            Property(t => t.IdDocumentoActaSubasta).HasColumnName("IdDocumentoActaSubasta");
            Property(t => t.IdDocumentoMandamientoPago).HasColumnName("IdDocumentoMandamientoPago");
            Property(t => t.IdDocumentoCesionRemate).HasColumnName("IdDocumentoCesionRemate");
            Property(t => t.IdDocumentoLiquidacionIntereses).HasColumnName("IdDocumentoLiquidacionIntereses");
            Property(t => t.IdDocumentoOposicion).HasColumnName("IdDocumentoOposicion");
            Property(t => t.IdDocumentoOposicionSenalamientoVista).HasColumnName("IdDocumentoOposicionSenalamientoVista");
            Property(t => t.IdDocumentoOposicionResolucion).HasColumnName("IdDocumentoOposicionResolucion");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoSubasta);
            //this.HasOptional(t => t.ExpedienteDocumentoActaSubasta)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta)
            //    .HasForeignKey(d => d.IdDocumentoActaSubasta);
            //this.HasOptional(t => t.ExpedienteDocumentoCelebracion1)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta1)
            //    .HasForeignKey(d => d.IdDocumentoCelebracion1);
            //this.HasOptional(t => t.ExpedienteDocumentoCelebracion2)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta2)
            //    .HasForeignKey(d => d.IdDocumentoCelebracion2);
            //this.HasOptional(t => t.ExpedienteDocumentoCesionRemate)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta3)
            //    .HasForeignKey(d => d.IdDocumentoCesionRemate);
            //this.HasOptional(t => t.ExpedienteDocumentoLiquidacionIntereses)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta4)
            //    .HasForeignKey(d => d.IdDocumentoLiquidacionIntereses);
            //this.HasOptional(t => t.ExpedienteDocumentoMandamientoPago)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta5)
            //    .HasForeignKey(d => d.IdDocumentoMandamientoPago);
            //this.HasOptional(t => t.ExpedienteDocumentoOposicion)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta6)
            //    .HasForeignKey(d => d.IdDocumentoOposicion);
            //this.HasOptional(t => t.ExpedienteDocumentoOposicionResolucion)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta7)
            //    .HasForeignKey(d => d.IdDocumentoOposicionResolucion);
            //this.HasOptional(t => t.ExpedienteDocumentoOposicionSenalamientoVista)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoSubasta8)
            //    .HasForeignKey(d => d.IdDocumentoOposicionSenalamientoVista);

        }
    }
}
