using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelInformeHitosProcesales
    {
        #region Constructors

        public ModelInformeHitosProcesales()
        {
			CreateBase();
        }

        public ModelInformeHitosProcesales(ModelFilterBase filter)
        {
            CreateBase();
            Filter = filter;
        }

        private void CreateBase()
        {
            Filter = new ModelFilterBase();
            LstExpedienteHitoProcesal = new List<ExpedienteHitoProcesal>();
        }

        #endregion

        #region Properties

        public ModelFilterBase Filter { get; set; }
        public List<ExpedienteHitoProcesal> LstExpedienteHitoProcesal { get; set; }

		#endregion

		#region Properties ReadOnly
		#endregion		
	}

    //public class ModelNotaGeneral
    //{
    //    public ModelNotaGeneral() {}
    //    public ModelNotaGeneral(ExpedienteEstado item)
    //    {
    //        Titulo = $"Estado: {item.TipoEstadoValue.GetDescription()}";
    //        Fecha = item.Fecha;
    //        Descripcion = item.Observacion;
    //    }
    //    public ModelNotaGeneral(ExpedienteNota item)
    //    {
    //        Titulo = $"Nota: {item.NoteType.GetDescription()}";
    //        Fecha = item.Fecha;
    //        Descripcion = item.Nota;
    //    }
    //    public ModelNotaGeneral(Impulso item)
    //    {
    //        Titulo = $"Impulso: {item.TipoImpulso.GetDescription()}";
    //        Fecha = item.Fecha;
    //        Descripcion = item.Observaciones;
    //    }

    //    public DateTime Fecha { get; set; }
    //    public string Titulo { get; set; }
    //    public string Descripcion { get; set; }
    //}
}
