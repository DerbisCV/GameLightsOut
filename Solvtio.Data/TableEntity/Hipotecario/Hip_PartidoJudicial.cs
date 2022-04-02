using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Hip_PartidoJudicial")]
    public class PartidoJudicial : INombre
    {
        public PartidoJudicial()
        {
            //Expedientes = new List<Expediente>();
            //ProcuradorPartidoJudicials = new List<ProcuradorPartidoJudicial>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPartidoJudicial { get; set; }
        [MaxLength(500)]
        public string Nombre { get; set; }

        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }

        public virtual ICollection<Expediente> Expedientes { get; set; }
        public virtual ICollection<ProcuradorPartidoJudicial> ProcuradorPartidoJudicials { get; set; }
    }

}
