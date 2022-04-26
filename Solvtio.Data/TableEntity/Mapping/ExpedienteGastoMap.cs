using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteGastoMap : IEntityTypeConfiguration<ExpedienteGasto>
    {
  
            public void Configure(EntityTypeBuilder<ExpedienteGasto> builder) {
           builder.HasKey(t => t.IdExpedienteGasto);

            // Properties
           builder.Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("ExpedienteGasto");
           builder.Property(t => t.IdExpedienteGasto).HasColumnName("IdExpedienteGasto");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.Importe).HasColumnName("Importe");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.ExpedienteGastoes)
                //  .HasForeignKey(d => d.IdExpediente);

        }
    }
}
