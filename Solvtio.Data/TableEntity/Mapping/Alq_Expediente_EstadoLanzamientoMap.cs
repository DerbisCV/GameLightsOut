using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoLanzamientoMap : IEntityTypeConfiguration<Alq_Expediente_EstadoLanzamiento>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_EstadoLanzamiento> builder)
        {
            // 
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

           builder.Property(t => t.Autorizado)
                .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_EstadoLanzamiento");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.FechaSolicitudLanzamiento).HasColumnName("FechaSolicitudLanzamiento");
           builder.Property(t => t.LanzamientoFecha1).HasColumnName("FechaCelebracionLanzamiento1");
           builder.Property(t => t.Autorizado).HasColumnName("Autorizado");
           builder.Property(t => t.FechaEnvioInstruccionesProcurador).HasColumnName("FechaEnvioInstruccionesProcurador");
           builder.Property(t => t.LanzamientoSuspension1).HasColumnName("SubastaSuspension");
           builder.Property(t => t.LanzamientoMotivoSuspension1).HasColumnName("MotivoSuspension");
           builder.Property(t => t.LanzamientoFecha2).HasColumnName("FechaCelebracionLanzamiento2");
           builder.Property(t => t.DocumentoSolicitudLanzamientoId).HasColumnName("DocumentoSolicitudLanzamientoId");
           builder.Property(t => t.DocumentoCelebracionLanzamientoId1).HasColumnName("DocumentoCelebracionLanzamientoId1");
           builder.Property(t => t.DocumentoCelebracionLanzamientoId2).HasColumnName("DocumentoCelebracionLanzamientoId2");
           builder.Property(t => t.DocumentoActaLanzamientoId).HasColumnName("DocumentoActaLanzamientoId");
           builder.Property(t => t.DocumentoMandamientoPagoId).HasColumnName("DocumentoMandamientoPagoId");
           builder.Property(t => t.DocumentoCesionRemateId).HasColumnName("DocumentoCesionRemateId");
           builder.Property(t => t.DocumentoLiquidacionInteresesId).HasColumnName("DocumentoLiquidacionInteresesId");
           builder.Property(t => t.Oposicion).HasColumnName("Oposicion");
           builder.Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
           builder.Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
           builder.Property(t => t.OposicionResolucionFecha).HasColumnName("OposicionResolucionFecha");
           builder.Property(t => t.OposicionDocumentoId).HasColumnName("OposicionDocumentoId");
           builder.Property(t => t.OposicionVistaDocumentoId).HasColumnName("OposicionVistaDocumentoId");
           builder.Property(t => t.OposicionResolucionDocumentoId).HasColumnName("OposicionResolucionDocumentoId");
           builder.Property(t => t.LanzamientoSuspensionFecha1).HasColumnName("SuspensionFecha");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumentoActa).WithMany(t => t.Alq_Expediente_EstadoLanzamiento).HasForeignKey(d => d.DocumentoSolicitudLanzamientoId);
            //HasOptional(t => t.ExpedienteDocumentoCelebracion1).WithMany(t => t.Alq_Expediente_EstadoLanzamiento1).HasForeignKey(d => d.DocumentoActaLanzamientoId);
            //HasOptional(t => t.ExpedienteDocumentoCelebracion2).WithMany(t => t.Alq_Expediente_EstadoLanzamiento2).HasForeignKey(d => d.DocumentoCelebracionLanzamientoId1);
            //HasOptional(t => t.ExpedienteDocumento3).WithMany(t => t.Alq_Expediente_EstadoLanzamiento3).HasForeignKey(d => d.DocumentoCelebracionLanzamientoId2);
            //HasOptional(t => t.ExpedienteDocumento4).WithMany(t => t.Alq_Expediente_EstadoLanzamiento4).HasForeignKey(d => d.DocumentoCesionRemateId);
            //HasOptional(t => t.ExpedienteDocumento5).WithMany(t => t.Alq_Expediente_EstadoLanzamiento5).HasForeignKey(d => d.DocumentoLiquidacionInteresesId);
            //HasOptional(t => t.ExpedienteDocumento6).WithMany(t => t.Alq_Expediente_EstadoLanzamiento6).HasForeignKey(d => d.DocumentoMandamientoPagoId);
            //HasOptional(t => t.ExpedienteDocumento7).WithMany(t => t.Alq_Expediente_EstadoLanzamiento7).HasForeignKey(d => d.OposicionDocumentoId);
            //HasOptional(t => t.ExpedienteDocumento8).WithMany(t => t.Alq_Expediente_EstadoLanzamiento8).HasForeignKey(d => d.OposicionResolucionDocumentoId);
            ////         //this.HasOptional(t => t.ExpedienteDocumento9).WithMany(t => t.Alq_Expediente_EstadoLanzamiento9).HasForeignKey(d => d.OposicionVistaDocumentoId);

            //HasRequired(t => t.ExpedienteEstado).WithOptional(t => t.Alq_Expediente_EstadoLanzamiento);

        }
    }
}
