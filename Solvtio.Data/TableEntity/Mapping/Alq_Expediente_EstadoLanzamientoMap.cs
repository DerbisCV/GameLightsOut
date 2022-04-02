using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoLanzamientoMap : EntityTypeConfiguration<Alq_Expediente_EstadoLanzamiento>
    {
        public Alq_Expediente_EstadoLanzamientoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Autorizado)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Alq_Expediente_EstadoLanzamiento");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.FechaSolicitudLanzamiento).HasColumnName("FechaSolicitudLanzamiento");
            Property(t => t.LanzamientoFecha1).HasColumnName("FechaCelebracionLanzamiento1");
            Property(t => t.Autorizado).HasColumnName("Autorizado");
            Property(t => t.FechaEnvioInstruccionesProcurador).HasColumnName("FechaEnvioInstruccionesProcurador");
            Property(t => t.LanzamientoSuspension1).HasColumnName("SubastaSuspension");
            Property(t => t.LanzamientoMotivoSuspension1).HasColumnName("MotivoSuspension");
            Property(t => t.LanzamientoFecha2).HasColumnName("FechaCelebracionLanzamiento2");
            Property(t => t.DocumentoSolicitudLanzamientoId).HasColumnName("DocumentoSolicitudLanzamientoId");
            Property(t => t.DocumentoCelebracionLanzamientoId1).HasColumnName("DocumentoCelebracionLanzamientoId1");
            Property(t => t.DocumentoCelebracionLanzamientoId2).HasColumnName("DocumentoCelebracionLanzamientoId2");
            Property(t => t.DocumentoActaLanzamientoId).HasColumnName("DocumentoActaLanzamientoId");
            Property(t => t.DocumentoMandamientoPagoId).HasColumnName("DocumentoMandamientoPagoId");
            Property(t => t.DocumentoCesionRemateId).HasColumnName("DocumentoCesionRemateId");
            Property(t => t.DocumentoLiquidacionInteresesId).HasColumnName("DocumentoLiquidacionInteresesId");
            Property(t => t.Oposicion).HasColumnName("Oposicion");
            Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
            Property(t => t.OposicionResolucionFecha).HasColumnName("OposicionResolucionFecha");
            Property(t => t.OposicionDocumentoId).HasColumnName("OposicionDocumentoId");
            Property(t => t.OposicionVistaDocumentoId).HasColumnName("OposicionVistaDocumentoId");
            Property(t => t.OposicionResolucionDocumentoId).HasColumnName("OposicionResolucionDocumentoId");
            Property(t => t.LanzamientoSuspensionFecha1).HasColumnName("SuspensionFecha");

            // Relationships
            HasOptional(t => t.ExpedienteDocumentoActa).WithMany(t => t.Alq_Expediente_EstadoLanzamiento).HasForeignKey(d => d.DocumentoSolicitudLanzamientoId);
            HasOptional(t => t.ExpedienteDocumentoCelebracion1).WithMany(t => t.Alq_Expediente_EstadoLanzamiento1).HasForeignKey(d => d.DocumentoActaLanzamientoId);
            HasOptional(t => t.ExpedienteDocumentoCelebracion2).WithMany(t => t.Alq_Expediente_EstadoLanzamiento2).HasForeignKey(d => d.DocumentoCelebracionLanzamientoId1);
            HasOptional(t => t.ExpedienteDocumento3).WithMany(t => t.Alq_Expediente_EstadoLanzamiento3).HasForeignKey(d => d.DocumentoCelebracionLanzamientoId2);
            HasOptional(t => t.ExpedienteDocumento4).WithMany(t => t.Alq_Expediente_EstadoLanzamiento4).HasForeignKey(d => d.DocumentoCesionRemateId);
            HasOptional(t => t.ExpedienteDocumento5).WithMany(t => t.Alq_Expediente_EstadoLanzamiento5).HasForeignKey(d => d.DocumentoLiquidacionInteresesId);
            HasOptional(t => t.ExpedienteDocumento6).WithMany(t => t.Alq_Expediente_EstadoLanzamiento6).HasForeignKey(d => d.DocumentoMandamientoPagoId);
            HasOptional(t => t.ExpedienteDocumento7).WithMany(t => t.Alq_Expediente_EstadoLanzamiento7).HasForeignKey(d => d.OposicionDocumentoId);
            HasOptional(t => t.ExpedienteDocumento8).WithMany(t => t.Alq_Expediente_EstadoLanzamiento8).HasForeignKey(d => d.OposicionResolucionDocumentoId);
            //         //this.HasOptional(t => t.ExpedienteDocumento9).WithMany(t => t.Alq_Expediente_EstadoLanzamiento9).HasForeignKey(d => d.OposicionVistaDocumentoId);

            HasRequired(t => t.ExpedienteEstado).WithOptional(t => t.Alq_Expediente_EstadoLanzamiento);

        }
    }
}
