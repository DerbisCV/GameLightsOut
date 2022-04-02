using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_Contratos_Deuda_LineasMap : EntityTypeConfiguration<Alq_Expediente_Contratos_Deuda_Lineas>
    {
        public Alq_Expediente_Contratos_Deuda_LineasMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            ToTable("Alq_Expediente_Contratos_Deuda_Lineas");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IdContrato).HasColumnName("IdContrato");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.BaseImponible).HasColumnName("BaseImponible");
            Property(t => t.IVA).HasColumnName("IVA");
            Property(t => t.Retencion).HasColumnName("Retencion");
            Property(t => t.TotalRenta).HasColumnName("TotalRenta");
            Property(t => t.Abonado).HasColumnName("Abonado");
            Property(t => t.Debido).HasColumnName("Debido");
            Property(t => t.PorcentajeIVA).HasColumnName("PorcentajeIVA");

            // Relationships
            HasOptional(t => t.Alq_Expediente_Contratos)
                .WithMany(t => t.Alq_Expediente_Contratos_Deuda_Lineas)
                .HasForeignKey(d => d.IdContrato);

        }
    }
}
