using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoAbogadoHistorico")]
    public class ExpedienteEstadoAbogadoHistorico
    {
        #region Constructors

        public ExpedienteEstadoAbogadoHistorico() { }
        public ExpedienteEstadoAbogadoHistorico(int idExpedienteEstado, ExpedienteEstado estadoNew, string usuario)
        {
            createBase();
            IdExpedienteEstado = idExpedienteEstado;
            Usuario = usuario;
            IdAbogado = estadoNew.Expediente.IdAbogado;
            IdTipoSubFaseEstado = estadoNew.IdTipoSubFaseEstado;
        }

        public ExpedienteEstadoAbogadoHistorico(ExpedienteEstado estadoBase, int? idTipoSubFaseEstado, string usuario)
        {
            createBase();
            IdExpedienteEstado = estadoBase.ExpedienteEstadoId;
            Usuario = usuario;
            IdAbogado = estadoBase.Expediente?.IdAbogado;
            IdTipoSubFaseEstado = idTipoSubFaseEstado;
        }

        private void createBase()
        {
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        //public TipoFaseEstado? FaseEstado { get; set; }
        public int? IdTipoSubFaseEstado { get; set; }
        [ForeignKey("IdTipoSubFaseEstado")]
        public virtual TipoSubFaseEstado TipoSubFaseEstado { get; set; }


        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion
    }
}
