using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteGastoMap : EntityTypeConfiguration<ExpedienteGasto>
    {
        public ExpedienteGastoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteGasto);

            // Properties
            Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ExpedienteGasto");
            Property(t => t.IdExpedienteGasto).HasColumnName("IdExpedienteGasto");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.Importe).HasColumnName("Importe");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.ExpedienteGastoes)
                .HasForeignKey(d => d.IdExpediente);

        }
    }
}
