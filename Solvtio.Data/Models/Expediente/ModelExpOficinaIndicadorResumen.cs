using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelExpOficinaIndicadorResumen
    {
        #region Constructors

        public ModelExpOficinaIndicadorResumen() { }
        public ModelExpOficinaIndicadorResumen(ModelFilterBase filter)
        {
            Filter = filter;
        }
        public ModelExpOficinaIndicadorResumen(ModelFilterBase filter, List<Expediente> lstExpedientes)
        {
            Filter = filter;
            LstExpediente = lstExpedientes;

            if (lstExpedientes.IsNotEmpty())
            {                
                LstTipoExpediente = new List<TipoExpedienteEnum>();
                LstOficina = new List<Gnr_ClienteOficina>();
                LstIndicadores = new List<ModelExpOficinaIndicador>();
                foreach (var idTipoExp in lstExpedientes.Select(x => x.IdTipoExpediente).Distinct().ToList())
                {
                    var tipoExp = (TipoExpedienteEnum)idTipoExp;
                    LstTipoExpediente.Add((TipoExpedienteEnum)idTipoExp);

                    foreach (var idOficina in lstExpedientes.Select(x => x.IdClienteOficina).Distinct().ToList())
                    {
                        var oficina = LstOficina.FirstOrDefault(x => x.IdClienteOficina == idOficina);
                        if (oficina == null)
                        {
                            oficina = lstExpedientes.First(x => x.IdClienteOficina == idOficina).Gnr_ClienteOficina;
                            LstOficina.Add(oficina);
                        }
                        
                        var indicador = new ModelExpOficinaIndicador(idTipoExp, oficina, lstExpedientes);
                    }               
                }

                FillLstAreaTipoExpediente();
            } 
        }

        private void FillLstAreaTipoExpediente()
        {
            LstAreaTipoExpediente = new List<ModelAreaTipoExpData>();
            if (LstExpediente.IsEmpty()) return;

            #region Add REI / LEGAL / RECUPERACIONES

            FillLstAreaTipoExpedienteDetail("CyM", TipoExpedienteEnum.Concurso);
            FillLstAreaTipoExpedienteDetail("LEGAL", TipoExpedienteEnum.Penal);
            FillLstAreaTipoExpedienteDetail("LEGAL", TipoExpedienteEnum.MercantilInmobiliario);

            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.Hipotecario);
            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.Ejecutivo);
            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.Ordinario);
            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.JurisdiccionVoluntaria);
            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.Verbal);
            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.Monitorio);
            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.JuraCuenta);
            FillLstAreaTipoExpedienteDetail("RECUPERACIONES", TipoExpedienteEnum.TomaPosesionAnticipada);

            #endregion

            #region Add ALQUILER

            foreach (var tipoExp in LstTipoExpediente)
                FillLstAreaTipoExpedienteDetail("ALQUILER", tipoExp);

            #endregion

        }

        private void FillLstAreaTipoExpedienteDetail(string areaName, TipoExpedienteEnum tipoExpedienteEnum)
        {
            var idTipoExp = (int)tipoExpedienteEnum;
            var query = LstExpediente.Where(x => x.IdTipoExpediente == idTipoExp);
            if (areaName == "ALQUILER")
                query = query.Where(x => x.IdTipoArea == 3);
            else
                query = query.Where(x => x.IdTipoArea != 3);

            var total = query.Count();
            if (total == 0) return;

            var newModel = new ModelAreaTipoExpData(areaName, tipoExpedienteEnum);

            newModel.Count01 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 1);
            newModel.Count02 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 2);
            newModel.Count03 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 3);
            newModel.Count04 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 4);
            newModel.Count05 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 5);
            newModel.Count06 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 6);
            newModel.Count07 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 7);
            newModel.Count08 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 8);
            newModel.Count09 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 9);
            newModel.Count10 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 10);
            newModel.Count11 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 11);
            newModel.Count12 = query.Count(x => x.Inicio.HasValue && x.Inicio.Value.Month == 12);

            //newModel.CountOut01 = query.Count(x => x.Fin.HasValue && x.Fin.Value.Month == 1 );

            LstAreaTipoExpediente.Add(newModel);
        }
               
        #endregion

        #region Properties

        public ModelFilterBase Filter { get; set; }
        public List<Expediente> LstExpediente { get; set; }
        public List<TipoExpedienteEnum> LstTipoExpediente { get; set; }
        public List<Gnr_ClienteOficina> LstOficina { get; set; }
        public List<ModelExpOficinaIndicador> LstIndicadores { get; set; }

        public List<ModelAreaTipoExpData> LstAreaTipoExpediente { get; set; }
        public List<ModelClienteTipoExpData> LstClienteTipoExpediente { get; set; }

        #endregion
    }

    public class ModelAreaTipoExpData
    {
        #region Constructors

        public ModelAreaTipoExpData() { }

        public ModelAreaTipoExpData(string areaName, TipoExpedienteEnum tipoExpedienteEnum)
        {
            AreaName = areaName;
            TipoExpediente = tipoExpedienteEnum;
        }

        #endregion

        #region Properties

        public string AreaName { get; set; }
        public TipoExpedienteEnum TipoExpediente { get; set; }

        public int? Count01 { get; set; }
        public int? Count02 { get; set; }
        public int? Count03 { get; set; }
        public int? Count04 { get; set; }
        public int? Count05 { get; set; }
        public int? Count06 { get; set; }
        public int? Count07 { get; set; }
        public int? Count08 { get; set; }
        public int? Count09 { get; set; }
        public int? Count10 { get; set; }
        public int? Count11 { get; set; }
        public int? Count12 { get; set; }
        public int CountTotal => 
            (Count01 ?? 0) +
            (Count02 ?? 0) +
            (Count03 ?? 0) +
            (Count04 ?? 0) +
            (Count05 ?? 0) +
            (Count06 ?? 0) +
            (Count07 ?? 0) +
            (Count08 ?? 0) +
            (Count09 ?? 0) +
            (Count10 ?? 0) +
            (Count11 ?? 0) +
            (Count12 ?? 0);


        public int? CountOut01 { get; set; }
        public int? CountOut02 { get; set; }
        public int? CountOut03 { get; set; }
        public int? CountOut04 { get; set; }
        public int? CountOut05 { get; set; }
        public int? CountOut06 { get; set; }
        public int? CountOut07 { get; set; }
        public int? CountOut08 { get; set; }
        public int? CountOut09 { get; set; }
        public int? CountOut10 { get; set; }
        public int? CountOut11 { get; set; }
        public int? CountOut12 { get; set; }
        public int CountOutTotal =>
            (CountOut01 ?? 0) +
            (CountOut02 ?? 0) +
            (CountOut03 ?? 0) +
            (CountOut04 ?? 0) +
            (CountOut05 ?? 0) +
            (CountOut06 ?? 0) +
            (CountOut07 ?? 0) +
            (CountOut08 ?? 0) +
            (CountOut09 ?? 0) +
            (CountOut10 ?? 0) +
            (CountOut11 ?? 0) +
            (CountOut12 ?? 0);


        public int? CountCurrent01 { get; set; }
        public int? CountCurrent02 { get; set; }
        public int? CountCurrent03 { get; set; }
        public int? CountCurrent04 { get; set; }
        public int? CountCurrent05 { get; set; }
        public int? CountCurrent06 { get; set; }
        public int? CountCurrent07 { get; set; }
        public int? CountCurrent08 { get; set; }
        public int? CountCurrent09 { get; set; }
        public int? CountCurrent10 { get; set; }
        public int? CountCurrent11 { get; set; }
        public int? CountCurrent12 { get; set; }
        public int CountCurrentTotal =>
            (CountCurrent01 ?? 0) +
            (CountCurrent02 ?? 0) +
            (CountCurrent03 ?? 0) +
            (CountCurrent04 ?? 0) +
            (CountCurrent05 ?? 0) +
            (CountCurrent06 ?? 0) +
            (CountCurrent07 ?? 0) +
            (CountCurrent08 ?? 0) +
            (CountCurrent09 ?? 0) +
            (CountCurrent10 ?? 0) +
            (CountCurrent11 ?? 0) +
            (CountCurrent12 ?? 0);

        public int? CountStock { get; set; }

        #endregion
    }


    public class ModelClienteTipoExpData
    {
        #region Constructors

        public ModelClienteTipoExpData() { }

        public ModelClienteTipoExpData(string clienteName, TipoExpedienteEnum tipoExpedienteEnum, decimal costeTotal = 0)
        {
            ClienteName = clienteName;
            TipoExpediente = tipoExpedienteEnum;
            CosteTotal = costeTotal;
        }

        #endregion

        #region Properties

        public string ClienteName { get; set; }
        public TipoExpedienteEnum TipoExpediente { get; set; }

        public int? CountIn { get; set; }
        public int? CountOut { get; set; }
        public int? CountStock { get; set; }
        public int? CountAbogados { get; set; }

        public decimal? SumFacturado { get; set; }
        public decimal? SumFacturadoAnterior { get; set; }
        public decimal CosteTotal { get; set; }

        #endregion
    }

}
