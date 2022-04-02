using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_PartidoJudicialMap : EntityTypeConfiguration<PartidoJudicial>
    {
        public Hip_PartidoJudicialMap()
        {
            // Primary Key
            //HasKey(t => t.IdPartidoJudicial);

            // Properties
            //Property(t => t.Nombre).HasMaxLength(500);

            // Table & Column Mappings
            //ToTable("Hip_PartidoJudicial");
            //Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
            //Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
