using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TipoDemandaMap : EntityTypeConfiguration<Hip_TipoDemanda>
    {
        public Hip_TipoDemandaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoDemanda);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Hip_TipoDemanda");
            Property(t => t.IdTipoDemanda).HasColumnName("IdTipoDemanda");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
