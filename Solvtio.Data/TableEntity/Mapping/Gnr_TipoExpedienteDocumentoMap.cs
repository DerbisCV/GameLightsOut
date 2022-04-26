using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoExpedienteDocumentoMap : IEntityTypeConfiguration<Gnr_TipoExpedienteDocumento>
    {
        public Gnr_TipoExpedienteDocumentoMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoExpedienteDocumento> builder) {
           builder.HasKey(t => t.IdTipoDocumento);

            // Properties
           builder.Property(t => t.IdTipoDocumento)
                .ValueGeneratedNever();

           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoExpedienteDocumento");
           builder.Property(t => t.IdTipoDocumento).HasColumnName("IdTipoDocumento");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Inactivo).HasColumnName("Inactivo");
           builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");

            // Relationships
            // HasOptional(t => t.Gnr_TipoExpediente)
                //  .WithMany(t => t.Gnr_TipoExpedienteDocumento)
                //  .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
