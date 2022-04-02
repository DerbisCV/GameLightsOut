using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class AlertaSupervisorMap : EntityTypeConfiguration<AlertaSupervisor>
    {
        public AlertaSupervisorMap()
        {
            // Primary Key
            HasKey(t => t.IdPersona);

            // Properties
            Property(t => t.IdPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Departamento)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("AlertaSupervisor");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.Departamento).HasColumnName("Departamento");
            Property(t => t.EsEjecutivo).HasColumnName("EsEjecutivo");

            // Relationships
            HasRequired(t => t.Gnr_Persona)
                .WithOptional(t => t.AlertaSupervisor);

        }
    }
}
