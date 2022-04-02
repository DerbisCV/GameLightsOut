using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TitularInmuebleMap : EntityTypeConfiguration<Hip_TitularInmueble>
    {
        public Hip_TitularInmuebleMap()
        {
            // Primary Key
            HasKey(t => t.IdTitularInmueble);

            // Properties
            Property(t => t.Observaciones)
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("Hip_TitularInmueble");
            Property(t => t.IdTitularInmueble).HasColumnName("IdTitularInmueble");
            Property(t => t.IdInmueble).HasColumnName("IdInmueble");
            Property(t => t.IdDeudor).HasColumnName("IdDeudor");
            Property(t => t.Observaciones).HasColumnName("Observaciones");

            // Relationships
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Hip_TitularInmueble)
                .HasForeignKey(d => d.IdDeudor);
            HasRequired(t => t.Hip_Inmueble)
                .WithMany(t => t.Hip_TitularInmueble)
                .HasForeignKey(d => d.IdInmueble);

        }
    }
}
