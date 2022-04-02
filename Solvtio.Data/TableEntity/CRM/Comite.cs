using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Comite")]
    public class Comite : INombre
    {
        #region Constructors

        public Comite()
        {
            CreateBase();
        }

        public Comite(DateTime fecha)
        {
            CreateBase();
            Fecha = fecha;
            Nombre = fecha.ToString("yyyy MM dd");
        }

        private void CreateBase()
        {
            Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComite { get; set; }

        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }


        //public int IdEmpresa { get; set; }
        //[ForeignKey("IdEmpresa")]
        //public Gnr_ClienteOficina Empresa { get; set; }

        //public string Gestor { get; set; }


        //public int? IdOportunidad { get; set; }
        //[ForeignKey("IdOportunidad")]
        //public Oportunidad Oportunidad { get; set; }

        //public int? IdUsuario { get; set; }
        //[ForeignKey("IdUsuario")]
        //public Usuario Usuario { get; set; }

        public virtual ICollection<Tarea> TareaSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
