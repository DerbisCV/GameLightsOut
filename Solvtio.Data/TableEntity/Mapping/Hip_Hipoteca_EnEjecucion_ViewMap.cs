using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_Hipoteca_EnEjecucion_ViewMap : IEntityTypeConfiguration<Hip_Hipoteca_EnEjecucion_View>
    {
        public Hip_Hipoteca_EnEjecucion_ViewMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_Hipoteca_EnEjecucion_View> builder) {
           builder.HasKey(t => new { t.IdHipoteca, t.IdValija, t.IdTipoArea, t.OficinaNoCuenta, t.NoCuentaPrestamo, t.NoHipoteca, t.DeudaCierreFijacion, t.Ejecutar, t.Deudor });

            // Properties
           builder.Property(t => t.IdHipoteca)
                .ValueGeneratedNever();

           builder.Property(t => t.IdValija)
                .ValueGeneratedNever();

           builder.Property(t => t.IdTipoArea)
                .ValueGeneratedNever();

           builder.Property(t => t.OficinaNoCuenta)
                .IsRequired()
                .HasMaxLength(4);

           builder.Property(t => t.NoCuentaPrestamo)
                .IsRequired()
                .HasMaxLength(100);

           builder.Property(t => t.NoHipoteca)
                .ValueGeneratedNever();

           builder.Property(t => t.DeudaCierreFijacion)
                .ValueGeneratedNever();

           builder.Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

           builder.Property(t => t.EntidadOrigen)
                .HasMaxLength(250);

           builder.Property(t => t.Deudor)
                .IsRequired()
                .HasMaxLength(801);

            // Table & Column Mappings
           builder.ToTable("Hip_Hipoteca_EnEjecucion_View");
           builder.Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
           builder.Property(t => t.IdValija).HasColumnName("IdValija");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdPeriodicidad).HasColumnName("IdPeriodicidad");
           builder.Property(t => t.IdTipoReferenciaHipotecaria).HasColumnName("IdTipoReferenciaHipotecaria");
           builder.Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
           builder.Property(t => t.IdJuzgado).HasColumnName("IdJuzgado");
           builder.Property(t => t.OficinaNoCuenta).HasColumnName("OficinaNoCuenta");
           builder.Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
           builder.Property(t => t.NoHipoteca).HasColumnName("NoHipoteca");
           builder.Property(t => t.DeudaCierreFijacion).HasColumnName("DeudaCierreFijacion");
           builder.Property(t => t.PrestamoCapital).HasColumnName("PrestamoCapital");
           builder.Property(t => t.FechaCierre).HasColumnName("FechaCierre");
           builder.Property(t => t.DemandaFecha).HasColumnName("DemandaFecha");
           builder.Property(t => t.Ejecutar).HasColumnName("Ejecutar");
           builder.Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
           builder.Property(t => t.EntidadOrigen).HasColumnName("EntidadOrigen");
           builder.Property(t => t.Deudor).HasColumnName("Deudor");
        }
    }
}
