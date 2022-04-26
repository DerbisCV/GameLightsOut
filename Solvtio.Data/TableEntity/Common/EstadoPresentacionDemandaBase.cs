using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{

    public class EstadoPresentacionDemandaBase
    {
        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime? FechaPresentacion { get; set; }
        public DateTime? FechaEnvioProcurador { get; set; }


        //public int? IdIncidenciaProcesal { get; set; }
        //[ForeignKey("IdIncidenciaProcesal")]
        //public virtual CaracteristicaBase IncidenciaProcesal { get; set; }

        //public DateTime? IncidenciaProcesalFechaResolucion { get; set; }

    }

}
