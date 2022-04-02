using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteAcreedoreMap : EntityTypeConfiguration<ExpedienteAcreedore>
    {
        public ExpedienteAcreedoreMap()
        {
            // Primary Key
            HasKey(t => t.IdExpAcreedor);

            // Properties
            Property(t => t.IdExpAcreedor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ExpedienteAcreedores");
            Property(t => t.IdExpAcreedor).HasColumnName("IdExpAcreedor");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoAcreedor).HasColumnName("IdTipoAcreedor");

            // Relationships
            HasOptional(t => t.Expediente)
                .WithMany(t => t.ExpedienteAcreedores)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.ExpedienteAcreedores)
                .HasForeignKey(d => d.IdPersona);

        }
    }
}
