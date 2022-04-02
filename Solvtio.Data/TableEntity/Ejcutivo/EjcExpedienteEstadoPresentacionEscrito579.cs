using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("EjcExpedienteEstadoPresentacionEscrito579")]
    public class EjcExpedienteEstadoPresentacionEscrito579
    {
        #region Constructors

        public EjcExpedienteEstadoPresentacionEscrito579()
        {
        }
        public EjcExpedienteEstadoPresentacionEscrito579(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        #endregion

        #region Properties

        //[Key, ForeignKey("ExpedienteEstado")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Required]


        [Key, ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }
        public DateTime? FechaPresentacion { get; set; }
        public DateTime? FechaEnvioProcurador { get; set; }



        public DateTime? NoAdmitidaFecha { get; set; }
        public int? IdMotivoInadmision { get; set; }
        [ForeignKey("IdMotivoInadmision")]
        public virtual Gnr_TipoEstadoMotivo MotivoInadmision { get; set; }
        public string InadmisionDetalles { get; set; }

        #endregion
    }
}
