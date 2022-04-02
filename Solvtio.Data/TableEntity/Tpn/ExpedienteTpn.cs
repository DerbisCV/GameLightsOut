using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteTpn")]
    public partial class ExpedienteTpn
    {
        #region Constructors

        public ExpedienteTpn()
        {
            CreateBase();
        }

        public ExpedienteTpn(int idExpediente)
        {
            IdExpediente = idExpediente;
            CreateBase();
        }

        private void CreateBase()
        {
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }

        public TipoActivo TipoActivo { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime? FechaRealizacion { get; set; }



        //public string NoDocumento { get; set; }
        //public string RazonSocial { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public Hip_Inmueble Inmueble { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteTpn modelBase)
        {
            TipoActivo = modelBase.TipoActivo;
            //Aprobacion = modelBase.Aprobacion;
            //NoDocumento = modelBase.NoDocumento;
            //RazonSocial = modelBase.RazonSocial;
        }

        #endregion
    }
}
