using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoCalificacionMap : IEntityTypeConfiguration<Con_ExpedienteCreditoCalificacion>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteCreditoCalificacion> builder) {
           builder.HasKey(t => t.IdExpedienteCreditoCalificacion);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteCreditoCalificacion");
           builder.Property(t => t.IdExpedienteCreditoCalificacion).HasColumnName("IdExpedienteCreditoCalificacion");
           builder.Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.IdTipoCalificacionCredito).HasColumnName("IdTipoCalificacionCredito");
           builder.Property(t => t.IdTipoCalificacionCreditoTiempo).HasColumnName("IdTipoCalificacionCreditoTiempo");

            // Relationships
            //HasRequired(t => t.Con_ExpedienteCredito)
            //    .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
            //    .HasForeignKey(d => d.IdExpedienteCredito);
            //HasRequired(t => t.Con_TipoCalificacion)
            //    .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
            //    .HasForeignKey(d => d.IdTipoCalificacionCredito);
            //HasRequired(t => t.Con_TipoCalificacionTiempo)
            //    .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
            //    .HasForeignKey(d => d.IdTipoCalificacionCreditoTiempo);
            //HasRequired(t => t.TipoCalificacionCreditoTiempo)
            //    .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
            //    .HasForeignKey(d => d.IdTipoCalificacionCreditoTiempo);
            //HasRequired(t => t.TipoClasificacionCredito)
            //    .WithMany(t => t.Con_ExpedienteCreditoCalificacion)
            //    .HasForeignKey(d => d.IdTipoCalificacionCredito);

        }
    }
}
