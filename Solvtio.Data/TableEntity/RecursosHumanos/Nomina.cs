using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Nomina")]
    public class Nomina
    {
        #region Constructors

        public Nomina() { }
        public Nomina(int anio, int mes, int idUsuario)
        {
            IdUsuario = idUsuario;
            Anio = anio;
            Mes = mes;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 IdNomina { get; set; }
  
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public int Anio { get; set; }
        public int Mes { get; set; }

        public decimal? SalarioBrutoAnual { get; set; }
        public decimal? Antiguedad { get; set; }


        public decimal? BaseUnica { get; set; }
        public decimal? Inventivo { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Total { get; set; }


        public decimal? PNoComp { get; set; }
        public decimal? PPPExtr { get; set; }
        public decimal? SegMedTr { get; set; }
        public decimal? SegMedEx { get; set; }

        public decimal? PlusPer { get; set; }
        public decimal? CompPuest { get; set; }
        public decimal? Disponib { get; set; }
        public decimal? Restaurant { get; set; }
        public decimal? Formacion { get; set; }
        public decimal? DevGaraje { get; set; }
        public decimal? MejoraV { get; set; }
        public decimal? LiqPagVac { get; set; }
        public decimal? Enf75 { get; set; }
        public decimal? TotalDevengos { get; set; }
        public decimal? Anticipos { get; set; }
        public decimal? DtoRFlx { get; set; }
        public decimal? DtoCCom { get; set; }
        public decimal? DtoAcc { get; set; }
        public decimal? RetencionIrpf { get; set; }
        public decimal? RetVEsp { get; set; }
        public decimal? TotalRetencion { get; set; }
        public decimal? TotalLiquido { get; set; }
        public decimal? CosteSSEmpr { get; set; }
        public decimal? CosteHEEmp { get; set; }
        public decimal? CosteAccEmp { get; set; }
        public decimal? Prestaciones { get; set; }
        public decimal? TotalCosteSS { get; set; }

        public decimal? BaseAccidentes { get; set; }
        public decimal? BaseHorasExtras { get; set; }
        public decimal? ProrrataPagaExtra { get; set; }



        #endregion

        #region Properties ReadOnly

        #endregion

        #region Methods

        internal void Refresh()
        {
            Total = (BaseUnica ?? 0) + (Inventivo ?? 0) + (Bonus ?? 0);
        }

        public void RefreshBy(Nomina modelBase)
        {
            BaseUnica = modelBase.BaseUnica;
            Inventivo = modelBase.Inventivo;
            
            Refresh();
        }

        #endregion

    }

}
