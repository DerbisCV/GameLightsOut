using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteDdl")]
    public class ExpedienteDdl
    {
        #region Constructors

        public ExpedienteDdl()
        {
            CreateBase();
        }

        public ExpedienteDdl(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            //Gnr_Persona = new Gnr_Persona();
        }

        //public ExpedienteDdl(int idExpediente, int idDeudorPrincipal)
        //{
        //    IdExpediente = idExpediente;
        //    IdDeudorPrincipal = idDeudorPrincipal;
        //}

        private void CreateBase()
        {
            TipoDdl = TipoDdl.Reo;
            ActivosIniciales = 0;
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }

        public string Vendedor { get; set; }

        public TipoDdl TipoDdl { get; set; }

        public int ActivosIniciales { get; set; }

        //[ForeignKey("Gnr_Persona")]
        //public int IdDeudorPrincipal { get; set; }
        //public Gnr_Persona Gnr_Persona { get; set; }


        //public int? IdExpedienteMn { get; set; }
        //public int? IdExpedienteEjc { get; set; }

        //public ExpDdlTipoAsunto TipoAsunto { get; set; }
        //public string ContrarioAbogado { get; set; }
        //public string Juez { get; set; }


        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public int TotalAsset { get; set; }
        [NotMapped]
        public int TotalAssetWithFlag { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteDdl modelBase)
        {
            Vendedor = modelBase.Vendedor;
            TipoDdl = modelBase.TipoDdl;
            ActivosIniciales = modelBase.ActivosIniciales;
        }

        #endregion

    }
}
