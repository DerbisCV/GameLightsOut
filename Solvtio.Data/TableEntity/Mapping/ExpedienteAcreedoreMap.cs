using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteAcreedoreMap : IEntityTypeConfiguration<ExpedienteAcreedore>
    {
    
            public void Configure(EntityTypeBuilder<ExpedienteAcreedore> builder) {
           builder.HasKey(t => t.IdExpAcreedor);

            // Properties
           builder.Property(t => t.IdExpAcreedor)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("ExpedienteAcreedores");
           builder.Property(t => t.IdExpAcreedor).HasColumnName("IdExpAcreedor");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.IdTipoAcreedor).HasColumnName("IdTipoAcreedor");

            // Relationships
            // HasOptional(t => t.Expediente)
                //  .WithMany(t => t.ExpedienteAcreedores)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.ExpedienteAcreedores)
                //  .HasForeignKey(d => d.IdPersona);

        }
    }
}
