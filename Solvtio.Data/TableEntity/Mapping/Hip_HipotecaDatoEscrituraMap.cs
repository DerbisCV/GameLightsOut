using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_HipotecaDatoEscrituraMap : EntityTypeConfiguration<Hip_HipotecaDatoEscritura>
    {
        public Hip_HipotecaDatoEscrituraMap()
        {
            // Primary Key
            HasKey(t => t.IdEscritura);

            // Properties
            Property(t => t.ColegioNotario)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.Notario)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.NoProtocolo)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Observaciones);

            // Table & Column Mappings
            ToTable("Hip_HipotecaDatoEscritura");
            Property(t => t.IdEscritura).HasColumnName("IdEscritura");
            Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
            Property(t => t.FechaEscritura).HasColumnName("FechaEscritura");
            Property(t => t.ColegioNotario).HasColumnName("ColegioNotario");
            Property(t => t.Notario).HasColumnName("Notario");
            Property(t => t.NoProtocolo).HasColumnName("NoProtocolo");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.MandamientoJudicialEjecutivo).HasColumnName("MandamientoJudicialEjecutivo");
            Property(t => t.Inscrita).HasColumnName("Inscrita");

            // Relationships
            HasRequired(t => t.Hip_Hipoteca)
                .WithMany(t => t.Hip_HipotecaDatoEscritura)
                .HasForeignKey(d => d.IdHipoteca);

        }
    }
}
