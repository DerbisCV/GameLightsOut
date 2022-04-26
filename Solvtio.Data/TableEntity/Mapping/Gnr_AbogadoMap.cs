using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_AbogadoMap : IEntityTypeConfiguration<Gnr_Abogado>
    {
  
            public void Configure(EntityTypeBuilder<Gnr_Abogado> builder) {
           builder.HasKey(t => t.IdPersona);

            // Properties
           builder.Property(t => t.IdPersona)
                .ValueGeneratedNever();

           builder.Property(t => t.NoColegiado)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("Gnr_Abogado");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.NoColegiado).HasColumnName("NoColegiado");
           builder.Property(t => t.PuedeFirmarDemanda).HasColumnName("PuedeFirmarDemanda");
           builder.Property(t => t.Activo).HasColumnName("Activo");
           builder.Property(t => t.EsAbogadoDeZona).HasColumnName("EsAbogadoDeZona");

            // Relationships
            //HasRequired(t => t.Persona)
                //  .WithOptional(t => t.Gnr_Abogado);

        }
    }
}
