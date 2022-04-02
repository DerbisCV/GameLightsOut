using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelExpOficinaIndicador
    {
        #region Constructors

        public ModelExpOficinaIndicador() { }
        public ModelExpOficinaIndicador(int idTipoExp, Gnr_ClienteOficina oficina, List<Expediente> lstExpedientes)
        {
            TipoExpediente = (TipoExpedienteEnum)idTipoExp;
            Oficina = oficina;

            var query = lstExpedientes.Where(x => x.IdTipoExpediente == idTipoExp && x.IdClienteOficina == oficina.IdClienteOficina);
            LstExpedientes = lstExpedientes;

            Count01 = query.Count(x => x.Inicio.Value.Month == 1);
            Count02 = query.Count(x => x.Inicio.Value.Month == 2);
            Count03 = query.Count(x => x.Inicio.Value.Month == 3);
            Count04 = query.Count(x => x.Inicio.Value.Month == 4);
            Count05 = query.Count(x => x.Inicio.Value.Month == 5);
            Count06 = query.Count(x => x.Inicio.Value.Month == 6);
            Count07 = query.Count(x => x.Inicio.Value.Month == 7);
            Count08 = query.Count(x => x.Inicio.Value.Month == 8);
            Count09 = query.Count(x => x.Inicio.Value.Month == 9);
            Count10 = query.Count(x => x.Inicio.Value.Month == 10);
            Count11 = query.Count(x => x.Inicio.Value.Month == 11);
            Count12 = query.Count(x => x.Inicio.Value.Month == 12);
        }

        public ModelExpOficinaIndicador(int year, int month, List<Expediente> lstExpedientes)
        {
            Year = year;
            Month = month;
            LstExpedientes = lstExpedientes;
        }

        #endregion

        #region Properties

        public TipoExpedienteEnum TipoExpediente { get; set; }
        public Gnr_ClienteOficina Oficina { get; set; }
        public List<Expediente> LstExpedientes { get; set; }

        public int Count01 { get; set; }
        public int Count02 { get; set; }
        public int Count03 { get; set; }
        public int Count04 { get; set; }
        public int Count05 { get; set; }
        public int Count06 { get; set; }
        public int Count07 { get; set; }
        public int Count08 { get; set; }
        public int Count09 { get; set; }
        public int Count10 { get; set; }
        public int Count11 { get; set; }
        public int Count12 { get; set; }

        public int Year { get; set; }
        public int Month { get; set; }

        #endregion

        #region Properties ReadOnly

        public int CountTotal => Count01 + Count02 + Count03 + Count04 + Count05 + Count06 + Count07 + Count08 + Count09 + Count10 + Count11 + Count12;

        #endregion

    }
}
