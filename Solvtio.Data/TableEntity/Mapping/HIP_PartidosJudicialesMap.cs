using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class HIP_PartidosJudicialesMap : IEntityTypeConfiguration<HIP_PartidosJudiciales>
    {
        public HIP_PartidosJudicialesMap()
        {
           } public void Configure(EntityTypeBuilder<HIP_PartidosJudiciales> builder) {
           builder.HasKey(t => t.IdPartidoJudicial);

            // Properties
            // Table & Column Mappings
           builder.ToTable("HIP_PartidosJudiciales");
           builder.Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
        }
    }
}
