using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_ProcuradorMap : EntityTypeConfiguration<Gnr_Procurador>
    {
        public Gnr_ProcuradorMap()
        {
            // Primary Key
            HasKey(t => t.IdPersona);

            // Properties
            Property(t => t.IdPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.EnvioDemandas)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Gnr_Procurador");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.EnvioDemandas).HasColumnName("EnvioDemandas");
            Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");

            // Relationships
            HasRequired(t => t.Gnr_Persona)
                .WithOptional(t => t.Gnr_Procurador);

        }
    }
}
