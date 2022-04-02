using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("AbogadoFacturacion")]
    public class AbogadoFacturacion
    {
        #region Constructors

        public AbogadoFacturacion() { }
        public AbogadoFacturacion(int anio, int idPersona)
        {
            IdPersona = idPersona;
            Anio = anio;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 IdAbogadoFacturacion { get; set; }
  
        public int IdPersona { get; set; }
        [ForeignKey("IdPersona")]
        public virtual Gnr_Abogado Abogado { get; set; }

        public int Anio { get; set; }
        
        public decimal? FacturacionPlan { get; set; }
        public decimal? FacturacionReal { get; set; }

        #endregion

        #region Properties ReadOnly

        public decimal? PorcientoCumplimiento => FacturacionReal.HasValue && FacturacionPlan.HasValue && FacturacionPlan > 0 ?
            FacturacionReal.Value / FacturacionPlan.Value :
            FacturacionPlan == 0 || FacturacionReal == 0 ? 0 :
            (decimal?)null;

        public decimal MargenBruto => (Facturacion ?? 0) - (GastosDirectos ?? 0);

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public decimal? GastosDirectos { get; set; }
        [NotMapped]
        public decimal? Facturacion { get; set; }

        #endregion

        #region Methods

        internal void Refresh()
        {
            //Total = (BaseUnica ?? 0) + (Inventivo ?? 0) + (Bonus ?? 0);
        }

        public void RefreshBy(AbogadoFacturacion modelBase)
        {
            FacturacionPlan = modelBase.FacturacionPlan;
            FacturacionReal = modelBase.FacturacionReal;
            
            Refresh();
        }

        #endregion

    }

}
