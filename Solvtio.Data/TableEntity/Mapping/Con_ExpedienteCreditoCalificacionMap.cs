using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoCalificacionMap : EntityTypeConfiguration<Con_ExpedienteCreditoCalificacion>
    {
        public Con_ExpedienteCreditoCalificacionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteCreditoCalificacion);

            // Properties
            // Table & Column Mappings
            ToTable("Con_ExpedienteCreditoCalificacion");
            Property(t => t.IdExpedienteCreditoCalificacion).HasColumnName("IdExpedienteCreditoCalificacion");
            Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.IdTipoCalificacionCredito).HasColumnName("IdTipoCalificacionCredito");
            Property(t => t.IdTipoCalificacionCreditoTiempo).HasColumnName("IdTipoCalificacionCreditoTiempo");

            // Relationships
            HasRequired(t => t.Con_ExpedienteCredito)
                .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
                .HasForeignKey(d => d.IdExpedienteCredito);
            HasRequired(t => t.Con_TipoCalificacion)
                .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
                .HasForeignKey(d => d.IdTipoCalificacionCredito);
            HasRequired(t => t.Con_TipoCalificacionTiempo)
                .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
                .HasForeignKey(d => d.IdTipoCalificacionCreditoTiempo);
            HasRequired(t => t.TipoCalificacionCreditoTiempo)
                .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
                .HasForeignKey(d => d.IdTipoCalificacionCreditoTiempo);
            HasRequired(t => t.TipoClasificacionCredito)
                .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
                .HasForeignKey(d => d.IdTipoCalificacionCredito);

        }
    }
}
