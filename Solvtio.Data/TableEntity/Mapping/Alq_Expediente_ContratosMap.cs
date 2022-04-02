using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_ContratosMap : EntityTypeConfiguration<Alq_Expediente_Contrato>
    {
        public Alq_Expediente_ContratosMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.EntidadOrigen)
                .HasMaxLength(100);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Alq_Expediente_Contratos");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.EntidadOrigen).HasColumnName("EntidadOrigen");
            Property(t => t.FechaContrato).HasColumnName("FechaContrato");
            Property(t => t.RentaInicial).HasColumnName("RentaInicial");
            Property(t => t.IdValorPeriodicidad).HasColumnName("IdValorPeriodicidad");
            Property(t => t.PlazoPago).HasColumnName("PlazoPago");
            Property(t => t.IdModalidadPago).HasColumnName("IdModalidadPago");
            Property(t => t.IdRevisionRentaIndice).HasColumnName("IdRevisionRentaIndice");
            Property(t => t.IdRevisionRentaPeriodicidad).HasColumnName("IdRevisionRentaPeriodicidad");
            Property(t => t.FechaPrimeraRevision).HasColumnName("FechaPrimeraRevision");
            Property(t => t.DeudaInicial).HasColumnName("DeudaInicial");
            Property(t => t.DeudaSatisfecha).HasColumnName("DeudaSatisfecha");
            Property(t => t.DeudaPendiente).HasColumnName("DeudaPendiente");
            Property(t => t.PlazosPago).HasColumnName("PlazosPago");
            Property(t => t.EstaCompleto).HasColumnName("EstaCompleto");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Alq_Expediente)
                .WithMany(t => t.Alq_Expediente_Contratos)
                .HasForeignKey(d => d.IdExpediente);
            HasOptional(t => t.Gnr_ListasValores_Valores)
                .WithMany(t => t.Alq_Expediente_Contratos)
                .HasForeignKey(d => d.IdModalidadPago);
            HasOptional(t => t.Gnr_ListasValores_Valores1)
                .WithMany(t => t.Alq_Expediente_Contratos1)
                .HasForeignKey(d => d.IdRevisionRentaIndice);
            HasOptional(t => t.Gnr_ListasValores_Valores2)
                .WithMany(t => t.Alq_Expediente_Contratos2)
                .HasForeignKey(d => d.IdRevisionRentaPeriodicidad);
            HasOptional(t => t.Gnr_ListasValores_Valores3)
                .WithMany(t => t.Alq_Expediente_Contratos3)
                .HasForeignKey(d => d.IdValorPeriodicidad);

        }
    }
}
