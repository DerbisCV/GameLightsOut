using System;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations;

namespace Solvtio.Models
{
    [Table("ExpedienteSalarioSaldo")]
    public class ExpedienteSalarioSaldo
    {
        #region Constructors

        public ExpedienteSalarioSaldo()
        {
        }

        public ExpedienteSalarioSaldo(int idExpediente)
        {
            IdExpediente = idExpediente;
            //Tipo = tipoBienEmbargo;
            Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteSalarioSaldo { get; set; }


        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        //public TipoBienEmbargo Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Entidad { get; set; }
        public decimal? Importe { get; set; }       

        #endregion

    }
}
