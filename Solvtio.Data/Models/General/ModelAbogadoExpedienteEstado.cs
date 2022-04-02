using System;
using System.Collections.Generic;
using Solvtio.Common;
using Solvtio.Models;
using System.Linq;

namespace Solvtio.Esp.Datos
{
    public class ModelAbogadoExpedienteEstado
    {
		#region Constructors

		public ModelAbogadoExpedienteEstado()
		{
		}
        public ModelAbogadoExpedienteEstado(ModelFilterBase filter)
        {
            Filter = filter;

            ResumenAbogado = new ResumenAbogado();
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
        public List<ModelExpedienteEstadoReducido> LstModelExpReducido { get; set; }

        public Gnr_Persona Abogado { get; set; }
        public List<Gnr_Persona> LstAbogados { get; set; }

        public List<MesEstadistica> LstMesEstadistica { get; set; }

        public ResumenAbogado ResumenAbogado { get; set; }

        #endregion

        #region Properties ReadOnly

        public List<int?> LstAbogadosIdArea => LstAbogados.Select(x => x.Gnr_Abogado?.IdArea).Distinct().ToList();

        #endregion
    }

    public class MesEstadistica
    {
        public int NoMes { get; set; }
        public int TotalExpedientes { get; set; }
        public int TotalVencimientosEjecutados { get; set; }
        public int TotalVencimientosNoEjecutados { get; set; }
        public int TotalGestionesEjecutadas { get; set; }
        public int TotalGestionesNoEjecutadas { get; set; }
        public int TotalVistas { get; set; }
        public int TotalImpulsos { get; set; }
        public int TotalEscritos { get; set; }
    }

    public class ResumenAbogado
    {
        public int NotificacionMailAsignadas { get; set; }
        public int NotificacionMailFinalizadas { get; set; }
        public int NotificacionMailPendientes { get; set; }
        
        public int TotalImpulsos { get; set; }
        public int TotalEscritos { get; set; }

        public int KpiInicio { get; set; }
        public int KpiFinal { get; set; }
    }
}
