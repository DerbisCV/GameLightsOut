using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;
using System.Collections.Generic;

namespace Solvtio.Models
{
    [Table("Oportunidad")]
    public class Oportunidad : ITitulo
    {
        #region Constructors

        public Oportunidad()
        {
            CreateBase();
        }

        //public Oportunidad(int idValija)
        //{
        //    CreateBase();
        //    Expediente = new Expediente(idValija);
        //    Gnr_Persona = new Gnr_Persona();
        //}

        private void CreateBase()
        {
            Fecha = DateTime.Now;
            TipoOportunidad = TipoOportunidad.Negociacion;
            EstadoOportunidad = EstadoOportunidad.EnProceso;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOportunidad { get; set; }

        public DateTime Fecha { get; set; }
        public string Titulo { get; set; }
        public string Detalles { get; set; }
        public string Valoraciones { get; set; }
        public TipoOportunidad TipoOportunidad { get; set; }
        public EstadoOportunidad EstadoOportunidad { get; set; }

        public int? IdTipoExpediente { get; set; }
        [ForeignKey("IdTipoExpediente")]
        public Gnr_TipoExpediente TipoExpediente { get; set; }


        public int? IdContacto { get; set; }
        [ForeignKey("IdContacto")]
        public Contacto Contacto { get; set; }

        public int? IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Gnr_ClienteOficina Empresa { get; set; }

        public int? IdUsuarioResponsable { get; set; }
        [ForeignKey("IdUsuarioResponsable")]
        public Usuario UsuarioResponsable { get; set; }

        #region Negociación

        public decimal? Precio { get; set; }
        public TipoPrecio TipoPrecio { get; set; }
        public DateTime? FechaCierreEstimada { get; set; }

        #endregion

        public virtual ICollection<Nota> NotaSet { get; set; }
        public virtual ICollection<Tarea> TareaSet { get; set; }
        public virtual ICollection<OportunidadContacto> OportunidadContactoSet { get; set; }
        public virtual ICollection<OportunidadUsuario> OportunidadUsuarioSet { get; set; }

        //public int IdCreadoPor { get; set; }
        //[ForeignKey("IdCreadoPor")]
        //public Contacto CreadoPor { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
