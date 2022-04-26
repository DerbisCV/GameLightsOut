using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_TipoDemandaMap : IEntityTypeConfiguration<Hip_TipoDemanda>
    {
        public Hip_TipoDemandaMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_TipoDemanda> builder) {
           builder.HasKey(t => t.IdTipoDemanda);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Hip_TipoDemanda");
           builder.Property(t => t.IdTipoDemanda).HasColumnName("IdTipoDemanda");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
