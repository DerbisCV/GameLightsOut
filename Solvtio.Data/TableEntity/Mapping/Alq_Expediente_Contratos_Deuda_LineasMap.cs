using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_Contratos_Deuda_LineasMap : IEntityTypeConfiguration<Alq_Expediente_Contratos_Deuda_Lineas>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_Contratos_Deuda_Lineas> builder)
        {
            // 
           builder.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_Contratos_Deuda_Lineas");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.IdContrato).HasColumnName("IdContrato");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.BaseImponible).HasColumnName("BaseImponible");
           builder.Property(t => t.IVA).HasColumnName("IVA");
           builder.Property(t => t.Retencion).HasColumnName("Retencion");
           builder.Property(t => t.TotalRenta).HasColumnName("TotalRenta");
           builder.Property(t => t.Abonado).HasColumnName("Abonado");
           builder.Property(t => t.Debido).HasColumnName("Debido");
           builder.Property(t => t.PorcentajeIVA).HasColumnName("PorcentajeIVA");

            // Relationships
            //HasOptional(t => t.Alq_Expediente_Contratos)
            //    .WithMany(t => t.Alq_Expediente_Contratos_Deuda_Lineas)
            //    .HasForeignKey(d => d.IdContrato);

        }
    }
}
