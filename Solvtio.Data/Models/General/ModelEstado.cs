using System;

namespace Solvtio.Models
{
    public class ModelEstado : ModelEntityBase
    {
        #region Constructors
        public ModelEstado() { }
        public ModelEstado(int idEstado, string observacion, DateTime fecha, int tipoEstado, string nameTipoEstado)
            : base(idEstado, observacion) 
        {
            Fecha = fecha;
            TipoEstado = new ModelTipoEstado(tipoEstado, nameTipoEstado);
        }

		public ModelEstado(ExpedienteEstado _expedienteEstado)
        {
			if (_expedienteEstado != null)
            {
                Id = _expedienteEstado.ExpedienteEstadoId;
                Name = _expedienteEstado.Gnr_TipoEstado.Descripcion;
                Fecha = _expedienteEstado.Fecha;
                TipoEstado = new ModelTipoEstado(_expedienteEstado.Gnr_TipoEstado);
            }
        }
        #endregion

        #region Properties
        public DateTime Fecha { get; set; }
        public ModelTipoEstado TipoEstado { get; set; }

		private ExpedienteEstado _expedienteEstado;
		public ExpedienteEstado ExpedienteEstado
		{
			get
			{
				return _expedienteEstado;
			}
			set
			{
				_expedienteEstado = value;
				if (_expedienteEstado != null)
					setExpedienteEstado(_expedienteEstado);
			}
		}

		private void setExpedienteEstado(ExpedienteEstado _expedienteEstado)
		{
            Id = _expedienteEstado.ExpedienteEstadoId;
            Name = _expedienteEstado.Gnr_TipoEstado.Descripcion;
            Fecha = _expedienteEstado.Fecha;
            TipoEstado = new ModelTipoEstado(_expedienteEstado.Gnr_TipoEstado);
		}
        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
