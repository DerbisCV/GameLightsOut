using System;

namespace Solvtio.Data.Models.Dtos
{
    public class ExpedienteEstadoDto
    {

        #region Properties

        public int ExpedienteEstadoId { get; set; }
        public int IdExpedienteEstado => ExpedienteEstadoId;
        
        public int IdExpediente { get; set; }
        public DateTime Fecha { get; set; }
        public ModelDtoNombre TipoEstado { get; set; }


        //public ModelDtoNombre FaseEstado { get; set; }

        //public int? IdTipoSubFaseEstado { get; set; }
        //[ForeignKey("IdTipoSubFaseEstado")]
        //public virtual TipoSubFaseEstado TipoSubFaseEstado { get; set; }

        //public int? IdTipoSubFaseCliente { get; set; }
        //[ForeignKey("IdTipoSubFaseCliente")]
        //public virtual CaracteristicaBase TipoSubFaseCliente { get; set; }

        //public int? IdTipoIncidenciaEstado { get; set; }
        //[ForeignKey("IdTipoIncidenciaEstado")]
        //public virtual TipoIncidenciaEstado TipoIncidenciaEstado { get; set; }

        //public DateTime? IncidenciaFechaResolucion { get; set; }

        //public int TimeWorkedMinutes { get; set; }

        #endregion

    }
}
