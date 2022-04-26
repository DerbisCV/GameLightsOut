using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaExpedienteMap : IEntityTypeConfiguration<Gnr_PersonaExpediente>
    {
    
            public void Configure(EntityTypeBuilder<Gnr_PersonaExpediente> builder) {
           builder.HasKey(t => t.IdPersonaExpediente);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Gnr_PersonaExpediente");
           builder.Property(t => t.IdPersonaExpediente).HasColumnName("IdPersonaExpediente");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.IdTipoPersona).HasColumnName("IdTipoPersona");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.FechaBaja).HasColumnName("FechaBaja");

            // Relationships
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.Gnr_PersonaExpediente)
                //  .HasForeignKey(d => d.IdPersona);
            //HasRequired(t => t.Gnr_TipoPersona)
                //  .WithMany(t => t.Gnr_PersonaExpediente)
                //  .HasForeignKey(d => d.IdTipoPersona);

        }
    }
}
