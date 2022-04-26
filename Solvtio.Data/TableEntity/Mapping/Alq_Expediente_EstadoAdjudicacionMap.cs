using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoAdjudicacionMap : IEntityTypeConfiguration<Alq_Expediente_EstadoAdjudicacion>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_EstadoAdjudicacion> builder)
        {
            // public void Configure(EntityTypeBuilder<object> builder)
            builder.HasKey(t => t.IdExpedienteEstado);
            
            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
            builder.ToTable("Alq_Expediente_EstadoAdjudicacion");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
           builder.Property(t => t.LiquidacionITP).HasColumnName("LiquidacionITP");
           builder.Property(t => t.FechaLiquidacionITP).HasColumnName("FechaLiquidacionITP");
           builder.Property(t => t.FechaCertificadoInscripcion).HasColumnName("FechaCertificadoInscripcion");
           builder.Property(t => t.FechaDiligenciaPosesion).HasColumnName("FechaDiligenciaPosesion");
           builder.Property(t => t.FormaPacifica).HasColumnName("FormaPacifica");
           builder.Property(t => t.Inquilinos).HasColumnName("Inquilinos");
           builder.Property(t => t.Ocupantes).HasColumnName("Ocupantes");
           builder.Property(t => t.FechaLanzamiento).HasColumnName("FechaLanzamiento");
           builder.Property(t => t.FechaEntregaLLaves).HasColumnName("FechaEntregaLLaves");
           builder.Property(t => t.ContratoAlquiler).HasColumnName("ContratoAlquiler");
           builder.Property(t => t.Defectos).HasColumnName("Defectos");
           builder.Property(t => t.Subsanado).HasColumnName("Subsanado");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
            //    .WithOptional(t => t.Alq_Expediente_EstadoAdjudicacion);

        }
    }
}
