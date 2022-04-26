using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Neg_Gestion
    {
        #region Constructors

        public Neg_Gestion()
        {
            FechaAlta = DateTime.Now;
            Neg_GestionEstados = new List<Neg_GestionEstado>();
        }

        public Neg_Gestion(int? id)
        {
            FechaAlta = DateTime.Now;
            Neg_GestionEstados = new List<Neg_GestionEstado>();
            if (id.HasValue) IdExpediente = id.Value;
        }


        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }
        
        public int IdGestor { get; set; }
        public bool Plan30 { get; set; }
        public string Observacion { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public string OficinaSucursalNo { get; set; }
        public string OficinaSucursalTelefono { get; set; }
        public string OficinaSucursalObservacion { get; set; }
        public int? IdTipoEstadoLast { get; set; }
        public decimal? DeudaNegociacion { get; set; }
        public decimal? DeudaRecuperada { get; set; }
        
        public virtual Gnr_Persona Gnr_Persona { get; set; }
        public virtual ICollection<Neg_GestionEstado> Neg_GestionEstados { get; set; }

        #endregion
    }
}
