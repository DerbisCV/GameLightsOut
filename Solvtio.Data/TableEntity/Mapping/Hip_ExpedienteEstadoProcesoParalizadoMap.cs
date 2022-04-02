using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoProcesoParalizadoMap : EntityTypeConfiguration<Hip_ExpedienteEstadoProcesoParalizado>
    {
        public Hip_ExpedienteEstadoProcesoParalizadoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstadoParalizado);

            // Properties
            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoProcesoParalizado");
            Property(t => t.IdExpedienteEstadoParalizado).HasColumnName("IdExpedienteEstadoParalizado");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaParalizado).HasColumnName("FechaParalizado");
            Property(t => t.ImporteParalizado).HasColumnName("ImporteParalizado");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.IdMotivo).HasColumnName("IdMotivo");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithMany(t => t.Hip_ExpedienteEstadoProcesoParalizado)
                .HasForeignKey(d => d.ExpedienteEstadoId);
            HasOptional(t => t.Gnr_TipoEstadoMotivo)
                .WithMany(t => t.Hip_ExpedienteEstadoProcesoParalizado)
                .HasForeignKey(d => d.IdMotivo);

        }
    }
}
