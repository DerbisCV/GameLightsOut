namespace Solvtio.Models
{
    public class ModelTipoEstado : ModelEntityBase
    {
        #region Constructors
        public ModelTipoEstado() { }
        public ModelTipoEstado(int idTipoEstado, string descripcion)
            : base(idTipoEstado, descripcion) 
        {
        }

        public ModelTipoEstado(Gnr_TipoEstado tipoEstado)
        {
            Id = tipoEstado.IdTipoEstado;
            Name = tipoEstado.Descripcion;
            TipoExpediente = (TipoExpedienteEnum)tipoEstado.IdTipoExpediente;
        }
        #endregion

        #region Properties
        public TipoExpedienteEnum TipoExpediente { get; set; }
        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
