using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoAlertaMap : EntityTypeConfiguration<Gnr_TipoAlerta>
    {
        public Gnr_TipoAlertaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoAlerta);

            // Properties
            Property(t => t.IdTipoAlerta)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.Grupo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_TipoAlerta");
            Property(t => t.IdTipoAlerta).HasColumnName("IdTipoAlerta");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.Grupo).HasColumnName("Grupo");
        }
    }
}
