using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vGnr_NombresCamposMap : EntityTypeConfiguration<vGnr_NombresCampos>
    {
        public vGnr_NombresCamposMap()
        {
            // Primary Key
            HasKey(t => new { t.Tabla, t.column_id });

            // Properties
            Property(t => t.Tabla)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.Columna)
                .HasMaxLength(128);

            Property(t => t.column_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("vGnr_NombresCampos");
            Property(t => t.Tabla).HasColumnName("Tabla");
            Property(t => t.Columna).HasColumnName("Columna");
            Property(t => t.column_id).HasColumnName("column_id");
        }
    }
}
