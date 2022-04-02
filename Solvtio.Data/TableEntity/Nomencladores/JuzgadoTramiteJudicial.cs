using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("JuzgadoTramiteJudicial")]
    public class JuzgadoTramiteJudicial
    {
        #region Constructors

        public JuzgadoTramiteJudicial(){}
        public JuzgadoTramiteJudicial(int idJuzgado, int idTramite)
        {
            IdJuzgado = idJuzgado;
            IdTramiteJudicial = idTramite;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJuzgadoTramiteJudicial { get; set; }

        public int IdJuzgado { get; set; }
        [ForeignKey("IdJuzgado")]
        public virtual Juzgado Juzgado { get; set; }

        public int IdTramiteJudicial { get; set; }
        [ForeignKey("IdTramiteJudicial")]
        public virtual TramiteJudicial TramiteJudicial { get; set; }

        
        public int? Media { get; set; }
        public int? Mediana { get; set; }
        public int? TotalExpedientesAnalizados { get; set; }

        public int? MediaExterna { get; set; }
        public int? MedianaExterna { get; set; }

        #endregion

        #region Properties virtual ICollection

        #endregion

        #region Properties ReadOnly

        public int? MediaCalculada =>
            Media.HasValue && Media > 0 ? Media :
            Mediana.HasValue && Mediana > 0 ? Mediana :
            MediaExterna.HasValue && MediaExterna > 0 ? MediaExterna :
            MedianaExterna;

        #endregion

        #region Methods

        internal void Refresh(JuzgadoTramiteJudicial model)
        {
            Media = model.Media;
            Mediana = model.Mediana;
            TotalExpedientesAnalizados = model.TotalExpedientesAnalizados;
            MediaExterna = model.MediaExterna;
            MedianaExterna = model.MedianaExterna;
        }

        #endregion
    }
}
