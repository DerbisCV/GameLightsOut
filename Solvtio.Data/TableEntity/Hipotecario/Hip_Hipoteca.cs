using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    public partial class Hip_Hipoteca
    {
        #region Constructors

        public Hip_Hipoteca() { CreateBase(); }

        public Hip_Hipoteca(Hip_Hipoteca hipotecaBase, int? idExpediente, string usuario)
        {
            CreateBase();

            //IdValija = hipotecaBase.IdValija;
            IdExpediente = idExpediente;
            Usuario = usuario;

            IdPeriodicidad = hipotecaBase.IdPeriodicidad;
            IdTipoReferenciaHipotecaria = hipotecaBase.IdTipoReferenciaHipotecaria;
            IdPartidoJudicial = hipotecaBase.IdPartidoJudicial;
            IdPersona = hipotecaBase.IdPersona;
            IdTipoArea = hipotecaBase.IdTipoArea;
            IdJuzgado = hipotecaBase.IdJuzgado;
            OficinaNoCuenta = hipotecaBase.OficinaNoCuenta;
            NoCuentaPrestamo = hipotecaBase.NoCuentaPrestamo;
            NoHipoteca = hipotecaBase.NoHipoteca;
            DeudaCierreFijacion = hipotecaBase.DeudaCierreFijacion;
            PrestamoCapital = hipotecaBase.PrestamoCapital;
            ColegioNotarioFijacion = hipotecaBase.ColegioNotarioFijacion;
            NotarioFijacion = hipotecaBase.NotarioFijacion;
            Registro = hipotecaBase.Registro;
            CuotasCantidad = hipotecaBase.CuotasCantidad;
            CuotasValor = hipotecaBase.CuotasValor;
            CuotasFechaPrimera = hipotecaBase.CuotasFechaPrimera;
            CuotasFechaUltima = hipotecaBase.CuotasFechaUltima;
            TipoInteresInicial = hipotecaBase.TipoInteresInicial;
            TipoInteresUltimo = hipotecaBase.TipoInteresUltimo;
            TipoInteresMoratorio = hipotecaBase.TipoInteresMoratorio;
            FechaModificacionTipoInteres = hipotecaBase.FechaModificacionTipoInteres;
            FechaPrimeraCuotaImpagada = hipotecaBase.FechaPrimeraCuotaImpagada;
            FechaCierre = hipotecaBase.FechaCierre;
            DemandaFecha = hipotecaBase.DemandaFecha;
            Ejecutar = hipotecaBase.Ejecutar;
            DiferencialIndiceReferenciaHipotecaria = hipotecaBase.DiferencialIndiceReferenciaHipotecaria;
            DemandaSucesionBancaria = hipotecaBase.DemandaSucesionBancaria;

            DemandaBurofaxNoNotificado = hipotecaBase.DemandaBurofaxNoNotificado;
            NovacionFechaFinPeriodoCarencia = hipotecaBase.NovacionFechaFinPeriodoCarencia;
            NovacionNoCuotas = hipotecaBase.NovacionNoCuotas;
            NovacionFechaPeriodoAmortizacionInicio = hipotecaBase.NovacionFechaPeriodoAmortizacionInicio;
            NovacionFechaPeriodoAmortizacionFin = hipotecaBase.NovacionFechaPeriodoAmortizacionFin;

            NovacionComision = hipotecaBase.NovacionComision;
            FechaActaFijacion = hipotecaBase.FechaActaFijacion;
            Carencia = hipotecaBase.Carencia;
            Diferencial = hipotecaBase.Diferencial;
            ReferenciaExterna = hipotecaBase.ReferenciaExterna;

            EntidadOrigen = hipotecaBase.EntidadOrigen;
            Observaciones = hipotecaBase.Observaciones;
        }

        public void CreateBase()
        {
            //IdValija = 0;
            NoHipoteca = 1;
            FechaAlta = DateTime.Now;
            Hip_HipotecaDatoEscritura = new List<Hip_HipotecaDatoEscritura>();
            Hip_HipotecaPagoACuenta = new List<Hip_HipotecaPagoACuenta>();
        }

        #endregion

        #region Properties New

        #endregion

        #region Properties Old

        public int IdHipoteca { get; set; }

        //public int IdValija { get; set; }
        //[ForeignKey("IdValija")]
        //public virtual Gnr_Valija Gnr_Valija { get; set; }

        [Index]
        public int? IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }


        public int? IdPeriodicidad { get; set; }
        public int? IdTipoReferenciaHipotecaria { get; set; }

        public int? IdPartidoJudicial { get; set; }


        public int? IdPersona { get; set; }
        [ForeignKey("IdPersona")]
        public virtual Gnr_Persona Gnr_Persona { get; set; }

        public int IdTipoArea { get; set; }
        [ForeignKey("IdTipoArea")]
        public Gnr_TipoArea Gnr_TipoArea { get; set; }


        public int? IdJuzgado { get; set; }
        public string OficinaNoCuenta { get; set; }
        public string NoCuentaPrestamo { get; set; }
        public int NoHipoteca { get; set; }
        public decimal DeudaCierreFijacion { get; set; }
        public decimal? PrestamoCapital { get; set; }
        public string ColegioNotarioFijacion { get; set; }
        public string NotarioFijacion { get; set; }
        public string Registro { get; set; }
        public int? CuotasCantidad { get; set; }
        public int? CuotasCantidadImpagadas { get; set; }
        public decimal? CuotasValor { get; set; }
        public DateTime? CuotasFechaPrimera { get; set; }
        public DateTime? CuotasFechaUltima { get; set; }
        public decimal? TipoInteresInicial { get; set; }
        public decimal? TipoInteresUltimo { get; set; }
        public decimal? TipoInteresMoratorio { get; set; }
        public DateTime? FechaModificacionTipoInteres { get; set; }
        public DateTime? FechaPrimeraCuotaImpagada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? DemandaFecha { get; set; }
        public bool Ejecutar { get; set; }
        public decimal? DiferencialIndiceReferenciaHipotecaria { get; set; }
        public bool? DemandaSucesionBancaria { get; set; }
        public bool? DemandaBurofaxNoNotificado { get; set; }
        public DateTime? NovacionFechaFinPeriodoCarencia { get; set; }
        public int? NovacionNoCuotas { get; set; }
        public DateTime? NovacionFechaPeriodoAmortizacionInicio { get; set; }
        public DateTime? NovacionFechaPeriodoAmortizacionFin { get; set; }
        public decimal? NovacionComision { get; set; }
        public DateTime? FechaActaFijacion { get; set; }
        public bool Carencia { get; set; }
        public bool Diferencial { get; set; }
        public string ReferenciaExterna { get; set; }
        public string EntidadOrigen { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaAlta { get; set; }

        #endregion

        #region Properties One to Many

        public virtual ICollection<Hip_HipotecaDatoEscritura> Hip_HipotecaDatoEscritura { get; set; }
        public virtual ICollection<Hip_HipotecaPagoACuenta> Hip_HipotecaPagoACuenta { get; set; }

        #endregion

        #region Properties ReadOnly

        //VALIDAR DERBIS
        private decimal? _deuda;
        public decimal Deuda
        {
            get
            {
                if (!_deuda.HasValue)
                {
                    //_deuda = this.Expediente.Hip_Hipoteca.Sum(x => x.Deuda);
                    _deuda = Expediente != null ?
                        Expediente.Hip_Hipoteca.Sum(x => x.DeudaCierreFijacion) :
                        DeudaCierreFijacion;
                }

                return _deuda.Value;
            }
        }

        private decimal? _deudaPrincipal;
        public decimal DeudaPrincipal
        {
            get
            {
                if (!_deudaPrincipal.HasValue)
                {
                    _deudaPrincipal = Expediente != null ?
                        Expediente.Hip_Inmueble.Sum(x => x.DeudaPrincipal) :
                        0;
                }

                return _deudaPrincipal.Value;
            }
        }

        private decimal? _deudaIntRemuneratorios;
        public decimal DeudaIntRemuneratorios
        {
            get
            {
                if (!_deudaIntRemuneratorios.HasValue)
                {
                    _deudaIntRemuneratorios = Expediente != null ?
                        Expediente.Hip_Inmueble.Sum(x => x.DeudaIntRemuneratorios) :
                        0;
                }

                return _deudaIntRemuneratorios.Value;
            }
        }

        private decimal? _deudaComisionesGastos;
        public decimal DeudaComisionesGastos
        {
            get
            {
                if (!_deudaComisionesGastos.HasValue)
                {
                    _deudaComisionesGastos = Expediente != null ?
                        Expediente.Hip_Inmueble.Sum(x => x.DeudaComisionesGastos) :
                        0;
                }

                return _deudaComisionesGastos.Value;
            }
        }

        private decimal? _deudaIntDemora;
        public decimal DeudaIntDemora
        {
            get
            {
                if (!_deudaIntDemora.HasValue)
                {
                    _deudaIntDemora = Expediente != null ?
                        Expediente.Hip_Inmueble.Sum(x => x.DeudaIntDemora) :
                        0;
                }

                return _deudaIntDemora.Value;
            }
        }



        //VALIDAR DERBIS
        private decimal? _prestamoResponsabilidadHipotecaria;
        public decimal PrestamoResponsabilidadHipotecaria
        {
            get
            {
                if (!_prestamoResponsabilidadHipotecaria.HasValue)
                {
                    _prestamoResponsabilidadHipotecaria = Expediente != null ?
                        Expediente.Hip_Inmueble.Sum(x => x.PrestamoResponsabilidadHipotecaria) :
                        0;
                }

                return _prestamoResponsabilidadHipotecaria.Value;
            }
        }

        private decimal? _deudaCierreFijacionCentena;
        public decimal DeudaCierreFijacionCentena
        {
            get
            {
                if (!_deudaCierreFijacionCentena.HasValue)
                {
                        var varDeudaCierreFijacion = (int)(0.30M * DeudaCierreFijacion);
                        if (varDeudaCierreFijacion > 100)
                        {
                            var strDeudaCierreFijacion = varDeudaCierreFijacion.ToString();
                            strDeudaCierreFijacion = strDeudaCierreFijacion.Substring(0, strDeudaCierreFijacion.Length - 2) + "00";
                            int.TryParse(strDeudaCierreFijacion, out varDeudaCierreFijacion);
                        }

                        _deudaCierreFijacionCentena = varDeudaCierreFijacion;
                }

                return _deudaCierreFijacionCentena.Value;
            }
        }

        //
        private string _fincasNumeros;
        public string FincasNumeros //Finca nº 13163, 102030
        {
            get
            {
                if (string.IsNullOrEmpty(_fincasNumeros))
                {
                    if (Expediente != null && Expediente.Hip_Inmueble != null)
                    {
                        foreach (var inmueble in Expediente.Hip_Inmueble)
                        {
                            _fincasNumeros += string.IsNullOrEmpty(_fincasNumeros) ?
                                inmueble.NumeroFinca :
                                string.Format(", {0}", inmueble.NumeroFinca);
                        }

                        _fincasNumeros = string.Format("{0} nº {1}",
                            Expediente.Hip_Inmueble.Count > 1 ? "Fincas" : "Finca",
                            _fincasNumeros);
                    }
                }

                return _fincasNumeros;
            }
        }

        //FincasInscripciones
        private string _fincasInscripciones;
        public string FincasInscripciones
        {
            get
            {
                if (string.IsNullOrEmpty(_fincasInscripciones))
                {
                    if (Expediente != null && Expediente.Hip_Inmueble != null)
                    {
                        var lstInscripcionesDistintas = Expediente.Hip_Inmueble.Select(x => x.Inscripcion).Distinct();
                        foreach (var inscripcion in lstInscripcionesDistintas)
                        {
                            _fincasInscripciones += string.IsNullOrEmpty(_fincasInscripciones) ?
                                inscripcion :
                                string.Format(", {0}", inscripcion);
                        }

                        _fincasInscripciones = string.Format("{0} {1}",
                            lstInscripcionesDistintas.Count() > 1 ? "INSCRIPCIÓNES" : "INSCRIPCIÓN",
                            _fincasInscripciones);
                    }
                }

                return _fincasInscripciones;
            }
        }

        #endregion

        #region Methods

        public void Refresh(Expediente expediente)
        {
            //CreateBase();

            Usuario = expediente.Usuario;
            if (expediente.IdExpediente > 0) IdExpediente = expediente.IdExpediente;
            ReferenciaExterna = expediente.ReferenciaExterna;
            DeudaCierreFijacion = expediente.DeudaFinal ?? 0;
            PrestamoCapital = DeudaCierreFijacion;

            IdTipoArea = expediente.IdTipoArea;
            IdJuzgado = expediente.IdJuzgado;
            FechaCierre = expediente.FechaCierre;
            Observaciones = expediente.Observaciones;
            IdPartidoJudicial = expediente.IdPartidoJudicial;
        }

        #endregion
    }
}
