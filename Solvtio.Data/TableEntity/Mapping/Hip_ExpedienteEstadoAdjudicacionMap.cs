using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoAdjudicacionMap : IEntityTypeConfiguration<Hip_ExpedienteEstadoAdjudicacion>
    {
        public Hip_ExpedienteEstadoAdjudicacionMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_ExpedienteEstadoAdjudicacion> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

           builder.Property(t => t.Nota)
                .HasMaxLength(2000);

            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoAdjudicacion");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
            //Property(t => t.DocumentoActaAdjudicacionId).HasColumnName("DocumentoActaAdjudicacionId");
           builder.Property(t => t.LiquidacionITP).HasColumnName("LiquidacionITP");
           builder.Property(t => t.FechaLiquidacionITP).HasColumnName("FechaLiquidacionITP");
            //Property(t => t.DocumentoLiquidacionITPId).HasColumnName("DocumentoLiquidacionITPId");
           builder.Property(t => t.FechaCertificadoInscripcion).HasColumnName("FechaCertificadoInscripcion");
            //Property(t => t.DocumentoCertificadoInscripcionId).HasColumnName("DocumentoCertificadoInscripcionId");
           builder.Property(t => t.FechaDiligenciaPosesion).HasColumnName("FechaDiligenciaPosesion");
            //Property(t => t.DocumentoDiligenciaPosesionId).HasColumnName("DocumentoDiligenciaPosesionId");
           builder.Property(t => t.Inquilinos).HasColumnName("Inquilinos");
           builder.Property(t => t.FechaLanzamiento).HasColumnName("FechaLanzamiento");
            //Property(t => t.DocumentoSolicitudLanzamientoId).HasColumnName("DocumentoSolicitudLanzamientoId");
           builder.Property(t => t.FechaEntregaLLaves).HasColumnName("FechaEntregaLLaves");
            //Property(t => t.DocumentoEntregaLLavesId).HasColumnName("DocumentoEntregaLLavesId");
           builder.Property(t => t.Defectos).HasColumnName("Defectos");
           builder.Property(t => t.Subsanado).HasColumnName("Subsanado");
           builder.Property(t => t.FechaSubsanado).HasColumnName("FechaSubsanado");
           builder.Property(t => t.FormaPacifica).HasColumnName("FormaPacifica");
           builder.Property(t => t.Ocupantes).HasColumnName("Ocupantes");
           builder.Property(t => t.FechaVista).HasColumnName("FechaVista");
           builder.Property(t => t.ContratoAlquiler).HasColumnName("ContratoAlquiler");
           builder.Property(t => t.FechaTestimonio).HasColumnName("FechaTestimonio");
            //Property(t => t.DocumentoTestimonioDecretoId).HasColumnName("DocumentoTestimonioDecretoId");
            //Property(t => t.DocumentoOcupantesId).HasColumnName("DocumentoOcupantesId");
            //Property(t => t.DocumentoVistaOcupantesId).HasColumnName("DocumentoVistaOcupantesId");
           builder.Property(t => t.Nota).HasColumnName("Nota");
           builder.Property(t => t.ObservacionesCertificadoInscripcion).HasColumnName("ObservacionesCertificadoInscripcion");
            //Property(t => t.FechaSolicitudPosesion).HasColumnName("FechaSolicitudPosesion");
           builder.Property(t => t.TituloJustificanteOcupacion).HasColumnName("TituloJustificanteOcupacion");
           builder.Property(t => t.DocumentacionOriginalRecibida).HasColumnName("DocumentacionOriginalRecibida");
           builder.Property(t => t.ObservacionesDocumentacionOriginal).HasColumnName("ObservacionesDocumentacionOriginal");
           builder.Property(t => t.ResultadoPosesion).HasColumnName("ResultadoPosesion");

            // Relationships
      
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Hip_ExpedienteEstadoAdjudicacion);

        }
    }
}
