using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Pagador")]
    public class Pagador : INombre
    {
        #region Constructors

        public Pagador()
        {
            Activo = true;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagador { get; set; }
        public string Nombre { get; set; }
        public string NoDocumento { get; set; }
        public bool Activo { get; set; }

        internal void RefreshBy(Pagador model)
        {
            Nombre = model.Nombre;
            NoDocumento = model.NoDocumento;
            Activo = model.Activo;
        }

        #endregion

        #region Properties ICollection

        public virtual ICollection<PagadorCliente> PagadorClienteSet { get; set; }
        
        //public virtual ICollection<Gnr_Cliente> ClienteSet { get; set; }
        public virtual ICollection<Expediente> ExpedienteSet { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public int? IdClienteNew { get; set; }

        #endregion
    }

    [Table("PagadorCliente")]
    public class PagadorCliente
    {
        public int IdPagador { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdPagador")]
        public Pagador Pagador { get; set; }
        
        [ForeignKey("IdCliente")]
        public Gnr_Cliente Cliente { get; set; }       
    }
}
