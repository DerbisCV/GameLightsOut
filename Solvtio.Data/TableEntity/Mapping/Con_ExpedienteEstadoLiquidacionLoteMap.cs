using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoLiquidacionLoteMap : EntityTypeConfiguration<Con_ExpedienteEstadoLiquidacionLote>
    {
        public Con_ExpedienteEstadoLiquidacionLoteMap()
        {
            // Primary Key
            HasKey(t => t.IdLote);

            // Properties
            Property(t => t.Lote)
                .HasMaxLength(50);

            Property(t => t.Referencia)
                .HasMaxLength(50);

            Property(t => t.Propiedad)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Con_ExpedienteEstadoLiquidacionLote");
            Property(t => t.IdLote).HasColumnName("IdLote");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.Lote).HasColumnName("Lote");
            Property(t => t.Referencia).HasColumnName("Referencia");
            Property(t => t.FechaSubasta).HasColumnName("FechaSubasta");
            Property(t => t.Propiedad).HasColumnName("Propiedad");
            Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
            Property(t => t.ImporteDeudaRemanente).HasColumnName("ImporteDeudaRemanente");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithMany(t => t.Con_ExpedienteEstadoLiquidacionLote)
                .HasForeignKey(d => d.ExpedienteEstadoId);

        }
    }
}
