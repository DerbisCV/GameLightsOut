using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteMap : IEntityTypeConfiguration<Con_Expediente>
    {
            public void Configure(EntityTypeBuilder<Con_Expediente> builder) {
           builder.HasKey(t => t.IdExpediente);

            // Properties
           builder.Property(t => t.IdExpediente)
                .ValueGeneratedNever();

            //this.Property(t => t.NoAuto)
            //    .HasMaxLength(50);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            //this.Property(t => t.Juzgado)
            //    .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Con_Expediente");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.FechaDeclaracion).HasColumnName("FechaDeclaracion");
           builder.Property(t => t.FechaPublicacionBoe).HasColumnName("FechaPublicacionBoe");
           builder.Property(t => t.PlazoEnDias).HasColumnName("PlazoEnDias");
            //this.Property(t => t.NoAuto).HasColumnName("NoAuto");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            //this.Property(t => t.Juzgado).HasColumnName("Juzgado");
           builder.Property(t => t.IdDeudorPrincipal).HasColumnName("IdDeudorPrincipal");

            // Relationships
            // HasOptional(t => t.Gnr_Persona)
                //  .WithMany(t => t.Con_Expediente)
                //  .HasForeignKey(d => d.IdDeudorPrincipal);
            //HasRequired(t => t.Expediente)
                //  .WithOptional(t => t.Con_Expediente);

        }
    }
}
