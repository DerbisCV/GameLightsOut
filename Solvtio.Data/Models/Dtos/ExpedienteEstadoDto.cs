using Solvtio.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Data.Models.Dtos
{
    [NotMapped]
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

    [NotMapped]
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
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaModificado { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? IncidenciaFechaResolucion { get; set; }

        public int IdTipoEstado { get; set; }
        public DtoIdNombre TipoEstado { get; set; }
        public string Observacion { get; set; }
        public int? IdTipoSubFaseEstado { get; set; }
        public int? IdTipoSubFaseCliente { get; set; }
        public int? IdTipoIncidenciaEstado { get; set; }

        public string Usuario { get; set; }


        //public ModelDtoNombre FaseEstado { get; set; } IdTipoEstado

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
