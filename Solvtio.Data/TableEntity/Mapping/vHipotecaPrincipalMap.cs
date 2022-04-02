using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vHipotecaPrincipalMap : EntityTypeConfiguration<vHipotecaPrincipal>
    {
        public vHipotecaPrincipalMap()
        {
            // Primary Key
            HasKey(t => new { t.IdHipoteca, t.IdValija, t.IdTipoArea, t.OficinaNoCuenta, t.NoCuentaPrestamo, t.NoHipoteca, t.DeudaCierreFijacion, t.Ejecutar });

            // Properties
            Property(t => t.IdHipoteca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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

            // Table & Column Mappings
            ToTable("vHipotecaPrincipal");
            Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdValija).HasColumnName("IdValija");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
            Property(t => t.OficinaNoCuenta).HasColumnName("OficinaNoCuenta");
            Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
            Property(t => t.NoHipoteca).HasColumnName("NoHipoteca");
            Property(t => t.DeudaCierreFijacion).HasColumnName("DeudaCierreFijacion");
            Property(t => t.Ejecutar).HasColumnName("Ejecutar");
            Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
        }
    }
}
