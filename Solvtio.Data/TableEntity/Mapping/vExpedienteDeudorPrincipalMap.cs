using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vExpedienteDeudorPrincipalMap : EntityTypeConfiguration<vExpedienteDeudorPrincipal>
    {
        public vExpedienteDeudorPrincipalMap()
        {
            // Primary Key
            HasKey(t => new { t.IdExpediente, t.IdTipoDeudor });

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.IdTipoDeudor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("vExpedienteDeudorPrincipal");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
        }
    }
}
