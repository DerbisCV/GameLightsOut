using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    [Table("Juzgado")]
    public class Juzgado : IName
    {
        #region Constructors

        public Juzgado(){}

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJuzgado { get; set; }
        public string Nombre { get; set; }
        public string CodigoPostal { get; set; }

        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }

        public int? IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio { get; set; }

        public string Direccion { get; set; }
        public string Localidad { get; set; }

        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Competencia { get; set; }
        public string CodigoCcAa { get; set; }
        public string CodigoSgom { get; set; }
        public bool OrganoCentral { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Expediente> ExpedienteSet { get; set; }
        public virtual ICollection<HipExpedienteEstadoTramitacionSubasta> HipExpedienteEstadoTramitacionJuzgadoSet { get; set; }
        public virtual ICollection<ExpedienteOrdinarioCs> ExpedienteOrdinarioCsSet { get; set; }
        public virtual ICollection<ExpedienteJurisdiccionVoluntaria> ExpedienteJurisdiccionVoluntariaSet { get; set; }
        public virtual ICollection<JuzgadoTramiteJudicial> JuzgadoTramiteJudicialSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public int Id => IdJuzgado;
        public int? TotalDiasTramiteJudicialHip => JuzgadoTramiteJudicialSet?
            .Where(x => x.TramiteJudicial.Activo && x.TramiteJudicial.IdEstado.HasValue && x.TramiteJudicial.Estado.IdTipoExpediente == 1)
            .GroupBy(x => x.TramiteJudicial.IdEstado)
            .Select(cl => new {
                IdEstado = cl.First().TramiteJudicial.IdEstado,
                MediaCalculadaMax = cl.Max(x => x.MediaCalculada)
            })
            .Sum(x => x.MediaCalculadaMax ?? 0);


    //    List<ResultLine> result = Lines
    //.GroupBy(l => l.ProductCode)
    //.Select(cl => new ResultLine
    //{
    //    ProductName = cl.First().Name,
    //    Quantity = cl.Count().ToString(),
    //    Price = cl.Sum(c => c.Price).ToString(),
    //}).ToList();




        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
