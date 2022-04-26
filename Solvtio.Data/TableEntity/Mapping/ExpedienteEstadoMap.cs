using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteEstadoMap : IEntityTypeConfiguration<ExpedienteEstado>
    {
  
            public void Configure(EntityTypeBuilder<ExpedienteEstado> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("ExpedienteEstado");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
           builder.Property(t => t.Observacion).HasColumnName("Observacion");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.FechaFin).HasColumnName("FechaFin");
           builder.Property(t => t.ExpedienteEstadoIdSiguiente).HasColumnName("ExpedienteEstadoIdSiguiente");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.ExpedienteEstadoes)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.Gnr_TipoEstado)
                //  .WithMany(t => t.ExpedienteEstadoes)
                //  .HasForeignKey(d => d.IdTipoEstado);

        }
    }
}
