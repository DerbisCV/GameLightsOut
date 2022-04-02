using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_TipoReferenciaHipotecariaMap : EntityTypeConfiguration<Hip_TipoReferenciaHipotecaria>
    {
        public Hip_TipoReferenciaHipotecariaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoIndiceReferenciaHipotecaria);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("Hip_TipoReferenciaHipotecaria");
            Property(t => t.IdTipoIndiceReferenciaHipotecaria).HasColumnName("IdTipoIndiceReferenciaHipotecaria");
            Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
