using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class HIP_PartidosJudicialesMap : EntityTypeConfiguration<HIP_PartidosJudiciales>
    {
        public HIP_PartidosJudicialesMap()
        {
            // Primary Key
            HasKey(t => t.IdPartidoJudicial);

            // Properties
            // Table & Column Mappings
            ToTable("HIP_PartidosJudiciales");
            Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
        }
    }
}
