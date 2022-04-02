using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ActividadAbogado")]
    public class ActividadAbogado
    {
        #region Constructors

        public ActividadAbogado() { }
        public ActividadAbogado(int idAbogado, DateTime fecha)
        {
            IdAbogado = idAbogado;
            Fecha = fecha;

            ActividadAbogadoDetalleSet = new List<ActividadAbogadoDetalle>();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 IdActividadAbogado { get; set; }
  
        public int IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public virtual ICollection<ActividadAbogadoDetalle> ActividadAbogadoDetalleSet { get; set; }



        #endregion

        #region Methods

        internal void AddActividad(ActividadAbogadoDetalle detalle)
        {
            ActividadAbogadoDetalleSet.Add(detalle);
        }

        #endregion

    }


    [Table("ActividadAbogadoDetalle")]
    public class ActividadAbogadoDetalle
    {
        #region Constructors

        public ActividadAbogadoDetalle() { }
        public ActividadAbogadoDetalle(int idActividad, int cantidad)
        {
            IdActividad = idActividad;
            Cantidad = cantidad;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        public Int64 IdActividadAbogado { get; set; }
        [ForeignKey("IdActividadAbogado")]
        public virtual ActividadAbogado ActividadAbogado { get; set; }

        public int IdActividad { get; set; }
        [ForeignKey("IdActividad")]
        public virtual CaracteristicaBase Actividad { get; set; }

        public int Cantidad { get; set; }

        #endregion

    }


    public class ModelActividadAbogado
    {
        #region Constructors

        public ModelActividadAbogado() { }
        public ModelActividadAbogado(CaracteristicaBase actividad)
        {
            Actividad = actividad;
        }
        public ModelActividadAbogado(CaracteristicaBase actividad, int cantidad, int cantidadPrev)
        {
            Actividad = actividad;
            Cantidad = cantidad;
            CantidadPrev = cantidadPrev;
        }

        #endregion

        #region Properties

        //public ActividadAbogado ActividadAbogado { get; set; }
        public CaracteristicaBase Actividad { get; set; }

        public int Cantidad { get; set; }
        public int CantidadPrev { get; set; }

        public int CantidadMtd { get; set; }
        public int CantidadYtd { get; set; }

        #endregion

        #region Properties ReadOnly

        public decimal EvolucionPerc => CantidadPrev == 0 || Cantidad == 0 ? 0M : 100 * Cantidad / CantidadPrev;

        #endregion
    }
}
