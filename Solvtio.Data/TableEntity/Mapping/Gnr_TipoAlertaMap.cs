using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoAlertaMap : IEntityTypeConfiguration<Gnr_TipoAlerta>
    {
        public Gnr_TipoAlertaMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_TipoAlerta> builder) {
           builder.HasKey(t => t.IdTipoAlerta);

            // Properties
           builder.Property(t => t.IdTipoAlerta)
                .ValueGeneratedNever();

           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(150);

           builder.Property(t => t.Grupo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoAlerta");
           builder.Property(t => t.IdTipoAlerta).HasColumnName("IdTipoAlerta");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.Grupo).HasColumnName("Grupo");
        }
    }
}
