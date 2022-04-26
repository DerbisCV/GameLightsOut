using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoAdjudicacionMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoAdjudicacion>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoAdjudicacion> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoAdjudicacion");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
           builder.Property(t => t.FechaPosesion).HasColumnName("FechaPosesion");
           builder.Property(t => t.FechaTestimonio).HasColumnName("FechaTestimonio");
           builder.Property(t => t.FechaLanzamiento).HasColumnName("FechaLanzamiento");
           builder.Property(t => t.FechaLiquidacionITP).HasColumnName("FechaLiquidacionITP");
           builder.Property(t => t.FechaEntregaLLaves).HasColumnName("FechaEntregaLLaves");
           builder.Property(t => t.FechaInscripcionAdjudicacion).HasColumnName("FechaInscripcionAdjudicacion");
           builder.Property(t => t.FormaPacifica).HasColumnName("FormaPacifica");
           builder.Property(t => t.Defectos).HasColumnName("Defectos");
           builder.Property(t => t.Inquilinos).HasColumnName("Inquilinos");
           builder.Property(t => t.Subsanado).HasColumnName("Subsanado");
           builder.Property(t => t.Ocupantes).HasColumnName("Ocupantes");
           builder.Property(t => t.LiquidacionITP).HasColumnName("LiquidacionITP");
           builder.Property(t => t.ContratoAlquiler).HasColumnName("ContratoAlquiler");
           builder.Property(t => t.IdDocumentoDecretoAdjudicacion).HasColumnName("IdDocumentoDecretoAdjudicacion");
           builder.Property(t => t.IdDocumentoTestimonio).HasColumnName("IdDocumentoTestimonio");
           builder.Property(t => t.IdDocumentoITP).HasColumnName("IdDocumentoITP");
           builder.Property(t => t.IdDocumentoInscripcion).HasColumnName("IdDocumentoInscripcion");
           builder.Property(t => t.IdDocumentoPosesion).HasColumnName("IdDocumentoPosesion");
           builder.Property(t => t.IdDocumentoOcupantes).HasColumnName("IdDocumentoOcupantes");
           builder.Property(t => t.IdDocumentoOcupantesVista).HasColumnName("IdDocumentoOcupantesVista");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)//  .WithOptional(t => t.Ejc_ExpedienteEstadoAdjudicacion);

            //// HasOptional(t => t.ExpedienteDocumentoDecretoAdjudicacion)//  .WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion)//  .HasForeignKey(d => d.IdDocumentoDecretoAdjudicacion);
            //// HasOptional(t => t.ExpedienteDocumentoInscripcion)//  .WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion1)//  .HasForeignKey(d => d.IdDocumentoInscripcion);
            //// HasOptional(t => t.ExpedienteDocumentoITP)//  .WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion2)//  .HasForeignKey(d => d.IdDocumentoITP);
            //// HasOptional(t => t.ExpedienteDocumentoOcupantes)//  .WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion3)//  .HasForeignKey(d => d.IdDocumentoOcupantes);
            //// HasOptional(t => t.ExpedienteDocumentoOcupantesVista)//  .WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion4)//  .HasForeignKey(d => d.IdDocumentoOcupantesVista);
            //// HasOptional(t => t.ExpedienteDocumentoPosesion)//  .WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion5)//  .HasForeignKey(d => d.IdDocumentoPosesion);
            //// HasOptional(t => t.ExpedienteDocumentoTestimonio)//  .WithMany(t => t.Ejc_ExpedienteEstadoAdjudicacion6)//  .HasForeignKey(d => d.IdDocumentoTestimonio);

        }
    }
}
