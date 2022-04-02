using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_AbogadoMap : EntityTypeConfiguration<Gnr_Abogado>
    {
        public Gnr_AbogadoMap()
        {
            // Primary Key
            HasKey(t => t.IdPersona);

            // Properties
            Property(t => t.IdPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.NoColegiado)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Gnr_Abogado");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.NoColegiado).HasColumnName("NoColegiado");
            Property(t => t.PuedeFirmarDemanda).HasColumnName("PuedeFirmarDemanda");
            Property(t => t.Activo).HasColumnName("Activo");
            Property(t => t.EsAbogadoDeZona).HasColumnName("EsAbogadoDeZona");

            // Relationships
            HasRequired(t => t.Persona)
                .WithOptional(t => t.Gnr_Abogado);

        }
    }
}
