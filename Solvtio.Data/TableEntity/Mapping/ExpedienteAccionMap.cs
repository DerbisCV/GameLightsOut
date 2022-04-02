using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteAccionMap : EntityTypeConfiguration<ExpedienteAccion>
    {
        public ExpedienteAccionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteAccion);

            // Properties
            Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ExpedienteAccion");
            Property(t => t.IdExpedienteAccion).HasColumnName("IdExpedienteAccion");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.IdTipoAccion).HasColumnName("IdTipoAccion");
            Property(t => t.Observacion).HasColumnName("Observacion");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Hip_Expediente)
                .WithMany(t => t.ExpedienteAccions)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.TipoAccion)
                .WithMany(t => t.ExpedienteAccions)
                .HasForeignKey(d => d.IdTipoAccion);

        }
    }
}
