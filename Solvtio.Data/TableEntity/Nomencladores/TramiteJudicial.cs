using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("TramiteJudicial")]
    public class TramiteJudicial : INombre
    {
        #region Constructors

        public TramiteJudicial(){ Activo = true; }
        public TramiteJudicial(string tramite)
        {
            Nombre = tramite;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTramiteJudicial { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public int? IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        public virtual Gnr_TipoEstado Estado { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<JuzgadoTramiteJudicial> JuzgadoTramiteJudicialSet { get; set; }
        //public virtual ICollection<HipExpedienteEstadoTramitacionSubasta> HipExpedienteEstadoTramitacionTramiteJudicialSet { get; set; }
        //public virtual ICollection<ExpedienteOrdinarioCs> ExpedienteOrdinarioCsSet { get; set; }
        //public virtual ICollection<ExpedienteJurisdiccionVoluntaria> ExpedienteJurisdiccionVoluntariaSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
