namespace Solvtio.Models
{

    //public class ModelCalendarioVistas //: ModelCalendarioBase, IModelCalendario
    //{
    //    #region Constructors
    //    public ModelCalendarioVistas(int mes, int anio)
    //        : base(mes, anio) 
    //    {
    //        LoadData();
    //    }
    //    #endregion

    //    #region Properties
    //    //public IList<ModelCalendarioSemana> Semanas { get; set; }
    //    //public IList<IModelCalendarioDiaBase> Dias { get; set; }
    //    #endregion

    //    #region Properties ReadOnly
    //    private string _mesNombre;
    //    public string MesNombre
    //    {
    //        get
    //        {
    //            //if (string.IsNullOrWhiteSpace(_mesNombre))
    //            //{
    //                switch (Mes)
    //                {
    //                    case 1:
    //                        _mesNombre = "Enero";
    //                        break;
    //                    case 2:
    //                        _mesNombre = "Febrero";
    //                        break;
    //                    case 3:
    //                        _mesNombre = "Marzo";
    //                        break;
    //                    case 4:
    //                        _mesNombre = "Abril";
    //                        break;
    //                    case 5:
    //                        _mesNombre = "Mayo";
    //                        break;
    //                    case 6:
    //                        _mesNombre = "Junio";
    //                        break;
    //                    case 7:
    //                        _mesNombre = "Julio";
    //                        break;
    //                    case 8:
    //                        _mesNombre = "Agosto";
    //                        break;
    //                    case 9:
    //                        _mesNombre = "Septiembre";
    //                        break;
    //                    case 10:
    //                        _mesNombre = "Octubre";
    //                        break;
    //                    case 11:
    //                        _mesNombre = "Noviembre";
    //                        break;
    //                    case 12:
    //                        _mesNombre = "Diciembre";
    //                        break;
    //                    default:
    //                        _mesNombre = "Indefinido";
    //                        break;
    //                }
    //            //}

    //            return _mesNombre;
    //        }
    //    }

    //    //public int TotalSenialadas
    //    //{
    //    //    get
    //    //    {
    //    //        return this.Dias == null ? 0 : this.Dias.Sum(x => x.SenialadasCount);
    //    //    }
    //    //}
    //    //public int TotalSuspendidas
    //    //{
    //    //    get
    //    //    {
    //    //        return this.Dias == null ? 0 : this.Dias.Sum(x => x.SuspendidasCount);
    //    //    }
    //    //}
    //    //public int TotalIva
    //    //{
    //    //    get
    //    //    {
    //    //        return this.Dias == null ? 0 : this.Dias.Sum(x => x.IvaCount);
    //    //    }
    //    //}
    //    //public int TotalTitulizadas
    //    //{
    //    //    get
    //    //    {
    //    //        return this.Dias == null ? 0 : this.Dias.Sum(x => x.TitulizadasCount);
    //    //    }
    //    //}
    //    #endregion

    //    #region Methods
    //    public void Refresh()
    //    {
    //        #region Si el mes cambia

    //        if (this.MesChange.HasValue)
    //        {
    //            Mes = Mes + MesChange.Value;

    //            if (Mes == 0)
    //            {
    //                Mes = 12;
    //                Anio = Anio - 1;
    //            }
    //            if (Mes == 13)
    //            {
    //                Mes = 1;
    //                Anio = Anio + 1;
    //            }
    //        }

    //        #endregion
    //    }

    //    public void LoadData()
    //    {
    //        Refresh();

    //        var date = new DateTime(this.Anio, this.Mes, 1);
    //        this.Dias = new List<ModelCalendarioDia>();
    //        int noSemana = 1;
    //        for (int i = 0; i < 31; i++)
    //        {
    //            var newDate = date.AddDays(i);
    //            if (newDate.Month == Mes)
    //            {
    //                var dia = new ModelCalendarioDia(date.AddDays(i), ref noSemana);

    //                this.Dias.Add(dia);                    
    //            }
    //        }
    //    }


    //    public ModelCalendarioDia GetDay(int noSemana, DayOfWeek dayOfWeek)
    //    {
    //        var result = this.Dias.FirstOrDefault(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek == dayOfWeek);
    //        return result ?? new ModelCalendarioDia();
    //    }

    //    public bool ExistDataForWeek(int noSemana)
    //    {
    //        return this.Dias.Any(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek != DayOfWeek.Saturday && x.Fecha.DayOfWeek != DayOfWeek.Sunday);
    //    }

    //    private IList<int> GetListAnios(int cantAnios = 10)
    //    {
    //        var result = new List<int>();

    //        int anioInicial = DateTime.Now.Year - (cantAnios / 2);
    //        for (int i = 0; i < cantAnios; i++)
    //        {
    //            result.Add(anioInicial+i);
    //        }

    //        return result;
    //    }
    //    #endregion

    //}
}
