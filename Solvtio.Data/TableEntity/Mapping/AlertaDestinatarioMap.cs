using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class AlertaDestinatarioMap : EntityTypeConfiguration<AlertaDestinatario>
    {
        public AlertaDestinatarioMap()
        {
            // Primary Key
            HasKey(t => t.IdPersona);

            // Properties
            Property(t => t.IdPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AlertaDestinatario");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdSupervisor).HasColumnName("IdSupervisor");
            Property(t => t.IsAdmin).HasColumnName("IsAdmin");

            // Relationships
            HasRequired(t => t.AlertaSupervisor)
                .WithMany(t => t.AlertaDestinatarios)
                .HasForeignKey(d => d.IdSupervisor);
            HasRequired(t => t.Gnr_Persona)
                .WithOptional(t => t.AlertaDestinatario);

        }
    }
}
