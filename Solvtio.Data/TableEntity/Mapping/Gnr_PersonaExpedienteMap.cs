using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaExpedienteMap : EntityTypeConfiguration<Gnr_PersonaExpediente>
    {
        public Gnr_PersonaExpedienteMap()
        {
            // Primary Key
            HasKey(t => t.IdPersonaExpediente);

            // Properties
            // Table & Column Mappings
            ToTable("Gnr_PersonaExpediente");
            Property(t => t.IdPersonaExpediente).HasColumnName("IdPersonaExpediente");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoPersona).HasColumnName("IdTipoPersona");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.FechaBaja).HasColumnName("FechaBaja");

            // Relationships
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Gnr_PersonaExpediente)
                .HasForeignKey(d => d.IdPersona);
            HasRequired(t => t.Gnr_TipoPersona)
                .WithMany(t => t.Gnr_PersonaExpediente)
                .HasForeignKey(d => d.IdTipoPersona);

        }
    }
}
