using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("OportunidadContacto")]
    public class OportunidadContacto
    {
        #region Constructors

        public OportunidadContacto()
        {
            CreateBase();
        }
        public OportunidadContacto(int idOportunidad, int idContacto)
        {
            CreateBase();
            IdOportunidad = idOportunidad;
            IdContacto = idContacto;
        }
        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOportunidadContacto { get; set; }
        
        public int IdOportunidad { get; set; }
        [ForeignKey("IdOportunidad")]
        public Oportunidad Oportunidad { get; set; }

        public int IdContacto { get; set; }
        [ForeignKey("IdContacto")]
        public Contacto Contacto { get; set; }

        [NotMapped]
        public int? IdResponsable { get; set; }

        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public int? IdClienteOficina { get; set; }

        #endregion
    }
}
