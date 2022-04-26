using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_InmuebleMap : IEntityTypeConfiguration<Hip_Inmueble>
    {
        public Hip_InmuebleMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_Inmueble> builder) {
            //this.HasKey(t => t.IdInmueble);

            // Properties
           builder.Property(t => t.Direccion)
                .HasMaxLength(250);

           builder.Property(t => t.DireccionLocalidad)
                .HasMaxLength(50);

           builder.Property(t => t.DireccionCodigoPostal)
                .HasMaxLength(5);

           builder.Property(t => t.DireccionProvincia)
                .HasMaxLength(50);

           builder.Property(t => t.NumeroFinca)
                .HasMaxLength(250);

           builder.Property(t => t.Tomo)
                .HasMaxLength(250);

           builder.Property(t => t.Libro)
                .HasMaxLength(250);

           builder.Property(t => t.Folio)
                .HasMaxLength(250);

           builder.Property(t => t.Registro)
                .HasMaxLength(250);

           builder.Property(t => t.Inscripcion)
                .HasMaxLength(250);

           builder.Property(t => t.Oficina)
                .HasMaxLength(4);

           builder.Property(t => t.NoCuentaPrestamo)
                .HasMaxLength(10);

           builder.Property(t => t.RefCatastral)
                .HasMaxLength(30);

            // Table & Column Mappings
           builder.ToTable("Hip_Inmueble");
           builder.Property(t => t.IdInmueble).HasColumnName("IdInmueble");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdTipoInmueble).HasColumnName("IdTipoInmueble");
           builder.Property(t => t.EsHabitual).HasColumnName("EsHabitual");
           builder.Property(t => t.Superficie).HasColumnName("Superficie");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Direccion).HasColumnName("Direccion");
           builder.Property(t => t.DireccionLocalidad).HasColumnName("DireccionLocalidad");
           builder.Property(t => t.DireccionCodigoPostal).HasColumnName("DireccionCodigoPostal");
           builder.Property(t => t.DireccionProvincia).HasColumnName("DireccionProvincia");
           builder.Property(t => t.TipoSubasta).HasColumnName("TipoSubasta");
           builder.Property(t => t.PrestamoEnPorciento).HasColumnName("PrestamoEnPorciento");
           builder.Property(t => t.PrestamoCapital).HasColumnName("PrestamoCapital");
           builder.Property(t => t.PrestamoIntRemuneratorios).HasColumnName("PrestamoIntRemuneratorios");
           builder.Property(t => t.PrestamoIntDemora).HasColumnName("PrestamoIntDemora");
           builder.Property(t => t.PrestamoPrestAccesorias).HasColumnName("PrestamoPrestAccesorias");
           builder.Property(t => t.PrestamoCostas).HasColumnName("PrestamoCostas");
           builder.Property(t => t.PrestamoGastos).HasColumnName("PrestamoGastos");
           builder.Property(t => t.PrestamoIntRemuneratoriosPorciento).HasColumnName("PrestamoIntRemuneratoriosPorciento");
           builder.Property(t => t.PrestamoIntDemoraPorciento).HasColumnName("PrestamoIntDemoraPorciento");
           builder.Property(t => t.PrestamoPrestAccesoriasPorciento).HasColumnName("PrestamoPrestAccesoriasPorciento");
           builder.Property(t => t.PrestamoCostasPorciento).HasColumnName("PrestamoCostasPorciento");
           builder.Property(t => t.PrestamoGastosPorciento).HasColumnName("PrestamoGastosPorciento");
           builder.Property(t => t.DeudaPrincipal).HasColumnName("DeudaPrincipal");
           builder.Property(t => t.DeudaIntRemuneratorios).HasColumnName("DeudaIntRemuneratorios");
           builder.Property(t => t.DeudaIntDemora).HasColumnName("DeudaIntDemora");
           builder.Property(t => t.DeudaComisionesGastos).HasColumnName("DeudaComisionesGastos");
           builder.Property(t => t.NumeroFinca).HasColumnName("NumeroFinca");
           builder.Property(t => t.Tomo).HasColumnName("Tomo");
           builder.Property(t => t.Libro).HasColumnName("Libro");
           builder.Property(t => t.Folio).HasColumnName("Folio");
           builder.Property(t => t.Registro).HasColumnName("Registro");
           builder.Property(t => t.Inscripcion).HasColumnName("Inscripcion");
           builder.Property(t => t.Oficina).HasColumnName("Oficina");
           builder.Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
            //Property(t => t.EjcFechaInscripcion).HasColumnName("EjcFechaInscripcion");
           builder.Property(t => t.EjcFechaAvaluo).HasColumnName("EjcFechaAvaluo");
           builder.Property(t => t.EjcFechaOficioCargasAnteriores).HasColumnName("EjcFechaOficioCargasAnteriores");
           builder.Property(t => t.EjcFechaCertificacionCargas).HasColumnName("EjcFechaCertificacionCargas");
           builder.Property(t => t.EjcFechaLiquidacionCargasAnteriores).HasColumnName("EjcFechaLiquidacionCargasAnteriores");
           builder.Property(t => t.EjcImporte).HasColumnName("EjcImporte");
           builder.Property(t => t.RefCatastral).HasColumnName("RefCatastral");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.Hip_Inmueble)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.Hip_TipoInmueble)
                //  .WithMany(t => t.Hip_Inmueble)
                //  .HasForeignKey(d => d.IdTipoInmueble);

        }
    }
}
