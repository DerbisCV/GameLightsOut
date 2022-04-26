using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaTelefonoMap : IEntityTypeConfiguration<Gnr_PersonaTelefono>
    {
     
            public void Configure(EntityTypeBuilder<Gnr_PersonaTelefono> builder) {
           builder.HasKey(t => t.IdPersonaTelefono);

            // Properties
           builder.Property(t => t.Telefono)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_PersonaTelefono");
           builder.Property(t => t.IdPersonaTelefono).HasColumnName("IdPersonaTelefono");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.Telefono).HasColumnName("Telefono");
           builder.Property(t => t.IdTipoTelefono).HasColumnName("IdTipoTelefono");

            // Relationships
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.Gnr_PersonaTelefono)
                //  .HasForeignKey(d => d.IdPersona);
            //HasRequired(t => t.Gnr_TipoTelefono)
                //  .WithMany(t => t.Gnr_PersonaTelefono)
                //  .HasForeignKey(d => d.IdTipoTelefono);

        }
    }
}
