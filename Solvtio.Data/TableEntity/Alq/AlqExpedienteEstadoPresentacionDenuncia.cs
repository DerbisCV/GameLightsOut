using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("AlqExpedienteEstadoPresentacionDenuncia")]
    public class AlqExpedienteEstadoPresentacionDenuncia
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        public DateTime? FechaPresentacion { get; set; }
        public DateTime? FechaEnvioProcurador { get; set; }
        public bool PresentadaMedidaCautelar { get; set; }

        public DateTime? NoAdmitidaFecha { get; set; }
        //public DateTime? NoAdmitidaFechaApelacion { get; set; }

        public DateTime? NoAdmitidaFechaReforma { get; set; }
        public DateTime? NoAdmitidaFechaReformaApelacion { get; set; }
    }
}
