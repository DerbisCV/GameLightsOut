using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoAdjudicacionMap : EntityTypeConfiguration<Alq_Expediente_EstadoAdjudicacion>
    {
        public Alq_Expediente_EstadoAdjudicacionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Alq_Expediente_EstadoAdjudicacion");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");
            Property(t => t.LiquidacionITP).HasColumnName("LiquidacionITP");
            Property(t => t.FechaLiquidacionITP).HasColumnName("FechaLiquidacionITP");
            Property(t => t.FechaCertificadoInscripcion).HasColumnName("FechaCertificadoInscripcion");
            Property(t => t.FechaDiligenciaPosesion).HasColumnName("FechaDiligenciaPosesion");
            Property(t => t.FormaPacifica).HasColumnName("FormaPacifica");
            Property(t => t.Inquilinos).HasColumnName("Inquilinos");
            Property(t => t.Ocupantes).HasColumnName("Ocupantes");
            Property(t => t.FechaLanzamiento).HasColumnName("FechaLanzamiento");
            Property(t => t.FechaEntregaLLaves).HasColumnName("FechaEntregaLLaves");
            Property(t => t.ContratoAlquiler).HasColumnName("ContratoAlquiler");
            Property(t => t.Defectos).HasColumnName("Defectos");
            Property(t => t.Subsanado).HasColumnName("Subsanado");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Alq_Expediente_EstadoAdjudicacion);

        }
    }
}
