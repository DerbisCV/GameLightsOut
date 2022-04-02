using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaDireccionMap : EntityTypeConfiguration<Gnr_PersonaDireccion>
    {
        public Gnr_PersonaDireccionMap()
        {
            // Primary Key
            HasKey(t => t.IdPersonaDireccion);

            // Properties
            Property(t => t.Direccion)
                .IsRequired();

            Property(t => t.Ciudad)
                .HasMaxLength(50);

            Property(t => t.Region)
                .HasMaxLength(50);

            Property(t => t.CodigoPostal)
                .HasMaxLength(10);

            Property(t => t.Pais)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_PersonaDireccion");
            Property(t => t.IdPersonaDireccion).HasColumnName("IdPersonaDireccion");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoDireccion).HasColumnName("IdTipoDireccion");
            Property(t => t.Direccion).HasColumnName("Direccion");
            Property(t => t.Ciudad).HasColumnName("Ciudad");
            Property(t => t.Region).HasColumnName("Region");
            Property(t => t.CodigoPostal).HasColumnName("CodigoPostal");
            Property(t => t.Pais).HasColumnName("Pais");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Gnr_PersonaDireccion)
                .HasForeignKey(d => d.IdPersona);
            HasRequired(t => t.Gnr_TipoDireccion)
                .WithMany(t => t.Gnr_PersonaDireccion)
                .HasForeignKey(d => d.IdTipoDireccion);

        }
    }
}
