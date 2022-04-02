using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Nota")]
    public class Nota : ITitulo
    {
        #region Constructors

        public Nota()
        {
            CreateBase();
        }

        public Nota(string nota, Usuario usuario)
        {
            CreateBase();
            Titulo = nota;
            if (usuario != null)
                IdUsuario = usuario.IdUsuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNota { get; set; }

        public DateTime Fecha { get; set; }
        public string Titulo { get; set; }


        public int? IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Gnr_ClienteOficina Empresa { get; set; }


        public int? IdOportunidad { get; set; }
        [ForeignKey("IdOportunidad")]
        public Oportunidad Oportunidad { get; set; }

        public int? IdContacto { get; set; }
        [ForeignKey("IdContacto")]
        public Contacto Contacto { get; set; }

        public int? IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
