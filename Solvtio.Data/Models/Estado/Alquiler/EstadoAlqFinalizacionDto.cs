namespace Solvtio.Data.Models.Estado.Alquiler
{
    public class EstadoAlqFinalizacionDto : EstadoAlqFinalizacionPoco
    {   
    }

    public class EstadoAlqFinalizacionPoco
    {
        public int IdExpedienteEstado { get; set; }
        public int? IdMotivo { get; set; }

        public bool PagoDeuda { get; set; }
        public bool EntregaPosesion { get; set; }
        public bool DesestimacionDemanda { get; set; }

        public bool Llaves { get; set; }
        public bool EnervacionJudicial { get; set; }
        public bool DesestimientoJudicial { get; set; }
        public bool PorAcuerdo { get; set; }
        public bool ParalizacionInstCliente { get; set; }
        public bool Mediacion { get; set; }
        public bool CondonacionSinProceso { get; set; }
        public bool Facturable { get; set; }
        public bool Precontencioso { get; set; }
        public bool SentenciaEstimatoria { get; set; }

        public bool Archivo { get; set; }
        public bool ArchivoProvisional { get; set; }
        public bool CesionVenia { get; set; }
    }
}
