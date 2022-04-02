using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_TipoFaseMap : EntityTypeConfiguration<Con_TipoFase>
    {
        public Con_TipoFaseMap()
        {
            // Primary Key
            HasKey(t => t.IdFase);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Con_TipoFase");
            Property(t => t.IdFase).HasColumnName("IdFase");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
