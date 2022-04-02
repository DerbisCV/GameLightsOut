using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteBastanteo")]
    public partial class ExpedienteBastanteo
    {
        #region Constructors

        public ExpedienteBastanteo()
        {
            CreateBase();
        }

        public ExpedienteBastanteo(int idExpediente)
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


        [DataType(DataType.Date)]
        public DateTime? FechaRealizacion { get; set; }

        public TipoAprobacion? Aprobacion { get; set; }

        public string NoDocumento { get; set; }
        public string RazonSocial { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        #endregion

        #region Methods

        internal void Refresh(ExpedienteBastanteo modelBase)
        {
            FechaRealizacion = modelBase.FechaRealizacion;
            Aprobacion = modelBase.Aprobacion;
            NoDocumento = modelBase.NoDocumento;
            RazonSocial = modelBase.RazonSocial;
        }

        #endregion
    }
}
