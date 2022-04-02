using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteAdministradorMap : EntityTypeConfiguration<Con_ExpedienteAdministrador>
    {
        public Con_ExpedienteAdministradorMap()
        {
            // Primary Key
            HasKey(t => t.IdAdministrador);

            // Properties
            // Table & Column Mappings
            ToTable("Con_ExpedienteAdministrador");
            Property(t => t.IdAdministrador).HasColumnName("IdAdministrador");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoAdministrador).HasColumnName("IdTipoAdministrador");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.Con_ExpedienteAdministrador)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Con_ExpedienteAdministrador)
                .HasForeignKey(d => d.IdPersona);

        }
    }
}
