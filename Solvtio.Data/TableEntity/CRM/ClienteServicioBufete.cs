using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ClienteServicioBufete")]
    public class ClienteServicioBufete
    {
        #region Constructors

        public ClienteServicioBufete()
        {
            CreateBase();
        }

        //public ClienteServicioBufete(int idValija)
        //{
        //    CreateBase();
        //    Expediente = new Expediente(idValija);
        //    Gnr_Persona = new Gnr_Persona();
        //}

        private void CreateBase()
        {
            FechaInicio = DateTime.Now;
            //Expediente = new Expediente();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClienteServicioBufete { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; } 

        public int IdClienteOficina { get; set; }
        [ForeignKey("IdClienteOficina")]
        public Gnr_ClienteOficina ClienteOficina { get; set; }

        public int IdServicioBufete { get; set; }
        [ForeignKey("IdServicioBufete")]
        public ServicioBufete ServicioBufete { get; set; }    

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
