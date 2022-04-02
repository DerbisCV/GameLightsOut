using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vHip_HipotecaEnEjecucionMap : EntityTypeConfiguration<vHip_HipotecaEnEjecucion>
    {
        public vHip_HipotecaEnEjecucionMap()
        {
            // Primary Key
            HasKey(t => new { t.IdHipoteca, t.IdValija, t.IdTipoArea, t.OficinaNoCuenta, t.NoCuentaPrestamo, t.NoHipoteca, t.DeudaCierreFijacion, t.Ejecutar, t.FechaAlta });

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

            Property(t => t.ColegioNotarioFijacion)
                .HasMaxLength(50);

            Property(t => t.NotarioFijacion)
                .HasMaxLength(500);

            Property(t => t.Registro)
                .HasMaxLength(500);

            Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

            Property(t => t.EntidadOrigen)
                .HasMaxLength(250);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("vHip_HipotecaEnEjecucion");
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
            Property(t => t.ColegioNotarioFijacion).HasColumnName("ColegioNotarioFijacion");
            Property(t => t.NotarioFijacion).HasColumnName("NotarioFijacion");
            Property(t => t.Registro).HasColumnName("Registro");
            Property(t => t.CuotasCantidad).HasColumnName("CuotasCantidad");
            Property(t => t.CuotasValor).HasColumnName("CuotasValor");
            Property(t => t.CuotasFechaPrimera).HasColumnName("CuotasFechaPrimera");
            Property(t => t.CuotasFechaUltima).HasColumnName("CuotasFechaUltima");
            Property(t => t.TipoInteresInicial).HasColumnName("TipoInteresInicial");
            Property(t => t.TipoInteresUltimo).HasColumnName("TipoInteresUltimo");
            Property(t => t.TipoInteresMoratorio).HasColumnName("TipoInteresMoratorio");
            Property(t => t.FechaModificacionTipoInteres).HasColumnName("FechaModificacionTipoInteres");
            Property(t => t.FechaPrimeraCuotaImpagada).HasColumnName("FechaPrimeraCuotaImpagada");
            Property(t => t.FechaCierre).HasColumnName("FechaCierre");
            Property(t => t.DemandaFecha).HasColumnName("DemandaFecha");
            Property(t => t.Ejecutar).HasColumnName("Ejecutar");
            Property(t => t.DiferencialIndiceReferenciaHipotecaria).HasColumnName("DiferencialIndiceReferenciaHipotecaria");
            Property(t => t.DemandaSucesionBancaria).HasColumnName("DemandaSucesionBancaria");
            Property(t => t.DemandaBurofaxNoNotificado).HasColumnName("DemandaBurofaxNoNotificado");
            Property(t => t.NovacionFechaFinPeriodoCarencia).HasColumnName("NovacionFechaFinPeriodoCarencia");
            Property(t => t.NovacionNoCuotas).HasColumnName("NovacionNoCuotas");
            Property(t => t.NovacionFechaPeriodoAmortizacionInicio).HasColumnName("NovacionFechaPeriodoAmortizacionInicio");
            Property(t => t.NovacionFechaPeriodoAmortizacionFin).HasColumnName("NovacionFechaPeriodoAmortizacionFin");
            Property(t => t.NovacionComision).HasColumnName("NovacionComision");
            Property(t => t.FechaActaFijacion).HasColumnName("FechaActaFijacion");
            Property(t => t.Carencia).HasColumnName("Carencia");
            Property(t => t.Diferencial).HasColumnName("Diferencial");
            Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
            Property(t => t.EntidadOrigen).HasColumnName("EntidadOrigen");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
        }
    }
}
