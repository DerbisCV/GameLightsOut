using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Esp
{
    public class ModelAlquilerInfoCliente
    {
        public string Cedente { get; set; }
        public string TipoProcedimiento { get; set; }
        public string ServiciosSociales { get; set; }
        public string TipoInmueble { get; set; }
        public string AccionPropuesta { get; set; }

        public DateTime? FechaPropuesta { get; set; }
        public int? IdAlqContrato { get; set; }

        public string DecisionSareb { get; set; }
        public string FechaDecisionSareb { get; set; }
        public string CodigoActivoCedente { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string ReferenciaCatastral { get; set; }
        public string ReferenciaExternaMACRO { get; set; }

        public string Arrend_1_Doc { get; set; }
        public string Arrendatario1 { get; set; }
        public string Arrend_1_Tel { get; set; }
        public string Arrend_2_Doc { get; set; }
        public string Arrendatario2 { get; set; }
        public string Arrend_2_Tel { get; set; }
        public string FechaAntiguedadDeuda { get; set; }

        public string AbogadoExpediente { get; set; }
        public string AbogadoEstado { get; set; }
        public string Procurador { get; set; }




        public DateTime? FechaContrato { get; set; }
 

        public decimal? DeudaDemanda { get; set; }
        public decimal? ImporteReciboInicial { get; set; }
        public decimal? Fianza { get; set; }
        public decimal? GarantiaAdicional { get; set; }
        public string TipoGarantiaAdicional { get; set; }

   
        // = EAb.NombreApellidos,
        //    = EEAb1.NombreApellidos,
        //    = Procurador.NombreApellidos,
        //   E.NoAuto,
        //   Juzgado = J.Nombre,
        //FechaOrigenIncidencia = '',
        //   AsucionDeCostes = '',
        //   ProcedimientoActual = Procedimiento.Etiqueta,
        //   EstadoDemanda = EstadoDemanda.Etiqueta,
        //   DeudaReclamada = EA.DeudaInicial,
        //FechaPresentacionDemanda = EE75.FechaPresentacion,
        //FechaVista = EVC.Fecha,
        //FechaEstadoLanzamiento = ISNULL(EE77.FechaCelebracionLanzamiento1, EE77.Fecha),
        //UltimoLanzamiento = EVL.Fecha,
        //TomadaPosesion = EE79.EntregaPosesion,
        //FechaSentencia1raInstancia = ISNULL(EE76.OposicionFechaDecretoFin, EE76.OposicionFechaSentencia), 
        //FechaRecurso = EE76.OposicionFechaRecursoApelacion,
        //   FechaSentencia2daInstancia = EE76.FechaSentencia2,
        //   FechaAdmisionDemanda = EE76.AdmitidaFecha,
        //   Observaciones = TEC.Descripcion,
        //   EA.DeudaRecuperada,
        //   EA.ImporteCostas,
        //   EA.ImporteCondonacion,
        //   InformacionMediador = CASE
        //       WHEN TEC.Descripcion IS NULL THEN '-'

        //       WHEN TEC.Descripcion LIKE '%2.4%' THEN 'Mediación'

        //       WHEN TEC.Descripcion LIKE '%3.4%' THEN 'Pase a social'

        //       ELSE ''

        //   END,
        //   RentaPropuesta = '',
        //   EstadoVivienda = '',
        //   ClienteOficina = CO.Nombre,
        //   Cliente = C.Nombre,
        //   E.NoExpediente,
        //   E.ReferenciaExterna,
        //   EstadoActual = EET.Descripcion,
        //   FechaFinalizacion = EE79.Fecha,
        //   SubFase = EELastF.Nombre,
        //   ParalizadoPor = CASE

        //       WHEN EELast.IdTipoEstado = 73 THEN EE73.ParalizadoPor
        //       WHEN EELast.IdTipoEstado = 75 THEN EE75.ParalizadoPor
        //       ELSE ''

        //   END,
        //   EE76.SuspensionObservaciones,
        //   MotivoSuspension = EE76Motivo.Descripcion,
        //   EA.FechaEnvioBurofax,
        //   EA.FechaRecepcionBurofax,
        //   IdExpEjecutivoVinculado = EA.IdExpedienteEjc,
        //   IdentifCliente = EA.ReferenciaExternaMSGI,
        //   Segmento = IIF(EA.Segmento = 1, 'Retail', IIF(EA.Segmento = 2, 'Profesional', '')),
        //   FechaPresentaciondenuncia= EE5131.FechaPresentacion,
        //   FechaDenunciaAdmitida= EE5132.AdmitidaFecha,
        //   E.IdExpediente

        public DateTime? SucesionRecurrida { get; set; }
        public string SucesionResultadoRecuso { get; set; }
        public string Cliente { get; set; }
        public string Oficina { get; set; }
        public string Tipo { get; set; }
        public string Area { get; set; }
        public decimal? DeudaFinal { get; set; }
        public string FechaCierre { get; set; }
        public string Deudor { get; set; }
        public string JuzgadoName { get; set; }
        public string PartidoJudicial { get; set; }
        public string H1Factura { get; set; }
        public DateTime? H1Fecha { get; set; }
        public decimal? H1Importe { get; set; }
        public string H2Factura { get; set; }
        public DateTime? H2Fecha { get; set; }
        public decimal? H2Importe { get; set; }
        public string Estado { get; set; }
        public string Fase { get; set; }
        public DateTime? Fecha { get; set; }
        public string Incidencia { get; set; }
        public DateTime? Resolucion { get; set; }
        public DateTime? ImpulsoFecha { get; set; }
        public string ImpulsoNota { get; set; }
        public string AbogadoEstado1 { get; set; }
        public string AbogadoEstado2 { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool Paralizado { get; set; }
        public DateTime? ParalizadoFecha { get; set; }
        public string ParalizadoMotivo { get; set; }
        public DateTime? UltimaNotaFecha { get; set; }
        public string UltimaNota { get; set; }
        public string UltimaNotaUsuario { get; set; }
        public int IdExpediente { get; set; }
    }
}
