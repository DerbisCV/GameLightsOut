using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("CodigoPostal")]
    public class CodigoPostal
    {
        #region Constructors

        public CodigoPostal(){}

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CP { get; set; }

        public string Población { get; set; }

        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }

        public int? TotalHabitantes { get; set; }

        public string CodigoIne { get; set; }
        public string Referencia { get; set; }

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
    }
}
