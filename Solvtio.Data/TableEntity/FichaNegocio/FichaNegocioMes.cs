using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("FichaNegocioMes")]
    public class FichaNegocioMes : IFichaNegocioData
    {
        #region Constructors

        public FichaNegocioMes()
        {
            CreateBase();
        }

        //public FichaNegocioMes(int idExpediente)
        //{
        //    CreateBase();
        //    IdExpediente = idExpediente;
        //}

        public FichaNegocioMes(int idFichaNegocio, int noMes)
        {
            CreateBase();
            IdFichaNegocio = idFichaNegocio;
            NoMes = noMes;
        }

        private void CreateBase()
        {
            //TipoAsunto = ExpPenalTipoAsunto.Penal;
            //Expediente = new Expediente();
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdFichaNegocioMes { get; set; }
        
        public int IdFichaNegocio { get; set; }
        [ForeignKey("IdFichaNegocio")]
        public FichaNegocio FichaNegocio { get; set; }

        public int NoMes { get; set; }

        public decimal Ingresos { get; set; }
        public decimal GastosDirectos { get; set; }
        public decimal GastosIndirectos { get; set; }
        public int ExpEntradas { get; set; }
        public int ExpSalidas { get; set; }
        public int ExpStock { get; set; }

        public int NoPersonas { get; set; }
        public int NoPersonasTipoContrato1 { get; set; }
        public int NoPersonasTipoContrato2 { get; set; }
        public int NoPersonasTipoContrato3 { get; set; }
        public int NoPersonasTipoContrato4 { get; set; }

        #endregion

        #region Properties ReadOnly

        public decimal ResultadosAntesIndirectos => Ingresos - GastosDirectos;
        public decimal TotalGastos => GastosDirectos + GastosIndirectos;
        public decimal ResultadoEjercicio => Ingresos - TotalGastos;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(FichaNegocioMes modelBase)
        {
            Ingresos = modelBase.Ingresos;
            GastosDirectos = modelBase.GastosDirectos;
            ExpEntradas = modelBase.ExpEntradas;
            ExpSalidas = modelBase.ExpSalidas;
            ExpStock = modelBase.ExpStock;

            NoPersonasTipoContrato1 = modelBase.NoPersonasTipoContrato1;
            NoPersonasTipoContrato2 = modelBase.NoPersonasTipoContrato2;
            NoPersonasTipoContrato3 = modelBase.NoPersonasTipoContrato3;
            NoPersonasTipoContrato4 = modelBase.NoPersonasTipoContrato4;
            //NoPersonas =
            //    modelBase.NoPersonasTipoContrato1 +
            //    modelBase.NoPersonasTipoContrato2 +
            //    modelBase.NoPersonasTipoContrato3 +
            //    modelBase.NoPersonasTipoContrato4;
        }

        #endregion
    }
}
