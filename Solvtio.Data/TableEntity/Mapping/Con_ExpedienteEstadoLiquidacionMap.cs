using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoLiquidacionMap : IEntityTypeConfiguration<Con_ExpedienteEstadoLiquidacion>
    {

            public void Configure(EntityTypeBuilder<Con_ExpedienteEstadoLiquidacion> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteEstadoLiquidacion");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaApertura).HasColumnName("FechaApertura");
           builder.Property(t => t.PlanLiquidacion).HasColumnName("PlanLiquidacion");
           builder.Property(t => t.FechaPlanLiquidacion).HasColumnName("FechaPlanLiquidacion");
           builder.Property(t => t.SentenciaAprobandoConvenio).HasColumnName("SentenciaAprobandoConvenio");
           builder.Property(t => t.FechaImpugnacion).HasColumnName("FechaImpugnacion");
           builder.Property(t => t.DocumentoPlanLiquidacionId).HasColumnName("DocumentoPlanLiquidacionId");
           builder.Property(t => t.DocumentoImpugnacionId).HasColumnName("DocumentoImpugnacionId");
           builder.Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");
           builder.Property(t => t.DocumentoEdictoSubastaId).HasColumnName("DocumentoEdictoSubastaId");
           builder.Property(t => t.FechaAprobacionPlanLiquidacion).HasColumnName("FechaAprobacionPlanLiquidacion");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoLiquidacion)
            //    //  .HasForeignKey(d => d.DocumentoPlanLiquidacionId);
            //HasOptional(t => t.ExpedienteDocumento1)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoLiquidacion1)
            //    //  .HasForeignKey(d => d.DocumentoImpugnacionId);
            //HasOptional(t => t.ExpedienteDocumento2)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoLiquidacion2)
            //    //  .HasForeignKey(d => d.DocumentoEdictoSubastaId);
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Con_ExpedienteEstadoLiquidacion);

        }
    }
}
