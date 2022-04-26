using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaDireccionMap : IEntityTypeConfiguration<Gnr_PersonaDireccion>
    {
      
            public void Configure(EntityTypeBuilder<Gnr_PersonaDireccion> builder) {
           builder.HasKey(t => t.IdPersonaDireccion);

            // Properties
           builder.Property(t => t.Direccion)
                .IsRequired();

           builder.Property(t => t.Ciudad)
                .HasMaxLength(50);

           builder.Property(t => t.Region)
                .HasMaxLength(50);

           builder.Property(t => t.CodigoPostal)
                .HasMaxLength(10);

           builder.Property(t => t.Pais)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_PersonaDireccion");
           builder.Property(t => t.IdPersonaDireccion).HasColumnName("IdPersonaDireccion");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.IdTipoDireccion).HasColumnName("IdTipoDireccion");
           builder.Property(t => t.Direccion).HasColumnName("Direccion");
           builder.Property(t => t.Ciudad).HasColumnName("Ciudad");
           builder.Property(t => t.Region).HasColumnName("Region");
           builder.Property(t => t.CodigoPostal).HasColumnName("CodigoPostal");
           builder.Property(t => t.Pais).HasColumnName("Pais");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.Gnr_PersonaDireccion)
                //  .HasForeignKey(d => d.IdPersona);
            //HasRequired(t => t.Gnr_TipoDireccion)
                //  .WithMany(t => t.Gnr_PersonaDireccion)
                //  .HasForeignKey(d => d.IdTipoDireccion);

        }
    }
}
