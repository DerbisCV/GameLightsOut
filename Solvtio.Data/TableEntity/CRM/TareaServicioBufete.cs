using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("TareaServicioBufete")]
    public class TareaServicioBufete
    {
        #region Constructors

        public TareaServicioBufete()
        {
            CreateBase();
        }

        public TareaServicioBufete(int idTarea, int idServicioBufete)
        {
            CreateBase();
            IdTarea = idTarea;
            IdServicioBufete = idServicioBufete;
        }

        private void CreateBase()
        {
            //FechaInicio = DateTime.Now;
            //Expediente = new Expediente();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTareaServicioBufete { get; set; }

        public int IdTarea { get; set; }
        [ForeignKey("IdTarea")]
        public Tarea Tarea { get; set; }

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
