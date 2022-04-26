using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoGarantiaOtrosMap : IEntityTypeConfiguration<Con_ExpedienteCreditoGarantiaOtros>
    {
           public void Configure(EntityTypeBuilder<Con_ExpedienteCreditoGarantiaOtros> builder) {
           builder.HasKey(t => t.IdExpedienteCreditoGarantiaOtros);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired();

           builder.Property(t => t.Lote)
                .HasMaxLength(10);

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteCreditoGarantiaOtros");
           builder.Property(t => t.IdExpedienteCreditoGarantiaOtros).HasColumnName("IdExpedienteCreditoGarantiaOtros");
           builder.Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Lote).HasColumnName("Lote");
           builder.Property(t => t.ImporteSubasta).HasColumnName("ImporteSubasta");
           builder.Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
           builder.Property(t => t.Adjudicado).HasColumnName("Adjudicado");
           builder.Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");

            // Relationships
            //HasRequired(t => t.Con_ExpedienteCredito)
            //    //  .WithMany(t => t.Con_ExpedienteCreditoGarantiaOtros)
            //    //  .HasForeignKey(d => d.IdExpedienteCredito);

        }
    }
}
