using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteDocumentoMap : EntityTypeConfiguration<ExpedienteDocumento>
    {
        public ExpedienteDocumentoMap()
        {
            // Primary Key
            HasKey(t => t.IdDocumento);

            // Properties
            Property(t => t.Ruta)
                .HasMaxLength(500);

            Property(t => t.DocumentoNombre)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ExpedienteDocumento");
            Property(t => t.IdDocumento).HasColumnName("IdDocumento");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdTipoDocumento).HasColumnName("IdTipoDocumento");
            Property(t => t.Ruta).HasColumnName("Ruta");
            Property(t => t.DocumentoNombre).HasColumnName("DocumentoNombre");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdReferencia).HasColumnName("IdReferencia");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.ExpedienteDocumentoes)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.Gnr_TipoExpedienteDocumento)
                .WithMany(t => t.ExpedienteDocumentoes)
                .HasForeignKey(d => d.IdTipoDocumento);

        }
    }
}
