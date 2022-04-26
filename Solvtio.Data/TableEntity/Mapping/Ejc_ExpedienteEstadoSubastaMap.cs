using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoSubastaMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoSubasta>
    {
            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoSubasta> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

           builder.Property(t => t.Autorizados)
                .HasMaxLength(1000);

           builder.Property(t => t.SubastaSuspensionMotivo)
                .HasMaxLength(1000);

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoSubasta");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.FechaCelebracion1).HasColumnName("FechaCelebracion1");
           builder.Property(t => t.FechaCelebracion2).HasColumnName("FechaCelebracion2");
           builder.Property(t => t.FechaEnvioInstruccionesProcurador).HasColumnName("FechaEnvioInstruccionesProcurador");
           builder.Property(t => t.Autorizados).HasColumnName("Autorizados");
           builder.Property(t => t.SubastaSuspension).HasColumnName("SubastaSuspension");
           builder.Property(t => t.SubastaSuspensionMotivo).HasColumnName("SubastaSuspensionMotivo");
           builder.Property(t => t.FechaActaSubasta).HasColumnName("FechaActaSubasta");
           builder.Property(t => t.IVA).HasColumnName("IVA");
           builder.Property(t => t.Postores).HasColumnName("Postores");
           builder.Property(t => t.LiquidacionIntereses).HasColumnName("LiquidacionIntereses");
           builder.Property(t => t.TasacionCostes).HasColumnName("TasacionCostes");
           builder.Property(t => t.DecisionPociento).HasColumnName("DecisionPociento");
           builder.Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
           builder.Property(t => t.Consignar).HasColumnName("Consignar");
           builder.Property(t => t.Oposicion).HasColumnName("Oposicion");
           builder.Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
           builder.Property(t => t.OposicionFechaVista).HasColumnName("OposicionFechaVista");
           builder.Property(t => t.OposicionFechaResolucion).HasColumnName("OposicionFechaResolucion");
           builder.Property(t => t.IdDocumentoCelebracion1).HasColumnName("IdDocumentoCelebracion1");
           builder.Property(t => t.IdDocumentoCelebracion2).HasColumnName("IdDocumentoCelebracion2");
           builder.Property(t => t.IdDocumentoActaSubasta).HasColumnName("IdDocumentoActaSubasta");
           builder.Property(t => t.IdDocumentoMandamientoPago).HasColumnName("IdDocumentoMandamientoPago");
           builder.Property(t => t.IdDocumentoCesionRemate).HasColumnName("IdDocumentoCesionRemate");
           builder.Property(t => t.IdDocumentoLiquidacionIntereses).HasColumnName("IdDocumentoLiquidacionIntereses");
           builder.Property(t => t.IdDocumentoOposicion).HasColumnName("IdDocumentoOposicion");
           builder.Property(t => t.IdDocumentoOposicionSenalamientoVista).HasColumnName("IdDocumentoOposicionSenalamientoVista");
           builder.Property(t => t.IdDocumentoOposicionResolucion).HasColumnName("IdDocumentoOposicionResolucion");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoSubasta);
            //this.// HasOptional(t => t.ExpedienteDocumentoActaSubasta)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta)
            //    //  .HasForeignKey(d => d.IdDocumentoActaSubasta);
            //this.// HasOptional(t => t.ExpedienteDocumentoCelebracion1)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta1)
            //    //  .HasForeignKey(d => d.IdDocumentoCelebracion1);
            //this.// HasOptional(t => t.ExpedienteDocumentoCelebracion2)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta2)
            //    //  .HasForeignKey(d => d.IdDocumentoCelebracion2);
            //this.// HasOptional(t => t.ExpedienteDocumentoCesionRemate)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta3)
            //    //  .HasForeignKey(d => d.IdDocumentoCesionRemate);
            //this.// HasOptional(t => t.ExpedienteDocumentoLiquidacionIntereses)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta4)
            //    //  .HasForeignKey(d => d.IdDocumentoLiquidacionIntereses);
            //this.// HasOptional(t => t.ExpedienteDocumentoMandamientoPago)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta5)
            //    //  .HasForeignKey(d => d.IdDocumentoMandamientoPago);
            //this.// HasOptional(t => t.ExpedienteDocumentoOposicion)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta6)
            //    //  .HasForeignKey(d => d.IdDocumentoOposicion);
            //this.// HasOptional(t => t.ExpedienteDocumentoOposicionResolucion)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta7)
            //    //  .HasForeignKey(d => d.IdDocumentoOposicionResolucion);
            //this.// HasOptional(t => t.ExpedienteDocumentoOposicionSenalamientoVista)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSubasta8)
            //    //  .HasForeignKey(d => d.IdDocumentoOposicionSenalamientoVista);

        }
    }
}
