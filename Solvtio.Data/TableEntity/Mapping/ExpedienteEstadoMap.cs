using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteEstadoMap : EntityTypeConfiguration<ExpedienteEstado>
    {
        public ExpedienteEstadoMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ExpedienteEstado");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
            Property(t => t.Observacion).HasColumnName("Observacion");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.FechaFin).HasColumnName("FechaFin");
            Property(t => t.ExpedienteEstadoIdSiguiente).HasColumnName("ExpedienteEstadoIdSiguiente");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.ExpedienteEstadoes)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.Gnr_TipoEstado)
                .WithMany(t => t.ExpedienteEstadoes)
                .HasForeignKey(d => d.IdTipoEstado);

        }
    }
}
