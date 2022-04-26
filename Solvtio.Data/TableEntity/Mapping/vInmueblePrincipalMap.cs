using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vInmueblePrincipalMap : IEntityTypeConfiguration<vInmueblePrincipal>
    //{
    //    public vInmueblePrincipalMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.IdExpediente, t.IdTipoInmueble, t.EsHabitual, t.Superficie, t.PrestamoCapital, t.DeudaPrincipal });

    //        // Properties
    //       builder.Property(t => t.IdExpediente)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.IdTipoInmueble)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.Superficie)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.Direccion)
    //            .HasMaxLength(250);

    //       builder.Property(t => t.DireccionLocalidad)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.DireccionCodigoPostal)
    //            .HasMaxLength(5);

    //       builder.Property(t => t.DireccionProvincia)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.PrestamoCapital)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.DeudaPrincipal)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.NumeroFinca)
    //            .HasMaxLength(250);

    //       builder.Property(t => t.Tomo)
    //            .HasMaxLength(250);

    //       builder.Property(t => t.Libro)
    //            .HasMaxLength(250);

    //       builder.Property(t => t.Folio)
    //            .HasMaxLength(250);

    //       builder.Property(t => t.Registro)
    //            .HasMaxLength(250);

    //       builder.Property(t => t.Inscripcion)
    //            .HasMaxLength(250);

    //       builder.Property(t => t.Oficina)
    //            .HasMaxLength(4);

    //       builder.Property(t => t.NoCuentaPrestamo)
    //            .HasMaxLength(10);

    //        // Table & Column Mappings
    //       builder.ToTable("vInmueblePrincipal");
    //       builder.Property(t => t.IdInmueble).HasColumnName("IdInmueble");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.IdTipoInmueble).HasColumnName("IdTipoInmueble");
    //       builder.Property(t => t.EsHabitual).HasColumnName("EsHabitual");
    //       builder.Property(t => t.Superficie).HasColumnName("Superficie");
    //       builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
    //       builder.Property(t => t.Direccion).HasColumnName("Direccion");
    //       builder.Property(t => t.DireccionLocalidad).HasColumnName("DireccionLocalidad");
    //       builder.Property(t => t.DireccionCodigoPostal).HasColumnName("DireccionCodigoPostal");
    //       builder.Property(t => t.DireccionProvincia).HasColumnName("DireccionProvincia");
    //       builder.Property(t => t.PrestamoCapital).HasColumnName("PrestamoCapital");
    //       builder.Property(t => t.DeudaPrincipal).HasColumnName("DeudaPrincipal");
    //       builder.Property(t => t.NumeroFinca).HasColumnName("NumeroFinca");
    //       builder.Property(t => t.Tomo).HasColumnName("Tomo");
    //       builder.Property(t => t.Libro).HasColumnName("Libro");
    //       builder.Property(t => t.Folio).HasColumnName("Folio");
    //       builder.Property(t => t.Registro).HasColumnName("Registro");
    //       builder.Property(t => t.Inscripcion).HasColumnName("Inscripcion");
    //       builder.Property(t => t.Oficina).HasColumnName("Oficina");
    //       builder.Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
    //    }
    //}
}
