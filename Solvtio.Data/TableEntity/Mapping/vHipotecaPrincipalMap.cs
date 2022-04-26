using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vHipotecaPrincipalMap : IEntityTypeConfiguration<vHipotecaPrincipal>
    //{
    //    public vHipotecaPrincipalMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.IdHipoteca, t.IdValija, t.IdTipoArea, t.OficinaNoCuenta, t.NoCuentaPrestamo, t.NoHipoteca, t.DeudaCierreFijacion, t.Ejecutar });

    //        // Properties
    //       builder.Property(t => t.IdHipoteca)
    //            .ValueGeneratedOnAdd();

    //       builder.Property(t => t.IdValija)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.IdTipoArea)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.OficinaNoCuenta)
    //            .IsRequired()
    //            .HasMaxLength(4);

    //       builder.Property(t => t.NoCuentaPrestamo)
    //            .IsRequired()
    //            .HasMaxLength(100);

    //       builder.Property(t => t.NoHipoteca)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.DeudaCierreFijacion)
    //            .ValueGeneratedNever();

    //        // Table & Column Mappings
    //       builder.ToTable("vHipotecaPrincipal");
    //       builder.Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.IdValija).HasColumnName("IdValija");
    //       builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
    //       builder.Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
    //       builder.Property(t => t.OficinaNoCuenta).HasColumnName("OficinaNoCuenta");
    //       builder.Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
    //       builder.Property(t => t.NoHipoteca).HasColumnName("NoHipoteca");
    //       builder.Property(t => t.DeudaCierreFijacion).HasColumnName("DeudaCierreFijacion");
    //       builder.Property(t => t.Ejecutar).HasColumnName("Ejecutar");
    //       builder.Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
    //    }
    //}
}
