using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("RegistroComunicacion")]
    public class RegistroComunicacion
    {
        #region Constructors

        public RegistroComunicacion() {}

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegistroComunicacion { get; set; }

        public string Origen { get; set; } //Nombre del archivo desde donde se importa
        public string Referencia { get; set; } //ID

        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }

        public string Hora { get; set; }
        public string Tipo { get; set; }
        public string Altavoz { get; set; }
        public string Sonando { get; set; }
        public string Numero { get; set; }
        //public long? DuracionEnSegundos { get; set; }
        public int? Duracion { get; set; }
        public string Detalles { get; set; }
        public bool Unificada { get; set; }

        #endregion
    }
}
