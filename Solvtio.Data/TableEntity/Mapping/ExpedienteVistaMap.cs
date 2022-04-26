using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteVistaMap : IEntityTypeConfiguration<ExpedienteVista>
    {
   
            public void Configure(EntityTypeBuilder<ExpedienteVista> builder) {
           builder.HasKey(t => t.IdExpedienteVista);

            // Properties
            // Table & Column Mappings
           builder.ToTable("ExpedienteVista");
           builder.Property(t => t.IdExpedienteVista).HasColumnName("IdExpedienteVista");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdTipoVista).HasColumnName("IdTipoVista");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.ExpedienteVistas)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.TipoVista)
                //  .WithMany(t => t.ExpedienteVistas)
                //  .HasForeignKey(d => d.IdTipoVista);

        }
    }
}
