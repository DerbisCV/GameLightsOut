using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Tiket")]
    public class Tiket : INombre
    {
        #region Constructors

        public Tiket()
        {
            CreateBase();
        }
        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Estado = EstadoTiket.Nuevo;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTiket { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EstadoTiket Estado { get; set; }

        public int? IdCreadoPor { get; set; }
        [ForeignKey("IdCreadoPor")]
        public Usuario CreadoPor { get; set; }

        public int? IdAsignadoA { get; set; }
        [ForeignKey("IdAsignadoA")]
        public Usuario AsignadoA { get; set; }

        public int? IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual CaracteristicaBase Tipo { get; set; }

        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string ModificadoPor { get; set; }

        internal void RefreshBy(Tiket model)
        {
            Nombre = model.Nombre;
            Descripcion = model.Descripcion;
            Estado = model.Estado;
            IdAsignadoA = model.IdAsignadoA;
            FechaModificacion = DateTime.Now;
            ModificadoPor = model.ModificadoPor;
            IdTipo = model.IdTipo;
        }

        #endregion

        #region Properties ICollection

        #endregion

        #region Properties ReadOnly

        #endregion
    }
}
