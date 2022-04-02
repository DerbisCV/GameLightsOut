using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Procura")]
    public class Procura
    {
        #region Constructors

        public Procura()
        {
            CreateBase();
        }
        public Procura(string refCatastral)
        {
            CreateBase();
            //IdExpediente = idExpediente;
            //IdExpedienteDeudor = idExpDeudor;
            //EsHabitual = true;
        }
        public Procura(Expediente expediente)
        {
            CreateBase();
            Expediente = expediente;

            IdExpediente = expediente.IdExpediente;
            IdClienteOficina = expediente.IdClienteOficina;
            TipoProcedimiento = expediente.TipoExpediente;
            Referencia = expediente.NoExpediente;
            NoAutos = expediente.NoAuto;
            Cuantia = expediente.DeudaFinal ?? 0;
            Contrario = expediente.DeudorPrincipalNombreApellidos;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Now.Date;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProcura { get; set; }

        [Index]
        public int? IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime Fecha { get; set; }
        public string Poblacion { get; set; }

        public int? IdSituacion { get; set; }
        [ForeignKey("IdSituacion")]
        public virtual CaracteristicaBase Situacion { get; set; }


        #region Expediente Herencia

        public int IdClienteOficina { get; set; }
        [ForeignKey("IdClienteOficina")]
        public virtual Gnr_ClienteOficina Oficina { get; set; }

        public TipoExpedienteEnum TipoProcedimiento { get; set; }

        public string Referencia { get; set; }
        public string NoAutos { get; set; }

        public string Contrario { get; set; }
        public decimal Cuantia { get; set; }

        public string Observaciones { get; set; }

        #endregion

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string UrlFolderSp { get; set; }

        #endregion

        #region Properties ReadOnly

        //public string DireccionCompleta => $"{Direccion} {DireccionCodigoPostal} {Municipio?.Nombre} {Provincia?.Nombre}";

        #endregion

        #region Methods

        //public override string ToString()
        //{
        //    return 
        //        !string.IsNullOrWhiteSpace(NumeroFinca) ? NumeroFinca : 
        //        !string.IsNullOrWhiteSpace(Descripcion) ? Descripcion : 
        //        Direccion;
        //}

        public void RefreshBy(Procura model)
        {
            Fecha = model.Fecha;
            Poblacion = model.Poblacion;
            IdSituacion = model.IdSituacion;
            Observaciones = model.Observaciones;

            if (model.Expediente != null && model.IdExpediente.HasValue)
            {
                IdClienteOficina = model.Expediente.IdClienteOficina;
                TipoProcedimiento = model.Expediente.TipoExpediente;
                NoAutos = model.Expediente.NoAuto;
                Cuantia = model.Expediente.DeudaFinal ?? 0;
                Contrario = model.Expediente.DeudorPrincipalNombreApellidos;
            }
            else
            {
                Referencia = model.Referencia;
                IdClienteOficina = model.IdClienteOficina;
                TipoProcedimiento = model.TipoProcedimiento;
                NoAutos = model.NoAutos;
                Contrario = model.Contrario;
                Cuantia = model.Cuantia;
            }
        }

        #endregion
    }
}
