using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteDeudorMap : IEntityTypeConfiguration<ExpedienteDeudor>
    {
  
            public void Configure(EntityTypeBuilder<ExpedienteDeudor> builder) {
           builder.HasKey(t => t.IdExpedienteDeudor);

            // Properties
            // Table & Column Mappings
           builder.ToTable("ExpedienteDeudor");
           builder.Property(t => t.IdExpedienteDeudor).HasColumnName("IdExpedienteDeudor");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");
           builder.Property(t => t.DomicilioNotificacion).HasColumnName("DomicilioNotificacion");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.ExpedienteDeudors)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.ExpedienteDeudors)
                //  .HasForeignKey(d => d.IdPersona);
            //HasRequired(t => t.Gnr_TipoDeudor)
                //  .WithMany(t => t.ExpedienteDeudors)
                //  .HasForeignKey(d => d.IdTipoDeudor);

        }
    }
}
