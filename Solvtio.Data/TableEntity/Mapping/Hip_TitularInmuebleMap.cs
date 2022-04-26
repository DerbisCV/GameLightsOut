using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TitularInmuebleMap : IEntityTypeConfiguration<Hip_TitularInmueble>
    {
        public Hip_TitularInmuebleMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TitularInmueble> builder) {
           builder.HasKey(t => t.IdTitularInmueble);

            // Properties
           builder.Property(t => t.Observaciones)
                .HasMaxLength(1000);

            // Table & Column Mappings
           builder.ToTable("Hip_TitularInmueble");
           builder.Property(t => t.IdTitularInmueble).HasColumnName("IdTitularInmueble");
           builder.Property(t => t.IdInmueble).HasColumnName("IdInmueble");
           builder.Property(t => t.IdDeudor).HasColumnName("IdDeudor");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");

            // Relationships
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.Hip_TitularInmueble)
                //  .HasForeignKey(d => d.IdDeudor);
            //HasRequired(t => t.Hip_Inmueble)
                //  .WithMany(t => t.Hip_TitularInmueble)
                //  .HasForeignKey(d => d.IdInmueble);

        }
    }
}
