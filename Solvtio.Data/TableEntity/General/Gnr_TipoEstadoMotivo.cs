using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Gnr_TipoEstadoMotivo : IDescripcion
    {
        #region Constructors

        public Gnr_TipoEstadoMotivo()
        {
            //Ejc_ExpedienteEstadoFinalizacion = new List<Ejc_ExpedienteEstadoFinalizacion>();
            //Hip_ExpedienteEstadoFinalizacion = new List<Hip_ExpedienteEstadoFinalizacion>();
            //Hip_ExpedienteEstadoProcesoParalizado = new List<Hip_ExpedienteEstadoProcesoParalizado>();
        }

        #endregion

        #region Properties

        public int IdMotivo { get; set; }
        public string Descripcion { get; set; }

        public int IdTipoEstado { get; set; }
        [ForeignKey("IdTipoEstado")]
        public virtual Gnr_TipoEstado Gnr_TipoEstado { get; set; }

        public int Id => IdMotivo;
        public string Nombre => Descripcion;

        #endregion

        #region Properties One To Many

        //      public virtual ICollection<Ejc_ExpedienteEstadoFinalizacion> Ejc_ExpedienteEstadoFinalizacion { get; set; }
        //      public virtual ICollection<Hip_ExpedienteEstadoFinalizacion> Hip_ExpedienteEstadoFinalizacion { get; set; }
        //      public virtual ICollection<Hip_ExpedienteEstadoProcesoParalizado> Hip_ExpedienteEstadoProcesoParalizado { get; set; }
        //public virtual ICollection<Hip_ExpedienteEstadoSubasta> Hip_ExpedienteEstadoSubastaSet { get; set; }
        //      public virtual ICollection<ExpedienteEstadoParalizado> ExpedienteEstadoParalizadoSet { get; set; }
        //      public virtual ICollection<Alq_Expediente_EstadoFinalizacion> AlqExpedienteEstadoFinalizacionSet { get; set; }

        #endregion
    }
}
