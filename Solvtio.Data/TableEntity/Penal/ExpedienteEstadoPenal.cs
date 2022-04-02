using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoPenal")]
    public class ExpedienteEstadoPenal : IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoPenal()
        {
        }
        public ExpedienteEstadoPenal(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }
        public ExpedienteEstadoPenal(int? idExpediente)
        {
            if (idExpediente.HasValue) IdExpediente = idExpediente.Value;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }



        public int? IdOpcionSubfase { get; set; }
        [ForeignKey("IdOpcionSubfase")]
        public virtual CaracteristicaBase OpcionSubfase { get; set; }

        public string NoAuto { get; set; }

        public int? IdJuzgado { get; set; }
        [ForeignKey("IdJuzgado")]
        public virtual Juzgado Juzgado { get; set; }

        internal void RefreshBy(ExpedienteEstadoPenal model)
        {
            NoAuto = model.NoAuto;
            IdOpcionSubfase = model.IdOpcionSubfase;
            IdJuzgado = model.IdJuzgado;
        }

        //public bool PendienteDocumentacion { get; set; }
        //public bool BurofaxFiadores { get; set; }
        //public bool PagosACuenta { get; set; }




        #endregion
    }
}
