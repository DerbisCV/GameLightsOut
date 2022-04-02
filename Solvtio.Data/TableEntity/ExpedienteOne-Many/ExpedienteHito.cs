using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteHito")]
    public class ExpedienteHito
    {
        #region Constructors

        public ExpedienteHito() { CreateBase(); }
        //public ExpedienteHito(string nota, string usuario)
        //{
        //    CreateBase();
        //    Nota = nota;
        //    Usuario = usuario;
        //}
        public ExpedienteHito(int idExpediente, int idTipoHito, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            IdTipoHitoProcesal = IdTipoHitoProcesal;
            Usuario = usuario;
        }
        //public ExpedienteHito(ExpedienteEstado estado)
        //{
        //    CreateBase();
        //    IdExpediente = estado.IdExpediente;
        //    IdExpedienteEstado = estado.ExpedienteEstadoId;
        //    Nota = estado.Nota;
        //    Usuario = estado.NotaUsuario;
        //    NoteType = NoteType.Estado;
        //}

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteHito { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int IdTipoHitoProcesal { get; set; }
        [ForeignKey("IdTipoHitoProcesal")]
        public virtual TipoHitoProcesal TipoHitoProcesal { get; set; }

        public DateTime Fecha { get; set; }

        public string Fase { get; set; }
        public string Subfase { get; set; }


        public int? IdTipoEstado { get; set; }
        [ForeignKey("IdTipoEstado")]
        public virtual Gnr_TipoEstado TipoEstado { get; set; }

        public int? IdTipoSubFaseEstado { get; set; }
        [ForeignKey("IdTipoSubFaseEstado")]
        public virtual TipoSubFaseEstado TipoSubFaseEstado { get; set; }

        public bool EsProcesal { get; set; }
        public bool EsEsencial { get; set; }
        public bool? Facturar { get; set; }
        public bool? Facturado { get; set; }
        public decimal? FacturaImporte { get; set; }

        public decimal? FacturaImporteParteFija { get; set; }
        public decimal? FacturaImporteParteVariable { get; set; }

        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public decimal? NoExpediente { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()}: {TipoHitoProcesal?.Nombre}";
        }

        public void RefreshBy(ExpedienteHito model)
        {
            IdTipoHitoProcesal = model.IdTipoHitoProcesal;
            Fecha = model.Fecha;
            Fase = model.Fase;
            Subfase = model.Subfase;
            IdTipoEstado = model.IdTipoEstado;
            IdTipoSubFaseEstado = model.IdTipoSubFaseEstado;
            EsEsencial = model.EsEsencial;
            EsProcesal = model.EsProcesal;
            Facturar = model.Facturar;
            Facturado = model.Facturado;
            FacturaImporte = model.FacturaImporte;
            FacturaImporteParteFija = model.FacturaImporteParteFija;
            FacturaImporteParteVariable = model.FacturaImporteParteVariable;            
            Usuario = model.Usuario;
        }

        #endregion

    }
}
