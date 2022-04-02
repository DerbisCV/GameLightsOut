using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class AccionFlujoMap : EntityTypeConfiguration<AccionFlujo>
    {
        public AccionFlujoMap()
        {
            // Primary Key
            HasKey(t => t.IdAccionFlujo);

            // Properties
            // Table & Column Mappings
            ToTable("AccionFlujo");
            Property(t => t.IdAccionFlujo).HasColumnName("IdAccionFlujo");
            Property(t => t.IdAccionOrigen).HasColumnName("IdAccionOrigen");
            Property(t => t.IdAccionDestino).HasColumnName("IdAccionDestino");

            // Relationships
            HasRequired(t => t.TipoAccion)
                .WithMany(t => t.AccionFlujoes)
                .HasForeignKey(d => d.IdAccionOrigen);

        }
    }
}
