using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("SlaOficina")]
    public class SlaOficina
    {
        #region Constructors

        public SlaOficina()
        {
            CreateBase();
        }
        public SlaOficina(int idSla)
        {
            CreateBase();
            IdSla = idSla;
        }
        public SlaOficina(int idSla, int idOficina, int targetMin, int targetMax)
        {
            CreateBase();
            IdSla = idSla;
            IdOficina = idOficina;
            TargetMin = targetMin;
            TargetMax = targetMax;
        }

        private void CreateBase()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSlaOficina { get; set; }

        public int IdSla { get; set; }
        [ForeignKey("IdSla")]
        public virtual Sla Sla { get; set; }

        public int IdOficina { get; set; }
        [ForeignKey("IdOficina")]
        public virtual Gnr_ClienteOficina Oficina { get; set; }

        public int TargetMin { get; set; }
        public int TargetMax { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<Gnr_ClienteOficina> ClienteOficinaSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
