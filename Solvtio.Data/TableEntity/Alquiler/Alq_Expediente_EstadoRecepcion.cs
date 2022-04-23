namespace Solvtio.Models
{
    public class Alq_Expediente_EstadoRecepcion : EstadoRecepcionBase
    {
        public int ID { get; set; }

        //public int IdExpedienteEstado { get; set; }
        //public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        //public DateTime? FechaResolucionIncidenciaDocumental { get; set; }

        public bool PendienteDocumentacion { get; set; }
        public bool BurofaxFiadores { get; set; }
        public bool PagosACuenta { get; set; }

        public string ParalizadoPor { get; set; }

    }
}
