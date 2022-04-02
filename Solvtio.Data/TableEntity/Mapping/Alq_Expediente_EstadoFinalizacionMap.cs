using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoFinalizacionMap : EntityTypeConfiguration<Alq_Expediente_EstadoFinalizacion>
    {
        public Alq_Expediente_EstadoFinalizacionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Alq_Expediente_EstadoFinalizacion");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.PagoDeuda).HasColumnName("PagoDeuda");
            Property(t => t.EntregaPosesion).HasColumnName("EntregaPosesion");
            Property(t => t.DesestimacionDemanda).HasColumnName("DesestimacionDemanda");
            Property(t => t.Llaves).HasColumnName("Llaves");
            Property(t => t.EnervacionJudicial).HasColumnName("EnervacionJudicial");
            Property(t => t.DesestimientoJudicial).HasColumnName("DesestimientoJudicial");
            Property(t => t.PorAcuerdo).HasColumnName("PorAcuerdo");
            Property(t => t.ParalizacionInstCliente).HasColumnName("ParalizacionInstCliente");
            Property(t => t.Mediacion).HasColumnName("Mediacion");
            Property(t => t.CondonacionSinProceso).HasColumnName("CondonacionSinProceso");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Alq_Expediente_EstadoFinalizacion);

        }
    }
}
