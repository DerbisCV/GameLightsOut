using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoFinalizacionMap : IEntityTypeConfiguration<Alq_Expediente_EstadoFinalizacion>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_EstadoFinalizacion> builder)
        {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_EstadoFinalizacion");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.PagoDeuda).HasColumnName("PagoDeuda");
           builder.Property(t => t.EntregaPosesion).HasColumnName("EntregaPosesion");
           builder.Property(t => t.DesestimacionDemanda).HasColumnName("DesestimacionDemanda");
           builder.Property(t => t.Llaves).HasColumnName("Llaves");
           builder.Property(t => t.EnervacionJudicial).HasColumnName("EnervacionJudicial");
           builder.Property(t => t.DesestimientoJudicial).HasColumnName("DesestimientoJudicial");
           builder.Property(t => t.PorAcuerdo).HasColumnName("PorAcuerdo");
           builder.Property(t => t.ParalizacionInstCliente).HasColumnName("ParalizacionInstCliente");
           builder.Property(t => t.Mediacion).HasColumnName("Mediacion");
           builder.Property(t => t.CondonacionSinProceso).HasColumnName("CondonacionSinProceso");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
            //    .WithOptional(t => t.Alq_Expediente_EstadoFinalizacion);

        }
    }
}
