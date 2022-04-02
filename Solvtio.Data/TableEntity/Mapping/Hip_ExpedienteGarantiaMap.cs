using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteGarantiaMap : EntityTypeConfiguration<Hip_ExpedienteGarantia>
    {
        public Hip_ExpedienteGarantiaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteGarantia);

            // Properties
            // Table & Column Mappings
            ToTable("Hip_ExpedienteGarantia");
            Property(t => t.IdExpedienteGarantia).HasColumnName("IdExpedienteGarantia");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.Descripcion).HasColumnName("Descripcion");

            // Relationships
            HasRequired(t => t.Hip_Expediente)
                .WithMany(t => t.Hip_ExpedienteGarantia)
                .HasForeignKey(d => d.IdExpediente);

        }
    }
}
