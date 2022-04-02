using System;
using System.Collections.Generic;
using System.Linq;
using Solvtio.Common;

namespace Solvtio.Models
{

    public class ModelCalendarioAll //: IModelCalendario
    {
        #region Constructors

        public ModelCalendarioAll()
        {
            Anio = DateTime.Now.Year;
            Mes = DateTime.Now.Month;

            LstAnios = GetListAnios();
            //LoadData();
        }

        public ModelCalendarioAll(DateTime fecha)
        {
            Anio = fecha.Year;
            Mes = fecha.Month;

            LoadData();
            LstAnios = GetListAnios();
        }

        public ModelCalendarioAll(int mes, int anio)
        {
            Anio = anio;
            Mes = mes;

            LoadData();
            LstAnios = GetListAnios();
        }
        public ModelCalendarioAll(ExpedienteEstadoTipo? tipoEstado, int mes, int anio, int? idArea = null, TipoExpedienteEnum? tipoExpediente = null, bool? tambienEjcAlq = false)
        {
            Anio = anio;
            Mes = mes;
            TipoEstado = tipoEstado;
            IdArea = idArea;
            if (tipoExpediente.HasValue)
                TipoExpediente = tipoExpediente.Value;
            TambienEjcAlq = tambienEjcAlq;

            LoadData();
            LstAnios = GetListAnios();
        }

        public ModelCalendarioAll(int mes, int anio, string grupo)
        {
            Anio = anio;
            Mes = mes;
            Grupo = grupo;

            LoadData();
            LstAnios = GetListAnios();
        }

        public ModelCalendarioAll(int mes, int anio, TipoExpedienteEnum? tipoExp)
        {
            Anio = anio;
            Mes = mes;
            TipoExpediente = tipoExp;

            LoadData();
            LstAnios = GetListAnios();
        }

        //
        public ModelCalendarioAll(int mes, int anio, CalendarType calendarType)
        {
            Anio = anio;
            Mes = mes;
            CalendarType = calendarType;

            LoadData();
            LstAnios = GetListAnios();
        }

        public ModelCalendarioAll(DateTime fecha, int countDays, string grupo)
        {
            FechaInicioSemana = fecha;
            Grupo = grupo;
            LoadData(fecha, countDays);
        }

        #endregion

        #region Properties

        public int Anio { get; set; }
        public int Mes { get; set; }
        public string Grupo { get; set; }
        public CalendarType CalendarType { get; set; }
        public TipoExpedienteEnum? TipoExpediente { get; set; }
        public ExpedienteEstadoTipo? TipoEstado { get; set; }
        public int? IdTipoVista { get; set; }
        public int? IdCliente { get; set; }
        public int? IdAbogado { get; set; }
        public int? IdArea { get; set; }
        public TipoVencimiento? TipoVencimientoSelected { get; set; }
        public bool? TambienEjcAlq { get; set; }
        public bool? Telematica { get; set; }

        public IList<ModelCalendarioSemana> Semanas { get; set; }
        public IList<ModelCalendarioDiaAll> Dias { get; set; }
        public IList<int> LstAnios { get; set; }

        public DateTime? FechaInicioSemana { get; set; }

        public List<ExpedienteVista> LstExpedienteVista { get; set; }

        #endregion

        #region Properties ReadOnly

        public int? IdTipoExpediente => TipoExpediente.HasValue ? (int)TipoExpediente : (int?)null;

        private List<ModelVistaResumen> _lstModelVistaResumen;
        public List<ModelVistaResumen> LstModelVistaResumen
        {
            get
            {
                if (_lstModelVistaResumen == null)
                {
                    List<ModelVistaResumen> tmpList = new List<ModelVistaResumen>();
                    foreach (var dia in Dias)
                    {
                        if (dia.ModelCalendarioDiaVistas != null)
                            foreach (var vistaResumen in dia.ModelCalendarioDiaVistas.LstModelVistaResumen)
                                tmpList.Add(vistaResumen);
                    }


                    _lstModelVistaResumen = new List<ModelVistaResumen>();
                    foreach (var clasificacion in tmpList.Select(x => x.Clasification).Distinct())
                    {
                        var vistaResumen = new ModelVistaResumen(clasificacion, tmpList.Where(x => x.Clasification == clasificacion).Sum(x => x.Count));
                        _lstModelVistaResumen.Add(vistaResumen);
                    }
                }

                return _lstModelVistaResumen;
            }
        }

        private string _mesNombre;
        public string MesNombre
        {
            get
            {
                //if (string.IsNullOrWhiteSpace(_mesNombre))
                //{
                switch (Mes)
                {
                    case 1:
                        _mesNombre = "Enero";
                        break;
                    case 2:
                        _mesNombre = "Febrero";
                        break;
                    case 3:
                        _mesNombre = "Marzo";
                        break;
                    case 4:
                        _mesNombre = "Abril";
                        break;
                    case 5:
                        _mesNombre = "Mayo";
                        break;
                    case 6:
                        _mesNombre = "Junio";
                        break;
                    case 7:
                        _mesNombre = "Julio";
                        break;
                    case 8:
                        _mesNombre = "Agosto";
                        break;
                    case 9:
                        _mesNombre = "Septiembre";
                        break;
                    case 10:
                        _mesNombre = "Octubre";
                        break;
                    case 11:
                        _mesNombre = "Noviembre";
                        break;
                    case 12:
                        _mesNombre = "Diciembre";
                        break;
                    default:
                        _mesNombre = "Indefinido";
                        break;
                }
                //}

                return _mesNombre;
            }
        }



