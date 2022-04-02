using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Inmueble")]
    public class Inmueble : IInmuebleCatastro
    {
        #region Constructors

        public Inmueble()
        {
            CreateBase();
        }
        public Inmueble(string refCatastral)
        {
            CreateBase();
            //IdExpediente = idExpediente;
            //IdExpedienteDeudor = idExpDeudor;
            //EsHabitual = true;
        }

        private void CreateBase()
        {
            Origen = InmuebleOrigen.GestionInmobiliaria;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInmueble { get; set; }

        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }

        public int? IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio { get; set; }

        public int? IdPais { get; set; }
        [ForeignKey("IdPais")]
        public virtual CaracteristicaBase Pais { get; set; }

        public string RefCatastral { get; set; }
        public string Direccion { get; set; }
        public string DireccionCodigoPostal { get; set; }
        public string DireccionLocalidad { get; set; }
        public string Descripcion { get; set; }
        public string UsoPrincipal { get; set; }
        public int? AnioConstruccion { get; set; }

        public string TipoFinca { get; set; }

        public decimal Valor { get; set; } //ValoracionInterna
        public decimal ValorTasacion { get; set; } //ValoracionInterna
        public decimal ValorMandato { get; set; } //ValoracionInterna
        public decimal ValorVenta { get; set; } //ValoracionInterna

        public string Propietario { get; set; }
        public string Responsable { get; set; }
        public string UrlImagen { get; set; }

        public int? IdTipoInmueble { get; set; }
        [ForeignKey("IdTipoInmueble")]
        public virtual Hip_TipoInmueble TipoInmueble { get; set; }

        public int? IdTipoInstitucion { get; set; }
        [ForeignKey("IdTipoInstitucion")]
        public virtual CaracteristicaBase TipoInstitucion { get; set; }

        public int? IdGestionadoPor { get; set; }
        [ForeignKey("IdGestionadoPor")]
        public virtual CaracteristicaBase GestionadoPor { get; set; }

        public int? IdFinalizacionCausa { get; set; }
        [ForeignKey("IdFinalizacionCausa")]
        public virtual CaracteristicaBase FinalizacionCausa { get; set; }

        public string SituacionActual { get; set; }
        public string Clasificacion { get; set; }
        public int? SuperficieParcela { get; set; }     //Superficie de Suelo - SS:
        public int? SuperficieConstruida { get; set; }  //Superficie Construída - SC:
        public decimal? Edificabilidad { get; set; }
        public string Volumetria { get; set; }
        public string Cargas { get; set; }
        public string Ocupantes { get; set; }
        public string Uso { get; set; }
        public string Proteccion { get; set; }
        public string Conservacion { get; set; }
        public string Observaciones { get; set; }
        public string AnalisisTecnico { get; set; }

        public decimal EstimacionCompraVentaSupUsoCompatibleM2 { get; set; }  //=> 0.25M * TechoMaximoEdf;
        public decimal EstimacionCompraVentaSupUsoCompatiblePrecioM2 { get; set; }
        public decimal EstimacionCompraVentaSupDotacionalExistentePrecioM2 { get; set; }
        public decimal EstimacionCompraVentaSupDotacionalExistenteM2 { get; set; }
        public decimal EstimacionCompraVentaSupDotacionalNuevaConstM2 { get; set; }
        public decimal EstimacionCompraVentaSupDotacionalNuevaConstPrecioM2 { get; set; }
        public decimal EstimacionCompraVentaComision { get; set; }

        public string Transformacion { get; set; }
        public string TransformacionPlazos { get; set; }
        public decimal TransformacionObraDemolicionM2 { get; set; }
        public decimal TransformacionObraDemolicionPrecio { get; set; }
        public decimal TransformacionObraSupDotacionalM2 { get; set; }
        public decimal TransformacionObraSupDotacionalPrecio { get; set; }
        public decimal TransformacionObraSupDotacionalNuevaConstM2 { get; set; }
        public decimal TransformacionObraSupDotacionalNuevaConstPrecio { get; set; }


        public decimal TransformacionPlaneamiento { get; set; }
        public decimal TransformacionHonProyecto { get; set; }
        public decimal TransformacionTasasImpuestos { get; set; }

        public int OperativaDesinversionMeses { get; set; }
        public decimal OperativaSinTransformarRevalorizacionPorc { get; set; }
        public string OperativaSinTransformarCanonExplotacion { get; set; }
        public decimal OperativaSinTransformarGastosOperativosPorc { get; set; }
        public decimal OperativaSinTransformarGastosComercPorc { get; set; }
        public decimal OperativaSinTransformarTotalInversion { get; set; }
        public decimal OperativaSinTransformarRentabilidadPorc { get; set; }

        public decimal OperativaTransformarTechoPrEstimado1 { get; set; }
        public decimal OperativaTransformarTechoPrEstimado2 { get; set; }
        public decimal OperativaTransformarTechoGastosOperativos { get; set; }
        public decimal OperativaTransformarTechoGastosComerc { get; set; }

        public decimal OperativaTransformarSupConstPrEstimado1 { get; set; }
        public decimal OperativaTransformarSupConstPrEstimado2 { get; set; }
        public decimal OperativaTransformarSupConstGastosOperativos { get; set; }
        public decimal OperativaTransformarSupConstGastosComerc { get; set; }

        public int? IdInmuebleEstadoLast { get; set; }
        [ForeignKey("IdInmuebleEstadoLast")]
        public virtual InmuebleEstado InmuebleEstadoLast { get; set; }

        public InmuebleOrigen Origen { get; set; }

        public TipoSemaforo? Situacion { get; set; }

        #endregion

        #region Properties Activos Especiales

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionNotaSimpleFecha { get; set; }
        public string EspecialOriginacionNotaSimpleRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionTituloPropiedadFecha { get; set; }
        public string EspecialOriginacionTituloPropiedadRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionLicenciasFecha { get; set; }
        public string EspecialOriginacionLicenciasRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionTasacion1Fecha { get; set; }
        public string EspecialOriginacionTasacion1Representante { get; set; }
        public decimal? EspecialOriginacionTasacion1Coste { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionTasacion2Fecha { get; set; }
        public string EspecialOriginacionTasacion2Representante { get; set; }
        public decimal? EspecialOriginacionTasacion2Coste { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionMandatoFecha { get; set; }
        public string EspecialOriginacionMandatoRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionHonorariosFecha { get; set; }
        public string EspecialOriginacionHonorariosRepresentante { get; set; }
        public string EspecialOriginacionHonorariosImpPorciento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialOriginacionPrecioVentaFecha { get; set; }
        public string EspecialOriginacionPrecioVentaRepresentante { get; set; }
        public decimal? EspecialOriginacionPrecioVentaImporte { get; set; }


        [DataType(DataType.Date)]
        public DateTime? EspecialInmobiliarioVisitaFecha { get; set; }
        public string EspecialInmobiliarioVisitaRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialInmobiliarioMercadoFecha { get; set; }
        public string EspecialInmobiliarioMercadoRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialInmobiliarioFotosFecha { get; set; }
        public string EspecialInmobiliarioFotosRepresentante { get; set; }


        [DataType(DataType.Date)]
        public DateTime? EspecialTecnicoFichaFecha { get; set; }
        public string EspecialTecnicoFichaRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialTecnicoPlanosFecha { get; set; }
        public string EspecialTecnicoPlanosRepresentante { get; set; }
        public decimal? EspecialTecnicoPlanosCoste { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialTecnicoDescripcionFecha { get; set; }
        public string EspecialTecnicoDescripcionRepresentante { get; set; }



        [DataType(DataType.Date)]
        public DateTime? EspecialJuridicoRegistralFecha { get; set; }
        public string EspecialJuridicoRegistralRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialJuridicoFiscalFecha { get; set; }
        public string EspecialJuridicoFiscalRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialJuridicoComplementarioFecha { get; set; }
        public string EspecialJuridicoComplementarioRepresentante { get; set; }


        [DataType(DataType.Date)]
        public DateTime? EspecialComercialViabilidadFecha { get; set; }
        public string EspecialComercialViabilidadRepresentante { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialComercialDossierFecha { get; set; }
        public string EspecialComercialDossierRepresentante { get; set; }
        public decimal? EspecialComercialDossierCoste { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EspecialComercialComercializacionFecha { get; set; }
        public string EspecialComercialComercializacionRepresentante { get; set; }
        //public decimal? EspecialComercialComercializacionCoste { get; set; }


        public TipoSemaforo? SituacionMandato { get; set; }
        public TipoSemaforo? SituacionLegal { get; set; }
        public TipoSemaforo? SituacionUrbanistica { get; set; }
        public TipoSemaforo? SituacionComercializacion { get; set; }



        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<InmuebleNota> InmuebleNotaSet { get; set; }
        public virtual ICollection<InmuebleContacto> InmuebleContactoSet { get; set; }
        public virtual ICollection<InmuebleEstado> InmuebleEstadoSet { get; set; }
        public virtual ICollection<InmuebleOferta> InmuebleOfertaSet { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public int? IdMunicipioCatastro { get; set; }

        [NotMapped]
        public TipoExport? Export { get; set; }

        [NotMapped]
        public InmuebleNota LastNotaNotaNotMapped { get; set; }
        [NotMapped]
        public InmuebleNota LastNotaAccionComercialNotMapped { get; set; }

        [NotMapped]
        public string UrlFolderSp { get; set; }

        #endregion

        #region Properties ReadOnly

        public string DireccionCompleta => $"{Direccion} {DireccionCodigoPostal} {Municipio?.Nombre} {Provincia?.Nombre}";

        public decimal TechoMaximoEdf => (SuperficieParcela ?? 0) * (Edificabilidad ?? 0);
        public decimal RemanenteEdf => TechoMaximoEdf - (SuperficieConstruida ?? 0);

        public decimal EstimacionCompraVentaSupUsoCompatibleSubTotal => EstimacionCompraVentaSupUsoCompatibleM2 * EstimacionCompraVentaSupUsoCompatiblePrecioM2;
        public decimal EstimacionCompraVentaSupDotacionalExistenteSubTotal => EstimacionCompraVentaSupDotacionalExistenteM2 * EstimacionCompraVentaSupDotacionalExistentePrecioM2;
        public decimal EstimacionCompraVentaSupDotacionalNuevaConstSubTotal => EstimacionCompraVentaSupDotacionalNuevaConstM2 * EstimacionCompraVentaSupDotacionalNuevaConstPrecioM2;

        public decimal EstimacionCompraVentaPcv => EstimacionCompraVentaSupUsoCompatibleSubTotal + EstimacionCompraVentaSupDotacionalExistenteSubTotal + EstimacionCompraVentaSupDotacionalNuevaConstSubTotal;
        public decimal EstimacionCompraVenta => EstimacionCompraVentaPcv + EstimacionCompraVentaComision;
        public decimal EstimacionCompraVentaPrecioM2Suelo => SuperficieParcela.HasValue && SuperficieParcela != 0 ? EstimacionCompraVenta / SuperficieParcela.Value : 0;
        public decimal EstimacionCompraVentaPrecioM2Techo => TechoMaximoEdf != 0 ? EstimacionCompraVenta / TechoMaximoEdf : 0;

        public decimal TransformacionObraDemolicionSubTotal => TransformacionObraDemolicionM2 * TransformacionObraDemolicionPrecio;
        public decimal TransformacionObraSupDotacionalSubTotal => TransformacionObraSupDotacionalM2 * TransformacionObraSupDotacionalPrecio;
        public decimal TransformacionObraSupDotacionalNuevaConstSubTotal => TransformacionObraSupDotacionalNuevaConstM2 * TransformacionObraSupDotacionalNuevaConstPrecio;
        public decimal TransformacionObraTotal => TransformacionObraDemolicionSubTotal + TransformacionObraSupDotacionalSubTotal + TransformacionObraSupDotacionalNuevaConstSubTotal;
        public decimal TransformacionSubTotalPlaneamiento => EstimacionCompraVenta * TransformacionPlaneamiento / 100;
        public decimal TransformacionSubTotalHonProyecto => TransformacionObraTotal * TransformacionHonProyecto / 100;
        public decimal TransformacionSubTotalTasasImpuestos => TransformacionObraTotal * TransformacionTasasImpuestos / 100;
        public decimal TransformacionTotal => TransformacionObraTotal + TransformacionSubTotalPlaneamiento + TransformacionSubTotalHonProyecto + TransformacionSubTotalTasasImpuestos;
                                      

        public decimal OperativaTransformarTechoVentaEstimado1 => TechoMaximoEdf * OperativaTransformarTechoPrEstimado1;
        public decimal OperativaTransformarTechoVentaEstimado2 => TechoMaximoEdf * OperativaTransformarTechoPrEstimado2;
        public decimal OperativaTransformarTechoVentaEstimadoMedia => (OperativaTransformarTechoVentaEstimado1 + OperativaTransformarTechoVentaEstimado2) / 2;
        public decimal OperativaTransformarTechoGastosOperativosPorciento => OperativaTransformarTechoVentaEstimadoMedia == 0 ? 0 : 100 * OperativaTransformarTechoGastosOperativos / OperativaTransformarTechoVentaEstimadoMedia;
        public decimal OperativaTransformarTechoGastosComercPorciento => OperativaTransformarTechoVentaEstimadoMedia == 0 ? 0 : 100 * OperativaTransformarTechoGastosComerc / OperativaTransformarTechoVentaEstimadoMedia;
        public decimal OperativaTransformarTechoInversion => EstimacionCompraVenta + TransformacionTotal + OperativaTransformarTechoGastosOperativos + OperativaTransformarTechoGastosComerc;
        public decimal OperativaTransformarTechoRentabilidad => OperativaTransformarTechoInversion == 0 ? 0 : 100 * (OperativaTransformarTechoVentaEstimadoMedia - OperativaTransformarTechoInversion) / OperativaTransformarTechoInversion;

        public decimal OperativaTransformarSupConstVentaEstimado1 => (SuperficieConstruida ?? 0) * OperativaTransformarSupConstPrEstimado1;
        public decimal OperativaTransformarSupConstVentaEstimado2 => (SuperficieConstruida ?? 0) * OperativaTransformarSupConstPrEstimado2;
        public decimal OperativaTransformarSupConstVentaEstimadoMedia => (OperativaTransformarSupConstVentaEstimado1 + OperativaTransformarSupConstVentaEstimado2) / 2;
        public decimal OperativaTransformarSupConstGastosOperativosPorciento => OperativaTransformarSupConstVentaEstimadoMedia == 0 ? 0 : 100 * OperativaTransformarSupConstGastosOperativos / OperativaTransformarSupConstVentaEstimadoMedia;
        public decimal OperativaTransformarSupConstGastosComercPorciento => OperativaTransformarSupConstVentaEstimadoMedia == 0 ? 0 : 100 * OperativaTransformarSupConstGastosComerc / OperativaTransformarSupConstVentaEstimadoMedia;
        public decimal OperativaTransformarSupConstInversion => EstimacionCompraVenta + TransformacionTotal + OperativaTransformarSupConstGastosOperativos + OperativaTransformarSupConstGastosComerc;
        public decimal OperativaTransformarSupConstRentabilidad => OperativaTransformarSupConstInversion == 0 ? 0 : 100 * (OperativaTransformarSupConstVentaEstimadoMedia - OperativaTransformarSupConstInversion) / OperativaTransformarSupConstInversion;

        #endregion

        #region Methods

        //public override string ToString()
        //{
        //    return 
        //        !string.IsNullOrWhiteSpace(NumeroFinca) ? NumeroFinca : 
        //        !string.IsNullOrWhiteSpace(Descripcion) ? Descripcion : 
        //        Direccion;
        //}

        public void RefreshActivoEspecial(Inmueble model)
        {
            EspecialOriginacionNotaSimpleFecha = model.EspecialOriginacionNotaSimpleFecha;
            EspecialOriginacionNotaSimpleRepresentante = model.EspecialOriginacionNotaSimpleRepresentante;
            EspecialOriginacionTituloPropiedadFecha = model.EspecialOriginacionTituloPropiedadFecha;
            EspecialOriginacionTituloPropiedadRepresentante = model.EspecialOriginacionTituloPropiedadRepresentante;
            EspecialOriginacionLicenciasFecha = model.EspecialOriginacionLicenciasFecha;
            EspecialOriginacionLicenciasRepresentante = model.EspecialOriginacionLicenciasRepresentante;
            EspecialOriginacionTasacion1Fecha = model.EspecialOriginacionTasacion1Fecha;
            EspecialOriginacionTasacion1Representante = model.EspecialOriginacionTasacion1Representante;
            EspecialOriginacionTasacion1Coste = model.EspecialOriginacionTasacion1Coste;
            EspecialOriginacionTasacion2Fecha = model.EspecialOriginacionTasacion2Fecha;
            EspecialOriginacionTasacion2Representante = model.EspecialOriginacionTasacion2Representante;
            EspecialOriginacionTasacion2Coste = model.EspecialOriginacionTasacion2Coste;
            EspecialOriginacionMandatoFecha = model.EspecialOriginacionMandatoFecha;
            EspecialOriginacionMandatoRepresentante = model.EspecialOriginacionMandatoRepresentante;
            EspecialOriginacionHonorariosFecha = model.EspecialOriginacionHonorariosFecha;
            EspecialOriginacionHonorariosRepresentante = model.EspecialOriginacionHonorariosRepresentante;
            EspecialOriginacionHonorariosImpPorciento = model.EspecialOriginacionHonorariosImpPorciento;
            EspecialOriginacionPrecioVentaFecha = model.EspecialOriginacionPrecioVentaFecha;
            EspecialOriginacionPrecioVentaRepresentante = model.EspecialOriginacionPrecioVentaRepresentante;
            EspecialOriginacionPrecioVentaImporte = model.EspecialOriginacionPrecioVentaImporte;

            EspecialInmobiliarioVisitaFecha = model.EspecialInmobiliarioVisitaFecha;
            EspecialInmobiliarioVisitaRepresentante = model.EspecialInmobiliarioVisitaRepresentante;
            EspecialInmobiliarioMercadoFecha = model.EspecialInmobiliarioMercadoFecha;
            EspecialInmobiliarioMercadoRepresentante = model.EspecialInmobiliarioMercadoRepresentante;
            EspecialInmobiliarioFotosFecha = model.EspecialInmobiliarioFotosFecha;
            EspecialInmobiliarioFotosRepresentante = model.EspecialInmobiliarioFotosRepresentante;

            EspecialTecnicoFichaFecha = model.EspecialTecnicoFichaFecha;
            EspecialTecnicoFichaRepresentante = model.EspecialTecnicoFichaRepresentante;
            EspecialTecnicoPlanosFecha = model.EspecialTecnicoPlanosFecha;
            EspecialTecnicoPlanosRepresentante = model.EspecialTecnicoPlanosRepresentante;
            EspecialTecnicoPlanosCoste = model.EspecialTecnicoPlanosCoste;
            EspecialTecnicoDescripcionFecha = model.EspecialTecnicoDescripcionFecha;
            EspecialTecnicoDescripcionRepresentante = model.EspecialTecnicoDescripcionRepresentante;

            EspecialJuridicoRegistralFecha = model.EspecialJuridicoRegistralFecha;
            EspecialJuridicoRegistralRepresentante = model.EspecialJuridicoRegistralRepresentante;
            EspecialJuridicoFiscalFecha = model.EspecialJuridicoFiscalFecha;
            EspecialJuridicoFiscalRepresentante = model.EspecialJuridicoFiscalRepresentante;
            EspecialJuridicoComplementarioFecha = model.EspecialJuridicoComplementarioFecha;
            EspecialJuridicoComplementarioRepresentante = model.EspecialJuridicoComplementarioRepresentante;

            EspecialComercialViabilidadFecha = model.EspecialComercialViabilidadFecha;
            EspecialComercialViabilidadRepresentante = model.EspecialComercialViabilidadRepresentante;
            EspecialComercialDossierFecha = model.EspecialComercialDossierFecha;
            EspecialComercialDossierRepresentante = model.EspecialComercialDossierRepresentante;
            EspecialComercialDossierCoste = model.EspecialComercialDossierCoste;
            EspecialComercialComercializacionFecha = model.EspecialComercialComercializacionFecha;
            EspecialComercialComercializacionRepresentante = model.EspecialComercialComercializacionRepresentante;

            SituacionMandato = model.SituacionMandato;
            SituacionLegal = model.SituacionLegal;
            SituacionUrbanistica = model.SituacionUrbanistica;
            SituacionComercializacion = model.SituacionComercializacion;
        }

        #endregion
    }
}
