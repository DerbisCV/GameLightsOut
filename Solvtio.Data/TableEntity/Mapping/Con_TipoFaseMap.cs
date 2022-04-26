using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_TipoFaseMap : IEntityTypeConfiguration<Con_TipoFase>
    {

            public void Configure(EntityTypeBuilder<Con_TipoFase> builder) {
           builder.HasKey(t => t.IdFase);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Con_TipoFase");
           builder.Property(t => t.IdFase).HasColumnName("IdFase");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
        }
    }
}
