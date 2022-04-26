using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_HipotecaMap : IEntityTypeConfiguration<Hip_Hipoteca>
    {
        public Hip_HipotecaMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_Hipoteca> builder) {
           builder.HasKey(t => t.IdHipoteca);

            // Properties
           builder.Property(t => t.OficinaNoCuenta)
                .IsRequired()
                .HasMaxLength(4);

           builder.Property(t => t.NoCuentaPrestamo)
                .IsRequired()
                .HasMaxLength(100);

           builder.Property(t => t.ColegioNotarioFijacion)
                .HasMaxLength(50);

           builder.Property(t => t.NotarioFijacion)
                .HasMaxLength(500);

           builder.Property(t => t.Registro)
                .HasMaxLength(500);

           builder.Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

           builder.Property(t => t.EntidadOrigen)
                .HasMaxLength(250);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Hip_Hipoteca");
           builder.Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
            //Property(t => t.IdValija).HasColumnName("IdValija");
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
           builder.Property(t => t.ColegioNotarioFijacion).HasColumnName("ColegioNotarioFijacion");
           builder.Property(t => t.NotarioFijacion).HasColumnName("NotarioFijacion");
           builder.Property(t => t.Registro).HasColumnName("Registro");
           builder.Property(t => t.CuotasCantidad).HasColumnName("CuotasCantidad");
           builder.Property(t => t.CuotasValor).HasColumnName("CuotasValor");
           builder.Property(t => t.CuotasFechaPrimera).HasColumnName("CuotasFechaPrimera");
           builder.Property(t => t.CuotasFechaUltima).HasColumnName("CuotasFechaUltima");
           builder.Property(t => t.TipoInteresInicial).HasColumnName("TipoInteresInicial");
           builder.Property(t => t.TipoInteresUltimo).HasColumnName("TipoInteresUltimo");
           builder.Property(t => t.TipoInteresMoratorio).HasColumnName("TipoInteresMoratorio");
           builder.Property(t => t.FechaModificacionTipoInteres).HasColumnName("FechaModificacionTipoInteres");
           builder.Property(t => t.FechaPrimeraCuotaImpagada).HasColumnName("FechaPrimeraCuotaImpagada");
           builder.Property(t => t.FechaCierre).HasColumnName("FechaCierre");
           builder.Property(t => t.DemandaFecha).HasColumnName("DemandaFecha");
           builder.Property(t => t.Ejecutar).HasColumnName("Ejecutar");
           builder.Property(t => t.DiferencialIndiceReferenciaHipotecaria).HasColumnName("DiferencialIndiceReferenciaHipotecaria");
           builder.Property(t => t.DemandaSucesionBancaria).HasColumnName("DemandaSucesionBancaria");
           builder.Property(t => t.DemandaBurofaxNoNotificado).HasColumnName("DemandaBurofaxNoNotificado");
           builder.Property(t => t.NovacionFechaFinPeriodoCarencia).HasColumnName("NovacionFechaFinPeriodoCarencia");
           builder.Property(t => t.NovacionNoCuotas).HasColumnName("NovacionNoCuotas");
           builder.Property(t => t.NovacionFechaPeriodoAmortizacionInicio).HasColumnName("NovacionFechaPeriodoAmortizacionInicio");
           builder.Property(t => t.NovacionFechaPeriodoAmortizacionFin).HasColumnName("NovacionFechaPeriodoAmortizacionFin");
           builder.Property(t => t.NovacionComision).HasColumnName("NovacionComision");
           builder.Property(t => t.FechaActaFijacion).HasColumnName("FechaActaFijacion");
           builder.Property(t => t.Carencia).HasColumnName("Carencia");
           builder.Property(t => t.Diferencial).HasColumnName("Diferencial");
           builder.Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
           builder.Property(t => t.EntidadOrigen).HasColumnName("EntidadOrigen");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
        }
    }
}
