using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteVistaMap : EntityTypeConfiguration<ExpedienteVista>
    {
        public ExpedienteVistaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteVista);

            // Properties
            // Table & Column Mappings
            ToTable("ExpedienteVista");
            Property(t => t.IdExpedienteVista).HasColumnName("IdExpedienteVista");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdTipoVista).HasColumnName("IdTipoVista");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.Observaciones).HasColumnName("Observaciones");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.ExpedienteVistas)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.TipoVista)
                .WithMany(t => t.ExpedienteVistas)
                .HasForeignKey(d => d.IdTipoVista);

        }
    }
}
