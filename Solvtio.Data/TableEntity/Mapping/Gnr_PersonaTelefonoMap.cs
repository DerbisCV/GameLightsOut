using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaTelefonoMap : EntityTypeConfiguration<Gnr_PersonaTelefono>
    {
        public Gnr_PersonaTelefonoMap()
        {
            // Primary Key
            HasKey(t => t.IdPersonaTelefono);

            // Properties
            Property(t => t.Telefono)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_PersonaTelefono");
            Property(t => t.IdPersonaTelefono).HasColumnName("IdPersonaTelefono");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.Telefono).HasColumnName("Telefono");
            Property(t => t.IdTipoTelefono).HasColumnName("IdTipoTelefono");

            // Relationships
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Gnr_PersonaTelefono)
                .HasForeignKey(d => d.IdPersona);
            HasRequired(t => t.Gnr_TipoTelefono)
                .WithMany(t => t.Gnr_PersonaTelefono)
                .HasForeignKey(d => d.IdTipoTelefono);

        }
    }
}
