using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class AccionFlujo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAccionFlujo { get; set; }
        
        public int IdAccionOrigen { get; set; }
        public int IdAccionDestino { get; set; }
        public virtual TipoAccion TipoAccion { get; set; }
    }
}
