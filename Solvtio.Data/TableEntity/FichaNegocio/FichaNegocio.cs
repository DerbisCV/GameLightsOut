using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("FichaNegocio")]
    public class FichaNegocio : IFichaNegocioData
    {
        #region Constructors

        public FichaNegocio()
        {
            CreateBase();
        }

        public FichaNegocio(int idDivision)
        {
            CreateBase();
            IdDivision = idDivision;
        }

        public FichaNegocio(int idDivision, int year)
        {
            CreateBase();
            IdDivision = idDivision;
            Anio = year;
        }

        private void CreateBase()
        {
            Anio = DateTime.Now.Year;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdFichaNegocio { get; set; }


        public int IdDivision { get; set; }
        [ForeignKey("IdDivision")]
        public Division Division { get; set; }

        public int Anio { get; set; }

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

        public virtual ICollection<FichaNegocioMes> FichaNegocioMesSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public decimal ResultadosAntesIndirectos => Ingresos - GastosDirectos;
        public decimal AntesIndirectosPorcientoCi => Ingresos == 0 ? 0 : GastosDirectos / Ingresos;
        public decimal AntesIndirectosPorcientoMargen => 1 - AntesIndirectosPorcientoCi;

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public FichaNegocioMes Mes01 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes02 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes03 { get; set; }

        [NotMapped]
        public FichaNegocioMes Mes04 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes05 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes06 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes07 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes08 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes09 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes10 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes11 { get; set; }
        [NotMapped]
        public FichaNegocioMes Mes12 { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(FichaNegocio modelBase)
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
            NoPersonas = 
                modelBase.NoPersonasTipoContrato1 + 
                modelBase.NoPersonasTipoContrato2 + 
                modelBase.NoPersonasTipoContrato3 + 
                modelBase.NoPersonasTipoContrato4;
        }

        #endregion
    }
}
