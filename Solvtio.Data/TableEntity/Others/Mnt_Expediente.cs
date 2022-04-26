using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Mnt_Expediente")]
    public partial class Mnt_Expediente
    {
        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }
        
        public string CuentaOficina { get; set; }
        public string CuentaNo { get; set; }
        public decimal? Importe { get; set; }
        public int IdDeudorPrincipal { get; set; }
        [ForeignKey("IdDeudorPrincipal")]
        public virtual Gnr_Persona Gnr_Persona { get; set; }
    }
}
