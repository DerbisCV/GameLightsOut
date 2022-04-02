using System;
using Solvtio.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Solvtio.Models.Model;
using Solvtio.Models.Common;

namespace Solvtio.Models
{
    [Table("Cartera")]
    public class Cartera : Auditable, INombre
    {
        #region Constructors

        public Cartera()
        {
            CreateBase();
        }
        public Cartera(string name, string grupo, string codigoReferencia = null)
        {
            CreateBase();

            int orden = codigoReferencia.ToIntegerOrDefault(0);
            Nombre = name;
            Orden = orden;
        }
        public Cartera(string name, string grupo, string codigoReferencia, int orden)
        {
            CreateBase();

            Nombre = name;
            Orden = orden;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCartera { get; set; }

        public string Nombre { get; set; }
        public int Orden { get; set; }

        public TipoExpedienteEnum? TipoExpediente { get; set; }

        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        public override bool IsNew => IdCartera <= 0;

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Expediente> ExpedienteSet { get; set; }


        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
