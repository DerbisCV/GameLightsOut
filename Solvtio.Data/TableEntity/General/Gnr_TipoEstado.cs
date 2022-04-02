using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Gnr_TipoEstado : IDescripcion
    {
        public Gnr_TipoEstado()
        {
            Inactivo = false;
            Inicio = Fin = Paralizado = false;
            Orden = 100;

            ExpedienteEstadoes = new List<ExpedienteEstado>();
            Neg_GestionEstado = new List<Neg_GestionEstado>();
        }

        #region Properties

        [Key]
        public int IdTipoEstado { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoExpediente { get; set; }
        public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }
        public string Clave { get; set; }
        public bool Inactivo { get; set; }
        public bool Inicio { get; set; }
        public bool Fin { get; set; }
        public bool Hito1 { get; set; }
        public bool Hito2 { get; set; }
        public bool Hito3 { get; set; }
        public bool Paralizado { get; set; }
        public int Orden { get; set; }

        public string ClientePhaseCoded { get; set; }

        public TipoFaseEstado? FaseEstadoInicio { get; set; }

        public int? IdArea { get; set; }
        [ForeignKey("IdArea")]
        public virtual Area Area { get; set; }

        #endregion

        #region Properties One To Many

        public virtual ICollection<ExpedienteEstado> ExpedienteEstadoes { get; set; }
        public virtual ICollection<Neg_GestionEstado> Neg_GestionEstado { get; set; }
        public virtual ICollection<Gnr_TipoEstadoMotivo> TipoEstadoMotivoSet { get; set; }

        public virtual ICollection<TramiteJudicial> TramiteJudicialSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public TipoExpedienteEnum TipoExpediente => (TipoExpedienteEnum)IdTipoExpediente;
        public ExpedienteEstadoTipo? TipoEstado => (ExpedienteEstadoTipo?)IdTipoEstado;

        #endregion
    }
}
