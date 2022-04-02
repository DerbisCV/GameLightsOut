using Solvtio.Models.Model;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Proveedor")]
    public class Proveedor : INombre
    {
        #region Constructors

        public Proveedor()
        {
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProveedor { get; set; }

        public string Nombre { get; set; }
        public string CIF { get; set; }

        public int? IdTipologia { get; set; }
        [ForeignKey("IdTipologia")]
        public virtual CaracteristicaBase Tipologia { get; set; }

        [DefaultValue(TipoProveedor.Proveedor)]
        public TipoProveedor Tipo { get; set; }

        public string InformacionFiscal { get; set; }
        public string TipoServicio { get; set; }

        public bool? Contrato { get; set; }
        public DateTime? VencimientoFecha { get; set; }
        public string VencimientoInfo { get; set; }

        public string ContratoTitular { get; set; }
        public string ContratoTitularCIF { get; set; }
        public string ContratoServicio { get; set; }
        public string ContratoFondoEntidad { get; set; }
        public string ContratoRelacionComercial { get; set; }
        public string GestorCuenta { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(Proveedor model)
        {
            Nombre = model.Nombre;
            CIF = model.CIF;
            IdTipologia = model.IdTipologia;
            InformacionFiscal = model.InformacionFiscal;
            TipoServicio = model.TipoServicio;
            Contrato = model.Contrato;
            VencimientoFecha = model.VencimientoFecha;
            VencimientoInfo = model.VencimientoInfo;

            ContratoTitular = model.ContratoTitular;
            ContratoTitularCIF = model.ContratoTitularCIF;
            ContratoServicio = model.ContratoServicio;
            ContratoFondoEntidad = model.ContratoFondoEntidad;
            ContratoRelacionComercial = model.ContratoRelacionComercial;
            GestorCuenta = model.GestorCuenta;
        }

        #endregion
    }
}
