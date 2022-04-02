using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("InmuebleOferta")]
    public class InmuebleOferta
    {
        #region Constructors

        public InmuebleOferta(){ CreateBase(); }
        //public InmuebleOferta(string nombre, string telefono, string email)
        //{
        //    CreateBase();
        //    NombreApellidos = nombre;
        //    Telefono = telefono;
        //    Email = email;
        //}

        private void CreateBase()
        {
            Fecha = DateTime.Now.Date;
            Exclusividad = false;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInmuebleOferta { get; set; }

        public int IdInmueble { get; set; }
        [ForeignKey("IdInmueble")]
        public virtual Inmueble Inmueble { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaVencimiento { get; set; }

        public decimal? Importe { get; set; }

        public string Ofertante { get; set; }
        public bool Exclusividad { get; set; }
        public string Observaciones { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()}: {Importe} ({Ofertante}).";
        }

        public void Refresh(InmuebleOferta model)
        {
            Fecha = model.Fecha;
            FechaVencimiento = model.FechaVencimiento;
            Importe = model.Importe;
            Ofertante = model.Ofertante;
            Exclusividad = model.Exclusividad;
            Observaciones = model.Observaciones;
        }

        #endregion

    }
}
