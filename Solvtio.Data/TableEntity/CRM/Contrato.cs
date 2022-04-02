using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Contrato")]
    public class Contrato : INombre
    {
        #region Constructors

        public Contrato()
        {
            CreateBase();
        }

        public Contrato(string nombre, int idEmpresa)
        {
            CreateBase();
            IdEmpresa = idEmpresa;
            Nombre = nombre;
            //if (usuario != null)
            //    IdUsuario = usuario.IdUsuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContrato { get; set; }

        public DateTime Fecha { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Nombre { get; set; }


        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Gnr_ClienteOficina Empresa { get; set; }

        public string Gestor { get; set; }
        public string OportunidadComisionista { get; set; }

        //public int? IdOportunidad { get; set; }
        //[ForeignKey("IdOportunidad")]
        //public Oportunidad Oportunidad { get; set; }

        //public int? IdUsuario { get; set; }
        //[ForeignKey("IdUsuario")]
        //public Usuario Usuario { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
