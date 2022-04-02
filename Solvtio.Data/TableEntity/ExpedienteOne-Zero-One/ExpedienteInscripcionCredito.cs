using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteInscripcionCredito")]
    public class ExpedienteInscripcionCredito //: IExpedienteEstado
    {
        #region Constructors

        public ExpedienteInscripcionCredito()
        {
            CreateBase();
        }

        public ExpedienteInscripcionCredito(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            //Fecha = DateTime.Today;
            //Situacion = TipoSituacionEstado.NoIniciado;
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }


        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public DateTime? FechaEnvioProcurador { get; set; }
        public string Reclamacion { get; set; }
        public bool ReciboOriginal { get; set; }
        public bool ReciboCopiaSimple { get; set; }

        public string Observacion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        public DateTime? CargaPosteriorFechaSolicitud { get; set; }
        public DateTime? CargaPosteriorFechaRecepcion { get; set; }
        public string CargaPosteriorObservacion { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion

        //public virtual ICollection<ExpedienteAccion> ExpedienteAccions { get; set; }
        //public virtual ICollection<Hip_ExpedienteGarantia> Hip_ExpedienteGarantia { get; set; }
    }
}
