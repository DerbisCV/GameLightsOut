using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoAdjudicacionMap : EntityTypeConfiguration<Hip_ExpedienteEstadoAdjudicacion>
    {
        public Hip_ExpedienteEstadoAdjudicacionMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Nota)
                .HasMaxLength(2000);

            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoAdjudicacion");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
            //Property(t => t.DocumentoActaAdjudicacionId).HasColumnName("DocumentoActaAdjudicacionId");
            Property(t => t.LiquidacionITP).HasColumnName("LiquidacionITP");
            Property(t => t.FechaLiquidacionITP).HasColumnName("FechaLiquidacionITP");
            //Property(t => t.DocumentoLiquidacionITPId).HasColumnName("DocumentoLiquidacionITPId");
            Property(t => t.FechaCertificadoInscripcion).HasColumnName("FechaCertificadoInscripcion");
            //Property(t => t.DocumentoCertificadoInscripcionId).HasColumnName("DocumentoCertificadoInscripcionId");
            Property(t => t.FechaDiligenciaPosesion).HasColumnName("FechaDiligenciaPosesion");
            //Property(t => t.DocumentoDiligenciaPosesionId).HasColumnName("DocumentoDiligenciaPosesionId");
            Property(t => t.Inquilinos).HasColumnName("Inquilinos");
            Property(t => t.FechaLanzamiento).HasColumnName("FechaLanzamiento");
            //Property(t => t.DocumentoSolicitudLanzamientoId).HasColumnName("DocumentoSolicitudLanzamientoId");
            Property(t => t.FechaEntregaLLaves).HasColumnName("FechaEntregaLLaves");
            //Property(t => t.DocumentoEntregaLLavesId).HasColumnName("DocumentoEntregaLLavesId");
            Property(t => t.Defectos).HasColumnName("Defectos");
            Property(t => t.Subsanado).HasColumnName("Subsanado");
            Property(t => t.FechaSubsanado).HasColumnName("FechaSubsanado");
            Property(t => t.FormaPacifica).HasColumnName("FormaPacifica");
            Property(t => t.Ocupantes).HasColumnName("Ocupantes");
            Property(t => t.FechaVista).HasColumnName("FechaVista");
            Property(t => t.ContratoAlquiler).HasColumnName("ContratoAlquiler");
            Property(t => t.FechaTestimonio).HasColumnName("FechaTestimonio");
            //Property(t => t.DocumentoTestimonioDecretoId).HasColumnName("DocumentoTestimonioDecretoId");
            //Property(t => t.DocumentoOcupantesId).HasColumnName("DocumentoOcupantesId");
            //Property(t => t.DocumentoVistaOcupantesId).HasColumnName("DocumentoVistaOcupantesId");
            Property(t => t.Nota).HasColumnName("Nota");
            Property(t => t.ObservacionesCertificadoInscripcion).HasColumnName("ObservacionesCertificadoInscripcion");
            //Property(t => t.FechaSolicitudPosesion).HasColumnName("FechaSolicitudPosesion");
            Property(t => t.TituloJustificanteOcupacion).HasColumnName("TituloJustificanteOcupacion");
            Property(t => t.DocumentacionOriginalRecibida).HasColumnName("DocumentacionOriginalRecibida");
            Property(t => t.ObservacionesDocumentacionOriginal).HasColumnName("ObservacionesDocumentacionOriginal");
            Property(t => t.ResultadoPosesion).HasColumnName("ResultadoPosesion");

            // Relationships
      
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Hip_ExpedienteEstadoAdjudicacion);

        }
    }
}
