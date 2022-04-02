using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteSubasta")]
    public class ExpedienteSubasta
    {
        #region Constructors

        public ExpedienteSubasta(){ CreateBase(); }
        public ExpedienteSubasta(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }
        public ExpedienteSubasta(ExpedienteSubasta subastaBase, int idExpediente)
        {
            CreateBase();
            RefreshBy(subastaBase);
            IdExpediente = idExpediente;
        }

        private void CreateBase()
        {
            FechaSolicitud = DateTime.Today;
        }

        #endregion


        #region Properties
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteSubasta { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaDecretoSubasta { get; set; }
        public DateTime? FechaCelebracion { get; set; }
        public bool EsFestivo { get; set; }

        public DateTime? EdictoFecha { get; set; }
        public bool EdictoConDefecto { get; set; }
        public bool EdictoTasaDisponible { get; set; }

        public int? IdMotivoSuspension { get; set; }
        [ForeignKey("IdMotivoSuspension")]
        public virtual Gnr_TipoEstadoMotivo MotivoSuspension { get; set; }

        public int? IdMotivoSuspensionDecretoSubasta { get; set; }
        [ForeignKey("IdMotivoSuspensionDecretoSubasta")]
        public virtual Gnr_TipoEstadoMotivo MotivoSuspensionDecretoSubasta { get; set; }

        public SubastaType SubastaType { get; set; }
        public string Usuario { get; set; }

        public DateTime? FechaInformeSubasta { get; set; }
        public string IdentificadorSubasta { get; set; }
        public DateTime? FechaTasa { get; set; }
        public DateTime? FechaAutorizacionTasa { get; set; }
        public DateTime? FechaInstrucciones { get; set; }
        public DateTime? FechaNotificacionDecreto { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region RefreshBy

        public void RefreshBy(ExpedienteSubasta subastaBase)
        {
            FechaSolicitud = subastaBase.FechaSolicitud;
            FechaDecretoSubasta = subastaBase.FechaDecretoSubasta;
            FechaCelebracion = subastaBase.FechaCelebracion;
            EsFestivo = subastaBase.EsFestivo;
            EdictoFecha = subastaBase.EdictoFecha;
            EdictoConDefecto = subastaBase.EdictoConDefecto;
            EdictoTasaDisponible = subastaBase.EdictoTasaDisponible;
            FechaInformeSubasta = subastaBase.FechaInformeSubasta;
            IdentificadorSubasta = subastaBase.IdentificadorSubasta;
            FechaTasa = subastaBase.FechaTasa;
            FechaAutorizacionTasa = subastaBase.FechaAutorizacionTasa;
            FechaInstrucciones = subastaBase.FechaInstrucciones;
            FechaNotificacionDecreto = subastaBase.FechaNotificacionDecreto;
            SubastaType = subastaBase.SubastaType;
            IdMotivoSuspension = subastaBase.IdMotivoSuspension;
            IdMotivoSuspensionDecretoSubasta = subastaBase.IdMotivoSuspensionDecretoSubasta;
            Usuario = subastaBase.Usuario;
        }

        #endregion
    }
}
