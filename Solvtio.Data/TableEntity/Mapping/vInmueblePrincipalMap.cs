using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vInmueblePrincipalMap : EntityTypeConfiguration<vInmueblePrincipal>
    {
        public vInmueblePrincipalMap()
        {
            // Primary Key
            HasKey(t => new { t.IdExpediente, t.IdTipoInmueble, t.EsHabitual, t.Superficie, t.PrestamoCapital, t.DeudaPrincipal });

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.IdTipoInmueble)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Superficie)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Direccion)
                .HasMaxLength(250);

            Property(t => t.DireccionLocalidad)
                .HasMaxLength(50);

            Property(t => t.DireccionCodigoPostal)
                .HasMaxLength(5);

            Property(t => t.DireccionProvincia)
                .HasMaxLength(50);

            Property(t => t.PrestamoCapital)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.DeudaPrincipal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.NumeroFinca)
                .HasMaxLength(250);

            Property(t => t.Tomo)
                .HasMaxLength(250);

            Property(t => t.Libro)
                .HasMaxLength(250);

            Property(t => t.Folio)
                .HasMaxLength(250);

            Property(t => t.Registro)
                .HasMaxLength(250);

            Property(t => t.Inscripcion)
                .HasMaxLength(250);

            Property(t => t.Oficina)
                .HasMaxLength(4);

            Property(t => t.NoCuentaPrestamo)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("vInmueblePrincipal");
            Property(t => t.IdInmueble).HasColumnName("IdInmueble");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdTipoInmueble).HasColumnName("IdTipoInmueble");
            Property(t => t.EsHabitual).HasColumnName("EsHabitual");
            Property(t => t.Superficie).HasColumnName("Superficie");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Direccion).HasColumnName("Direccion");
            Property(t => t.DireccionLocalidad).HasColumnName("DireccionLocalidad");
            Property(t => t.DireccionCodigoPostal).HasColumnName("DireccionCodigoPostal");
            Property(t => t.DireccionProvincia).HasColumnName("DireccionProvincia");
            Property(t => t.PrestamoCapital).HasColumnName("PrestamoCapital");
            Property(t => t.DeudaPrincipal).HasColumnName("DeudaPrincipal");
            Property(t => t.NumeroFinca).HasColumnName("NumeroFinca");
            Property(t => t.Tomo).HasColumnName("Tomo");
            Property(t => t.Libro).HasColumnName("Libro");
            Property(t => t.Folio).HasColumnName("Folio");
            Property(t => t.Registro).HasColumnName("Registro");
            Property(t => t.Inscripcion).HasColumnName("Inscripcion");
            Property(t => t.Oficina).HasColumnName("Oficina");
            Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
        }
    }
}
