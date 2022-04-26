using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class TipoExpedienteAccionMap : IEntityTypeConfiguration<TipoExpedienteAccion>
    {
        public TipoExpedienteAccionMap()
        {
           } public void Configure(EntityTypeBuilder<TipoExpedienteAccion> builder) {
           builder.HasKey(t => t.IdTipoExpedienteAccion);

            // Properties
            // Table & Column Mappings
           builder.ToTable("TipoExpedienteAccion");
           builder.Property(t => t.IdTipoExpedienteAccion).HasColumnName("IdTipoExpedienteAccion");
           builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
           builder.Property(t => t.IdTipoAccion).HasColumnName("IdTipoAccion");

            // Relationships
            //HasRequired(t => t.Gnr_TipoExpediente)
                //  .WithMany(t => t.TipoExpedienteAccions)
                //  .HasForeignKey(d => d.IdTipoExpediente);
            //HasRequired(t => t.TipoAccion)
                //  .WithMany(t => t.TipoExpedienteAccions)
                //  .HasForeignKey(d => d.IdTipoAccion);

        }
    }
}
