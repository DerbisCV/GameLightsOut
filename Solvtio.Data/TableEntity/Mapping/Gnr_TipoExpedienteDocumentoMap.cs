using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoExpedienteDocumentoMap : EntityTypeConfiguration<Gnr_TipoExpedienteDocumento>
    {
        public Gnr_TipoExpedienteDocumentoMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoDocumento);

            // Properties
            Property(t => t.IdTipoDocumento)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Gnr_TipoExpedienteDocumento");
            Property(t => t.IdTipoDocumento).HasColumnName("IdTipoDocumento");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Inactivo).HasColumnName("Inactivo");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");

            // Relationships
            HasOptional(t => t.Gnr_TipoExpediente)
                .WithMany(t => t.Gnr_TipoExpedienteDocumento)
                .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
