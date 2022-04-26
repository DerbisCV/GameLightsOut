
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_ContratosMap : IEntityTypeConfiguration<Alq_Expediente_Contrato>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_Contrato> builder)
        {
            // public void Configure(EntityTypeBuilder<object> builder)
            builder.HasKey(t => t.ID);

            // Properties
            builder.Property(t => t.EntidadOrigen)
                 .HasMaxLength(100);

            builder.Property(t => t.Usuario)
                 .HasMaxLength(50);

            // Table & Column Mappings
            builder.ToTable("Alq_Expediente_Contratos");
            builder.Property(t => t.ID).HasColumnName("ID");
            builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            builder.Property(t => t.EntidadOrigen).HasColumnName("EntidadOrigen");
            builder.Property(t => t.FechaContrato).HasColumnName("FechaContrato");
            builder.Property(t => t.RentaInicial).HasColumnName("RentaInicial");
            builder.Property(t => t.IdValorPeriodicidad).HasColumnName("IdValorPeriodicidad");
            builder.Property(t => t.PlazoPago).HasColumnName("PlazoPago");
            builder.Property(t => t.IdModalidadPago).HasColumnName("IdModalidadPago");
            builder.Property(t => t.IdRevisionRentaIndice).HasColumnName("IdRevisionRentaIndice");
            builder.Property(t => t.IdRevisionRentaPeriodicidad).HasColumnName("IdRevisionRentaPeriodicidad");
            builder.Property(t => t.FechaPrimeraRevision).HasColumnName("FechaPrimeraRevision");
            builder.Property(t => t.DeudaInicial).HasColumnName("DeudaInicial");
            builder.Property(t => t.DeudaSatisfecha).HasColumnName("DeudaSatisfecha");
            builder.Property(t => t.DeudaPendiente).HasColumnName("DeudaPendiente");
            builder.Property(t => t.PlazosPago).HasColumnName("PlazosPago");
            builder.Property(t => t.EstaCompleto).HasColumnName("EstaCompleto");
            builder.Property(t => t.Usuario).HasColumnName("Usuario");
            builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Alq_Expediente)
            //    .WithMany(t => t.Alq_Expediente_Contratos)
            //    .HasForeignKey(d => d.IdExpediente);
            //HasOptional(t => t.Gnr_ListasValores_Valores)
            //    .WithMany(t => t.Alq_Expediente_Contratos)
            //    .HasForeignKey(d => d.IdModalidadPago);
            //HasOptional(t => t.Gnr_ListasValores_Valores1)
            //    .WithMany(t => t.Alq_Expediente_Contratos1)
            //    .HasForeignKey(d => d.IdRevisionRentaIndice);
            //HasOptional(t => t.Gnr_ListasValores_Valores2)
            //    .WithMany(t => t.Alq_Expediente_Contratos2)
            //    .HasForeignKey(d => d.IdRevisionRentaPeriodicidad);
            //HasOptional(t => t.Gnr_ListasValores_Valores3)
            //    .WithMany(t => t.Alq_Expediente_Contratos3)
            //    .HasForeignKey(d => d.IdValorPeriodicidad);

        }
    }
}
