
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoLiquidacionLoteMap : IEntityTypeConfiguration<Con_ExpedienteEstadoLiquidacionLote>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteEstadoLiquidacionLote> builder)
        {
            builder.HasKey(t => t.IdLote);

            // Properties
            builder.Property(t => t.Lote)
                 .HasMaxLength(50);

            builder.Property(t => t.Referencia)
                 .HasMaxLength(50);

            builder.Property(t => t.Propiedad)
                 .HasMaxLength(500);

            // Table & Column Mappings
            builder.ToTable("Con_ExpedienteEstadoLiquidacionLote");
            builder.Property(t => t.IdLote).HasColumnName("IdLote");
            builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            builder.Property(t => t.Lote).HasColumnName("Lote");
            builder.Property(t => t.Referencia).HasColumnName("Referencia");
            builder.Property(t => t.FechaSubasta).HasColumnName("FechaSubasta");
            builder.Property(t => t.Propiedad).HasColumnName("Propiedad");
            builder.Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
            builder.Property(t => t.ImporteDeudaRemanente).HasColumnName("ImporteDeudaRemanente");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
            //  .WithMany(t => t.Con_ExpedienteEstadoLiquidacionLote)
            //  .HasForeignKey(d => d.ExpedienteEstadoId);

        }
    }
}
