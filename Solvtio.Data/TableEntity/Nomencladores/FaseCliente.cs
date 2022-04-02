using Solvtio.Common;
using Solvtio.Models.Common;
using Solvtio.Models.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    [Table("FaseCliente")]
    public class FaseCliente : Auditable, INombre
    {
        #region Constructors

        public FaseCliente()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFaseCliente { get; set; }

        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public string CadPosibleNextVal { get; set; }
        public string CadPosibleNextMotivos { get; set; }

        public TipoExpedienteEnum TipoExpediente { get; set; }

        #endregion

        #region Properties ReadOnly

        public override bool IsNew => IdFaseCliente <= 0;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        public static List<KeyValue> GetPosiblesFasesClientes(Expediente expediente, ExpedienteFaseCliente faseCliente, List<KeyValue> lstAll)
        {
            if (expediente == null) return null;
            if (faseCliente == null || string.IsNullOrWhiteSpace(faseCliente.FaseCliente.CadPosibleNextVal)) return lstAll.Where(x => x.Key == "1" || x.Key == "25").ToList();

            var lstPosible = faseCliente.FaseCliente.CadPosibleNextVal?.Split('-')?.ToList();
            if (lstPosible.IsEmpty()) return lstAll.Where(x => x.Key == "1" || x.Key == "25").ToList();

            return lstAll.Where(x => lstPosible.Contains(x.Key)).ToList();
        }

        public static List<KeyValue> GetPosiblesMotivosClientes(Expediente expediente, ExpedienteFaseCliente faseCliente, List<KeyValue> lstAll)
        {
            if (expediente == null) return null;
            if (faseCliente == null) return lstAll.Where(x => x.Key == "1" || x.Key == "19" || x.Key == "30").ToList();
            if (string.IsNullOrWhiteSpace(faseCliente.FaseCliente.CadPosibleNextVal)) return new List<KeyValue>();

            var lstPosible = faseCliente.FaseCliente.CadPosibleNextMotivos?.Split('-')?.ToList();
            if (lstPosible.IsEmpty()) return new List<KeyValue>();

            return lstAll.Where(x => lstPosible.Contains(x.Key)).ToList();
        }

        #endregion

    }
}
