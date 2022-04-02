using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteProcura")]
    public partial class ExpedienteProcura
    {
        #region Constructors

        public ExpedienteProcura()
        {
            CreateBase();
        }

        public ExpedienteProcura(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }

        //public ExpedienteProcura(int idExpediente, int idDeudorPrincipal)
        //{
        //    IdExpediente = idExpediente;
        //    IdDeudorPrincipal = idDeudorPrincipal;
        //}

        private void CreateBase()
        {
            //Gnr_Persona = new Gnr_Persona();
            //Expediente = new Expediente();
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }

        public string Procedimiento { get; set; }
        public string Organismo { get; set; }
        public string OrganismoNo { get; set; }
        public string Poblacion { get; set; }
        public string Abogado { get; set; }
        public string Contrario { get; set; }
        public string Referencia3 { get; set; }
        public string Cliente { get; set; }

        //[ForeignKey("Gnr_Persona")]
        //public int IdDeudorPrincipal { get; set; }
        //public Gnr_Persona Gnr_Persona { get; set; }



        public int? IdSituacion { get; set; }
        [ForeignKey("IdSituacion")]
        public virtual CaracteristicaBase Situacion { get; set; }

        public int? IdInterviniente { get; set; }
        [ForeignKey("IdInterviniente")]
        public virtual CaracteristicaBase Interviniente { get; set; }


        //public string Observaciones { get; set; }

        //public bool EsExterno { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteProcura modelBase)
        {
            Referencia3 = modelBase.Referencia3;
            Procedimiento = modelBase.Procedimiento;
            Cliente = modelBase.Cliente;
            Organismo = modelBase.Organismo;
            OrganismoNo = modelBase.OrganismoNo;
            Poblacion = modelBase.Poblacion;
            Contrario = modelBase.Contrario;
            Abogado = modelBase.Abogado;
            IdSituacion = modelBase.IdSituacion;
            IdInterviniente = modelBase.IdInterviniente;
        }

        #endregion
    }
}
