using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Neg_GestionEstado
    {
        #region Constructors

        public Neg_GestionEstado()
        {
            Fecha = FechaAlta = DateTime.Now;
        }

        public Neg_GestionEstado(int? idExpediente) : base()
        {
            Fecha = FechaAlta = DateTime.Now;
            if (idExpediente.HasValue) IdExpediente = idExpediente.Value;
        }

        #endregion

        #region Properties

        public int GestionEstadoId { get; set; }
        public int IdExpediente { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTipoEstado { get; set; }
        public string Observacion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }
        public virtual Gnr_TipoEstado Gnr_TipoEstado { get; set; }
        public virtual Neg_Gestion Neg_Gestion { get; set; }

        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(Neg_GestionEstado model)
        {
            Fecha = model.Fecha;
            Observacion = model.Observacion;
            IdAbogado = model.IdAbogado;
        }

        #endregion
    }
}
