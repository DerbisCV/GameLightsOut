using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoAdjudicacionMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoAdjudicacion>
    {
        public Ejc_ExpedienteEstadoAdjudicacionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoAdjudicacion");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
            Property(t => t.FechaPosesion).HasColumnName("FechaPosesion");
            Property(t => t.FechaTestimonio).HasColumnName("FechaTestimonio");
            Property(t => t.FechaLanzamiento).HasColumnName("FechaLanzamiento");
            Property(t => t.FechaLiquidacionITP).HasColumnName("FechaLiquidacionITP");
            Property(t => t.FechaEntregaLLaves).HasColumnName("FechaEntregaLLaves");
            Property(t => t.FechaInscripcionAdjudicacion).HasColumnName("FechaInscripcionAdjudicacion");
            Property(t => t.FormaPacifica).HasColumnName("FormaPacifica");
            Property(t => t.Defectos).HasColumnName("Defectos");
            Property(t => t.Inquilinos).HasColumnName("Inquilinos");
            Property(t => t.Subsanado).HasColumnName("Subsanado");
            Property(t => t.Ocupantes).HasColumnName("Ocupantes");
            Property(t => t.LiquidacionITP).HasColumnName("LiquidacionITP");
            Property(t => t.ContratoAlquiler).HasColumnName("ContratoAlquiler");
            Property(t => t.IdDocumentoDecretoAdjudicacion).HasColumnName("IdDocumentoDecretoAdjudicacion");
            Property(t => t.IdDocumentoTestimonio).HasColumnName("IdDocumentoTestimonio");
            Property(t => t.IdDocumentoITP).HasColumnName("IdDocumentoITP");
            Property(t => t.IdDocumentoInscripcion).HasColumnName("IdDocumentoInscripcion");
            Property(t => t.IdDocumentoPosesion).HasColumnName("IdDocumentoPosesion");
            Property(t => t.IdDocumentoOcupantes).HasColumnName("IdDocumentoOcupantes");
            Property(t => t.IdDocumentoOcupantesVista).HasColumnName("IdDocumentoOcupantesVista");

            // Relationships
            HasRequired(t => t.ExpedienteEstado).WithOptional(t => t.Ejc_ExpedienteEstadoAdjudicacion);

            HasOptional(t => t.ExpedienteDocumentoDecretoAdjudicacion).WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion).HasForeignKey(d => d.IdDocumentoDecretoAdjudicacion);
            HasOptional(t => t.ExpedienteDocumentoInscripcion).WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion1).HasForeignKey(d => d.IdDocumentoInscripcion);
            HasOptional(t => t.ExpedienteDocumentoITP).WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion2).HasForeignKey(d => d.IdDocumentoITP);
            HasOptional(t => t.ExpedienteDocumentoOcupantes).WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion3).HasForeignKey(d => d.IdDocumentoOcupantes);
            HasOptional(t => t.ExpedienteDocumentoOcupantesVista).WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion4).HasForeignKey(d => d.IdDocumentoOcupantesVista);
            HasOptional(t => t.ExpedienteDocumentoPosesion).WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion5).HasForeignKey(d => d.IdDocumentoPosesion);
            HasOptional(t => t.ExpedienteDocumentoTestimonio).WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion6).HasForeignKey(d => d.IdDocumentoTestimonio);

        }
    }
}
