using Solvtio.Models;
using System;

namespace Solvtio.Data.Models.Dtos
{
    public class EstadoDtoMin
    {
        public EstadoDtoMin() { }
        public EstadoDtoMin(ExpedienteEstado model)
        {
            if (model == null) return;
            
            IdExpedienteEstado = model.ExpedienteEstadoId;
            Fecha = model.Fecha;
            Tipo = new DtoIdNombre(model.IdTipoEstado, model.Gnr_TipoEstado.Nombre);
        }

        public int IdExpedienteEstado { get; set; }
        public DateTime Fecha { get; set; }
        public DtoIdNombre Tipo { get; set; }
    }

    public class EstadoDto : EstadoDtoMin
    {
        public int IdExpediente { get; set; }
    }


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
