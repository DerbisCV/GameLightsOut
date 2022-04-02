using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("OportunidadUsuario")]
    public class OportunidadUsuario
    {
        #region Constructors

        public OportunidadUsuario()
        {
            CreateBase();
        }
        public OportunidadUsuario(int idOportunidad, int idUsuario)
        {
            CreateBase();
            IdOportunidad = idOportunidad;
            IdUsuario = idUsuario;
        }
        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOportunidadUsuario { get; set; }
        
        public int IdOportunidad { get; set; }
        [ForeignKey("IdOportunidad")]
        public Oportunidad Oportunidad { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
