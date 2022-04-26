using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteIncidente
    {
        public int IdExpedienteIncidente { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int IdTipoIncidente { get; set; }
        [ForeignKey("IdTipoIncidente")]
        public virtual Con_TipoIncidente Con_TipoIncidente { get; set; }



        public string Descripcion { get; set; } //o Objeto: cuadro con texto libre
        public string Resultado { get; set; }

        public string Actor { get; set; }       //o Demandante: cuadro con texto libre
        public string Demandado { get; set; }   //o Demandados: cuadro con texto libre

        public DateTime FechaInterposicion { get; set; } ////o Fecha de apertura: 
        public DateTime? FechaVista { get; set; }           //o Fecha de contestación a la demanda
        public DateTime? FechaSentencia { get; set; }       //o   Fecha de Sentencia
        public bool Apelacion { get; set; }                 //o Interposición de costas: cuadro Si/No;

        public decimal? ObligadoPagar { get; set; }
        public decimal? CuantiaEstimada { get; set; }

        public int? IdFase { get; set; }
        [ForeignKey("IdFase")]
        public virtual Con_TipoFase Con_TipoFase { get; set; }



        public int? DocumentoDemandaId { get; set; }
        public int? DocumentoSentenciaId { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }


    }
}



