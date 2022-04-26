using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vGnr_NombresCamposMap : IEntityTypeConfiguration<vGnr_NombresCampos>
    //{
    //    public vGnr_NombresCamposMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.Tabla, t.column_id });

    //        // Properties
    //       builder.Property(t => t.Tabla)
    //            .IsRequired()
    //            .HasMaxLength(128);

    //       builder.Property(t => t.Columna)
    //            .HasMaxLength(128);

    //       builder.Property(t => t.column_id)
    //            .ValueGeneratedNever();

    //        // Table & Column Mappings
    //       builder.ToTable("vGnr_NombresCampos");
    //       builder.Property(t => t.Tabla).HasColumnName("Tabla");
    //       builder.Property(t => t.Columna).HasColumnName("Columna");
    //       builder.Property(t => t.column_id).HasColumnName("column_id");
    //    }
    //}
}
