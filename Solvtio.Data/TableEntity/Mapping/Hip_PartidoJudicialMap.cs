using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_PartidoJudicialMap : IEntityTypeConfiguration<PartidoJudicial>
    {
        public Hip_PartidoJudicialMap()
        {
           } public void Configure(EntityTypeBuilder<PartidoJudicial> builder) {
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
