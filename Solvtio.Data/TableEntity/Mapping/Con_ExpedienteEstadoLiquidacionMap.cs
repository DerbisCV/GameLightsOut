using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoLiquidacionMap : EntityTypeConfiguration<Con_ExpedienteEstadoLiquidacion>
    {
        public Con_ExpedienteEstadoLiquidacionMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Con_ExpedienteEstadoLiquidacion");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaApertura).HasColumnName("FechaApertura");
            Property(t => t.PlanLiquidacion).HasColumnName("PlanLiquidacion");
            Property(t => t.FechaPlanLiquidacion).HasColumnName("FechaPlanLiquidacion");
            Property(t => t.SentenciaAprobandoConvenio).HasColumnName("SentenciaAprobandoConvenio");
            Property(t => t.FechaImpugnacion).HasColumnName("FechaImpugnacion");
            Property(t => t.DocumentoPlanLiquidacionId).HasColumnName("DocumentoPlanLiquidacionId");
            Property(t => t.DocumentoImpugnacionId).HasColumnName("DocumentoImpugnacionId");
            Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");
            Property(t => t.DocumentoEdictoSubastaId).HasColumnName("DocumentoEdictoSubastaId");
            Property(t => t.FechaAprobacionPlanLiquidacion).HasColumnName("FechaAprobacionPlanLiquidacion");

            // Relationships
            HasOptional(t => t.ExpedienteDocumento)
                .WithMany(t => t.Con_ExpedienteEstadoLiquidacion)
                .HasForeignKey(d => d.DocumentoPlanLiquidacionId);
            HasOptional(t => t.ExpedienteDocumento1)
                .WithMany(t => t.Con_ExpedienteEstadoLiquidacion1)
                .HasForeignKey(d => d.DocumentoImpugnacionId);
            HasOptional(t => t.ExpedienteDocumento2)
                .WithMany(t => t.Con_ExpedienteEstadoLiquidacion2)
                .HasForeignKey(d => d.DocumentoEdictoSubastaId);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Con_ExpedienteEstadoLiquidacion);

        }
    }
}
