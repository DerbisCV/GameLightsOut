using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Hip_HipotecaDatoEscrituraMap : IEntityTypeConfiguration<Hip_HipotecaDatoEscritura>
    {
        public Hip_HipotecaDatoEscrituraMap()
        {
        }
        public void Configure(EntityTypeBuilder<Hip_HipotecaDatoEscritura> builder)
        {
            builder.HasKey(t => t.IdEscritura);

            // Properties
            builder.Property(t => t.ColegioNotario)
                 .IsRequired()
                 .HasMaxLength(500);

            builder.Property(t => t.Notario)
                 .IsRequired()
                 .HasMaxLength(500);

            builder.Property(t => t.NoProtocolo)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(t => t.Observaciones);

            // Table & Column Mappings
            builder.ToTable("Hip_HipotecaDatoEscritura");
            builder.Property(t => t.IdEscritura).HasColumnName("IdEscritura");
            builder.Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
            builder.Property(t => t.FechaEscritura).HasColumnName("FechaEscritura");
            builder.Property(t => t.ColegioNotario).HasColumnName("ColegioNotario");
            builder.Property(t => t.Notario).HasColumnName("Notario");
            builder.Property(t => t.NoProtocolo).HasColumnName("NoProtocolo");
            builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
            builder.Property(t => t.MandamientoJudicialEjecutivo).HasColumnName("MandamientoJudicialEjecutivo");
            builder.Property(t => t.Inscrita).HasColumnName("Inscrita");

            // Relationships
            //HasRequired(t => t.Hip_Hipoteca)
            //  .WithMany(t => t.Hip_HipotecaDatoEscritura)
            //  .HasForeignKey(d => d.IdHipoteca);

        }
    }
}
