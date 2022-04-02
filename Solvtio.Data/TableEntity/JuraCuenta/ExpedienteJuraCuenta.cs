using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteJuraCuenta")]
    public sealed class ExpedienteJuraCuenta
    {
        #region Constructors

        public ExpedienteJuraCuenta()
        {
            CreateBase();
        }

        public ExpedienteJuraCuenta(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }

        public ExpedienteJuraCuenta(int idExpediente, int idDeudorPrincipal)
        {
            CreateBase();
            IdExpediente = idExpediente;
            IdDeudorPrincipal = idDeudorPrincipal;
        }

        private void CreateBase()
        {
            //TipoAsunto = ExpPenalTipoAsunto.Penal;
            //Expediente = new Expediente();
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }


        [DataType(DataType.Date)]
        public DateTime? VeniaFechaSolicitud { get; set; }
        public string VeniaAbogado { get; set; }
        public string VeniaCesion { get; set; }

        public string AbogadoDemandante { get; set; }
        public string Finalizada { get; set; }
        public bool Ciberlegal { get; set; }
        public decimal? ImporteReclamado { get; set; }
        public decimal? ImporteConsignado { get; set; }
        public decimal? ImporteDesestimacion { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaNotificacion { get; set; }


        public int? IdOperacion { get; set; }
        [ForeignKey("IdOperacion")]
        public CaracteristicaBase Operacion { get; set; }


        //@Html.DcvFormGroupItemTextEditFor("col-sm-4", "Abogado Demandante:", Model.ExpedienteJuraCuenta., "ExpedienteJuraCuenta.AbogadoDemandante")
        //            @Html.DcvFormGroupItemCheckBoxFor("col-sm-4", ":", Model.ExpedienteJuraCuenta.Ciberlegal, "ExpedienteJuraCuenta.Ciberlegal")
        //            @Html.DcvFormGroupItemTextEditFor("col-sm-4", "Finalizada:", Model.ExpedienteJuraCuenta., "ExpedienteJuraCuenta.Finalizada")

        public int? IdDeudorPrincipal { get; set; }
        [ForeignKey("IdDeudorPrincipal")]
        public Gnr_Persona DeudorPrincipal { get; set; }


        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteJuraCuenta modelBase)
        {
            VeniaFechaSolicitud = modelBase.VeniaFechaSolicitud;
            VeniaAbogado = modelBase.VeniaAbogado;
            VeniaCesion = modelBase.VeniaCesion;

            AbogadoDemandante = modelBase.AbogadoDemandante;
            Finalizada = modelBase.Finalizada;
            Ciberlegal = modelBase.Ciberlegal;
            ImporteReclamado = modelBase.ImporteReclamado;
            ImporteConsignado = modelBase.ImporteConsignado;
            ImporteDesestimacion = modelBase.ImporteDesestimacion;
            FechaNotificacion = modelBase.FechaNotificacion;
            IdOperacion = modelBase.IdOperacion;
        }

        #endregion
    }
}
