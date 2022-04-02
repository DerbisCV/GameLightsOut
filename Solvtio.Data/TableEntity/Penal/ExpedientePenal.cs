using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedientePenal")]
    public sealed class ExpedientePenal
    {
        #region Constructors

        public ExpedientePenal()
        {
            CreateBase();
        }

        public ExpedientePenal(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedientePenal(int idExpediente, int idDeudorPrincipal)
        {
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


        public int? IdClientePrincipal { get; set; }
        [ForeignKey("IdClientePrincipal")]
        public Gnr_Persona ClientePrincipal { get; set; }

        //public int? IdContacto { get; set; }
        //[ForeignKey("IdContacto")]
        //public Gnr_Persona Contacto { get; set; }

        public int? IdTipoPenal { get; set; }
        [ForeignKey("IdTipoPenal")]
        public CaracteristicaBase TipoPenal { get; set; }

        public int? NumeroArchivadores { get; set; }
        public string Descripcion { get; set; }


        public string ContactoNombre { get; set; }
        public string ContactoEmail { get; set; }
        public string ContactoTelefono { get; set; }
        public string ContactoRelacion { get; set; }


        [ForeignKey("Gnr_Persona")]
        public int IdDeudorPrincipal { get; set; }
        public Gnr_Persona Gnr_Persona { get; set; }


        //public int? IdExpedienteMn { get; set; }
        //public int? IdExpedienteEjc { get; set; }

        //public ExpPenalTipoAsunto TipoAsunto { get; set; }
        public string ContrarioAbogado { get; set; }
        public string Juez { get; set; }

        
        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedientePenal modelBase)
        {
            ContrarioAbogado = modelBase.ContrarioAbogado;
            Juez = modelBase.Juez;
            IdTipoPenal = modelBase.IdTipoPenal;
            //IdClientePrincipal = modelBase.IdClientePrincipal;
            Descripcion = modelBase.Descripcion;
            NumeroArchivadores = modelBase.NumeroArchivadores;

            ContactoNombre = modelBase.ContactoNombre;
            ContactoTelefono = modelBase.ContactoTelefono;
            ContactoEmail = modelBase.ContactoEmail;
            ContactoRelacion = modelBase.ContactoRelacion;
        }

        #endregion
    }
}
