using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteScne")]
    public partial class ExpedienteScne
    {
        #region Constructors

        public ExpedienteScne()
        {
            CreateBase();
        }

        public ExpedienteScne(int idExpediente)
        {
            IdExpediente = idExpediente;
            CreateBase();
        }

        private void CreateBase()
        {          
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }

        public string Contrario { get; set; }
        public string Ciudad { get; set; }

        public int? IdTipoNotificacion { get; set; }
        [ForeignKey("IdTipoNotificacion")]
        public virtual CaracteristicaBase TipoNotificacion { get; set; }

        public int? IdTipoProcedimiento { get; set; }
        [ForeignKey("IdTipoProcedimiento")]
        public virtual CaracteristicaBase TipoProcedimiento { get; set; }

        public int? PlazoEnDias { get; set; }
        public DateTime? FechaSenalamiento { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        public int? NoPedido { get; set; }
        public int? ActaAceptacion { get; set; }
        public DateTime? FechaFacturaEnvio { get; set; }
        public DateTime? FechaFacturaCobro { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        #endregion

        #region Methods

        internal void Refresh(ExpedienteScne modelBase)
        {
            Contrario = modelBase.Contrario;
            Ciudad = modelBase.Ciudad;
            PlazoEnDias = modelBase.PlazoEnDias;
            FechaCaducidad = modelBase.FechaCaducidad;
            FechaSenalamiento = modelBase.FechaSenalamiento;
            FechaDevolucion = modelBase.FechaDevolucion;
            NoPedido = modelBase.NoPedido;
            ActaAceptacion = modelBase.ActaAceptacion;
            FechaFacturaEnvio = modelBase.FechaFacturaEnvio;
            FechaFacturaCobro = modelBase.FechaFacturaCobro;
            IdTipoNotificacion = modelBase.IdTipoNotificacion;
            IdTipoProcedimiento = modelBase.IdTipoProcedimiento;
        }

        #endregion
    }
}
