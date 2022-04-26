using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteAccionMap : IEntityTypeConfiguration<ExpedienteAccion>
    {
   
            public void Configure(EntityTypeBuilder<ExpedienteAccion> builder) {
           builder.HasKey(t => t.IdExpedienteAccion);

            // Properties
           builder.Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("ExpedienteAccion");
           builder.Property(t => t.IdExpedienteAccion).HasColumnName("IdExpedienteAccion");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.IdTipoAccion).HasColumnName("IdTipoAccion");
           builder.Property(t => t.Observacion).HasColumnName("Observacion");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Hip_Expediente)
                //  .WithMany(t => t.ExpedienteAccions)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.TipoAccion)
                //  .WithMany(t => t.ExpedienteAccions)
                //  .HasForeignKey(d => d.IdTipoAccion);

        }
    }
}
