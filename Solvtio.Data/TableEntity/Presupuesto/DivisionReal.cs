using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("DivisionReal")]
    public class DivisionReal
    {
        #region Constructors

        public DivisionReal()
        {
            CreateBase();
        }
        public DivisionReal(DivisionReal modelBase)
        {
            CreateBase();
            IdDivision = modelBase.IdDivision;
            //IdDivision = modelBase.IdDivision;
            //IdDivision = modelBase.IdDivision;
            //IdDivision = modelBase.IdDivision;
            //IdDivision = modelBase.IdDivision;
            //IdDivision = modelBase.IdDivision;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }


        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDivisionReal { get; set; }

        public int IdDivision { get; set; }
        [ForeignKey("IdDivision")]
        public virtual Division Division { get; set; }

        public int IdPeriodoSemana { get; set; }
        [ForeignKey("IdPeriodoSemana")]
        public virtual PeriodoSemana PeriodoSemana { get; set; }

        public int ExpedienteEntrada { get; set; }
        public int ExpedienteSalida { get; set; }
        public int ExpedienteActivo { get; set; }
        public int ExpedienteParalizado { get; set; }

        public decimal Facturacion { get; set; }

        public string AccionComercial { get; set; }

        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<Gnr_Abogado> AbogadoSet { get; set; }
        //public virtual ICollection<Gnr_TipoEstado> TipoEstadoSet { get; set; }
        //public virtual ICollection<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public string AccionComercialAnterior => DivisionRealAnterior?.AccionComercial;
        public string AccionComercialSiguiente => DivisionRealSiguiente?.AccionComercial;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string AccionComercialAnterior { get; set; }
        //[NotMapped]
        //public string AccionComercialSiguiente { get; set; }

        [NotMapped]
        public DivisionReal DivisionRealAnterior { get; set; }
        [NotMapped]
        public DivisionReal DivisionRealSiguiente { get; set; }

        

        #endregion
    }
}