        private List<TipoVista> _lstTipoVista;
        public List<TipoVista> LstTipoVista
        {
            get
            {
                if (_lstTipoVista == null)
                {
                    _lstTipoVista = new List<TipoVista>();
                    foreach (var idTipoVista in LstExpedienteVista.Select(x => x.IdTipoVista).Distinct())
                        _lstTipoVista.Add(LstExpedienteVista.First(x => x.IdTipoVista == idTipoVista).TipoVista);

                }

                return _lstTipoVista;
            }
        }


        public int TotalTareaCompletada => Dias?.Sum(x => x.LstTarea.IsEmpty() ? 0 : x.LstTarea.Count(y => y.Completada)) ?? 0;
        public int TotalTareaNoCompletada => Dias?.Sum(x => x.LstTarea.IsEmpty() ? 0 : x.LstTarea.Count(y => !y.Completada)) ?? 0;


        public int TotalVencimientoEjecutado => Dias?.Sum(x => x.LstExpedienteVencimiento.IsEmpty() ? 0 : x.LstExpedienteVencimiento.Count(y => y.Ejecutado)) ?? 0;
        public int TotalVencimientoNoEjecutado => Dias?.Sum(x => x.LstExpedienteVencimiento.IsEmpty() ? 0 : x.LstExpedienteVencimiento.Count(y => !y.Ejecutado)) ?? 0;
        public int TotalVencimientoGestion => Dias?.Sum(x => x.LstExpedienteVencimiento.IsEmpty() ? 0 : x.LstExpedienteVencimiento.Count(y => y.TipoVencimiento == TipoVencimiento.Gestion)) ?? 0;

        public int TotalHipAdjudicacionVencimientoEjecutadas
        {
            get
            {
                return Dias?.Sum(x => x.LstHipAdjudicacionVencimiento.IsEmpty() ? 0 : x.LstHipAdjudicacionVencimiento.Count(y => y.Ejecutado)) ?? 0;
            }
        }
        public int TotalHipAdjudicacionVencimientoNoEjecutadas
        {
            get
            {
                return Dias == null ? 0 : Dias.Sum(x => x.LstHipAdjudicacionVencimiento.IsEmpty() ? 0 : x.LstHipAdjudicacionVencimiento.Count(y => !y.Ejecutado));
            }
        }

        //public int TotalIva
        //{
        //    get
        //    {
        //        return this.Dias == null ? 0 : this.Dias.Sum(x => x.IvaCount);
        //    }
        //}
        //public int TotalTitulizadas
        //{
        //    get
        //    {
        //        return this.Dias == null ? 0 : this.Dias.Sum(x => x.TitulizadasCount);
        //    }
        //}
        #endregion

        #region Methods
        public void Refresh()
        {
            #region Si el mes cambia

            //if (this.MesChange.HasValue)
            //{
            //	Mes = Mes + MesChange.Value;

            //	if (Mes == 0)
            //	{
            //		Mes = 12;
            //		Anio = Anio - 1;
            //	}
            //	if (Mes == 13)
            //	{
            //		Mes = 1;
            //		Anio = Anio + 1;
            //	}
            //}

            #endregion
        }

        public void LoadData()
        {
            Refresh();

            var date = new DateTime(Anio, Mes, 1);
            Dias = new List<ModelCalendarioDiaAll>();
            int noSemana = 1;
            for (int i = 0; i < 31; i++)
            {
                var newDate = date.AddDays(i);
                if (newDate.Month == Mes)
                {
                    var dia = new ModelCalendarioDiaAll(date.AddDays(i), ref noSemana);

                    Dias.Add(dia);
                }
            }
        }

        private void LoadData(DateTime date, int countDays)
        {
            Dias = new List<ModelCalendarioDiaAll>();
            int noSemana = 1;
            for (int i = 0; i < countDays; i++)
            {
                var dia = new ModelCalendarioDiaAll(date.AddDays(i), ref noSemana);
                Dias.Add(dia);
            }
        }

        public ModelCalendarioDiaAll GetDay(int noSemana, DayOfWeek dayOfWeek, string grupo = "")
        {
            var result = Dias.FirstOrDefault(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek == dayOfWeek);
            if (result == null) return new ModelCalendarioDiaAll();

            result.Grupo = grupo;
            return result;
        }

        public DateTime? GetDate(int noSemana, DayOfWeek dayOfWeek)
        {
            return Dias.FirstOrDefault(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek == dayOfWeek)?.Fecha;
        }

        public bool ExistDataForWeek(int noSemana)
        {
            return Dias.Any(x => x.NoSemana == noSemana);
            //return this.Dias.Any(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek != DayOfWeek.Saturday && x.Fecha.DayOfWeek != DayOfWeek.Sunday);
        }

        private IList<int> GetListAnios(int cantAnios = 10)
        {
            var result = new List<int>();

            int anioInicial = DateTime.Now.Year - (cantAnios / 2);
            for (int i = 0; i < cantAnios; i++)
            {
                result.Add(anioInicial + i);
            }

            return result;
        }
        #endregion

    }
}
