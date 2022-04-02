using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_InmuebleMap : EntityTypeConfiguration<Hip_Inmueble>
    {
        public Hip_InmuebleMap()
        {
            // Primary Key
            //this.HasKey(t => t.IdInmueble);

            // Properties
            Property(t => t.Direccion)
                .HasMaxLength(250);

            Property(t => t.DireccionLocalidad)
                .HasMaxLength(50);

            Property(t => t.DireccionCodigoPostal)
                .HasMaxLength(5);

            Property(t => t.DireccionProvincia)
                .HasMaxLength(50);

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

            Property(t => t.RefCatastral)
                .HasMaxLength(30);

            // Table & Column Mappings
            ToTable("Hip_Inmueble");
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
            Property(t => t.TipoSubasta).HasColumnName("TipoSubasta");
            Property(t => t.PrestamoEnPorciento).HasColumnName("PrestamoEnPorciento");
            Property(t => t.PrestamoCapital).HasColumnName("PrestamoCapital");
            Property(t => t.PrestamoIntRemuneratorios).HasColumnName("PrestamoIntRemuneratorios");
            Property(t => t.PrestamoIntDemora).HasColumnName("PrestamoIntDemora");
            Property(t => t.PrestamoPrestAccesorias).HasColumnName("PrestamoPrestAccesorias");
            Property(t => t.PrestamoCostas).HasColumnName("PrestamoCostas");
            Property(t => t.PrestamoGastos).HasColumnName("PrestamoGastos");
            Property(t => t.PrestamoIntRemuneratoriosPorciento).HasColumnName("PrestamoIntRemuneratoriosPorciento");
            Property(t => t.PrestamoIntDemoraPorciento).HasColumnName("PrestamoIntDemoraPorciento");
            Property(t => t.PrestamoPrestAccesoriasPorciento).HasColumnName("PrestamoPrestAccesoriasPorciento");
            Property(t => t.PrestamoCostasPorciento).HasColumnName("PrestamoCostasPorciento");
            Property(t => t.PrestamoGastosPorciento).HasColumnName("PrestamoGastosPorciento");
            Property(t => t.DeudaPrincipal).HasColumnName("DeudaPrincipal");
            Property(t => t.DeudaIntRemuneratorios).HasColumnName("DeudaIntRemuneratorios");
            Property(t => t.DeudaIntDemora).HasColumnName("DeudaIntDemora");
            Property(t => t.DeudaComisionesGastos).HasColumnName("DeudaComisionesGastos");
            Property(t => t.NumeroFinca).HasColumnName("NumeroFinca");
            Property(t => t.Tomo).HasColumnName("Tomo");
            Property(t => t.Libro).HasColumnName("Libro");
            Property(t => t.Folio).HasColumnName("Folio");
            Property(t => t.Registro).HasColumnName("Registro");
            Property(t => t.Inscripcion).HasColumnName("Inscripcion");
            Property(t => t.Oficina).HasColumnName("Oficina");
            Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
            //Property(t => t.EjcFechaInscripcion).HasColumnName("EjcFechaInscripcion");
            Property(t => t.EjcFechaAvaluo).HasColumnName("EjcFechaAvaluo");
            Property(t => t.EjcFechaOficioCargasAnteriores).HasColumnName("EjcFechaOficioCargasAnteriores");
            Property(t => t.EjcFechaCertificacionCargas).HasColumnName("EjcFechaCertificacionCargas");
            Property(t => t.EjcFechaLiquidacionCargasAnteriores).HasColumnName("EjcFechaLiquidacionCargasAnteriores");
            Property(t => t.EjcImporte).HasColumnName("EjcImporte");
            Property(t => t.RefCatastral).HasColumnName("RefCatastral");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.Hip_Inmueble)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.Hip_TipoInmueble)
                .WithMany(t => t.Hip_Inmueble)
                .HasForeignKey(d => d.IdTipoInmueble);

        }
    }
}
