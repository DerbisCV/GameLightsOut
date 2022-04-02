using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("TipoHitoProcesal")]
    public class TipoHitoProcesal : INombre
    {
        #region Constructors

        public TipoHitoProcesal()
        {
            CreateBase();
        }
        public TipoHitoProcesal(int idTipoExpediente, string name)
        {
            CreateBase();
            IdTipoExpediente = idTipoExpediente;
            Nombre = name;
        }

        private void CreateBase()
        {
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoHitoProcesal { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public int Orden { get; set; }

        [Index("IX_IdTipoExpediente")]
        public int IdTipoExpediente { get; set; }
        [ForeignKey("IdTipoExpediente")]
        public virtual Gnr_TipoExpediente TipoExpediente { get; set; }

        public bool EsProcesal { get; set; }
        public bool EsEsencial { get; set; }
        public bool EsFacturable  { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<TipoHitoProcesalTiempoMedio> TipoHitoProcesalTiempoMedioSet { get; set; }
        public virtual ICollection<ClienteFacturaHitoProcesal> ClienteFacturaHitoProcesalSet { get; set; }
        public virtual ICollection<ExpedienteFactura> ExpedienteFacturaSet { get; set; }
        public virtual ICollection<ExpedienteHito> ExpedienteHitoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}

