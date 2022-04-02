using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("TipoHitoProcesalTiempoMedio")]
    public class TipoHitoProcesalTiempoMedio
    {
        #region Constructors

        public TipoHitoProcesalTiempoMedio()
        {
            CreateBase();
        }
        private void CreateBase()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdTipoHitoProcesal { get; set; }
        [ForeignKey("IdTipoHitoProcesal")]
        public virtual TipoHitoProcesal TipoHitoProcesal { get; set; }

        public int Tiempo1 { get; set; }
        public int Tiempo2 { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<ExpedienteEstado> ExpedienteEstadoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
