using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_Hipoteca_EnEjecucion_ViewMap : EntityTypeConfiguration<Hip_Hipoteca_EnEjecucion_View>
    {
        public Hip_Hipoteca_EnEjecucion_ViewMap()
        {
            // Primary Key
            HasKey(t => new { t.IdHipoteca, t.IdValija, t.IdTipoArea, t.OficinaNoCuenta, t.NoCuentaPrestamo, t.NoHipoteca, t.DeudaCierreFijacion, t.Ejecutar, t.Deudor });

            // Properties
            Property(t => t.IdHipoteca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.IdValija)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.IdTipoArea)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.OficinaNoCuenta)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.NoCuentaPrestamo)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.NoHipoteca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.DeudaCierreFijacion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

            Property(t => t.EntidadOrigen)
                .HasMaxLength(250);

            Property(t => t.Deudor)
                .IsRequired()
                .HasMaxLength(801);

            // Table & Column Mappings
            ToTable("Hip_Hipoteca_EnEjecucion_View");
            Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
            Property(t => t.IdValija).HasColumnName("IdValija");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdPeriodicidad).HasColumnName("IdPeriodicidad");
            Property(t => t.IdTipoReferenciaHipotecaria).HasColumnName("IdTipoReferenciaHipotecaria");
            Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
            Property(t => t.IdJuzgado).HasColumnName("IdJuzgado");
            Property(t => t.OficinaNoCuenta).HasColumnName("OficinaNoCuenta");
            Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
            Property(t => t.NoHipoteca).HasColumnName("NoHipoteca");
            Property(t => t.DeudaCierreFijacion).HasColumnName("DeudaCierreFijacion");
            Property(t => t.PrestamoCapital).HasColumnName("PrestamoCapital");
            Property(t => t.FechaCierre).HasColumnName("FechaCierre");
            Property(t => t.DemandaFecha).HasColumnName("DemandaFecha");
            Property(t => t.Ejecutar).HasColumnName("Ejecutar");
            Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
            Property(t => t.EntidadOrigen).HasColumnName("EntidadOrigen");
            Property(t => t.Deudor).HasColumnName("Deudor");
        }
    }
}
