using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Data
{
    [Table("Configuracion")]
    public partial class Configuracion
    {
        [Key]
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string Observaciones { get; set; }
    }
}
