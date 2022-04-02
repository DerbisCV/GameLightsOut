using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    public class Factura
    {
        #region Constructors

        public Factura()
        {
            ExpedienteFacturaSet = new List<ExpedienteFactura>();
        }
        public Factura(ExpedienteFactura expFactura)
        {
            CreateBase();
            NoFactura = expFactura.Factura?.NoFactura;
            Fecha = expFactura.Fecha;
            Usuario = expFactura.UsuarioAlta;
            BaseImponible = expFactura.Importe;
            ImporteTotal = ((100 + Iva)/100) * expFactura.Importe;
            IdCliente = expFactura.Expediente.Gnr_ClienteOficina.IdCliente;
            Observaciones = expFactura.Observaciones;
            HitoFacturacion = expFactura.HitoFacturacion;
        }

        private void CreateBase()
        {
            Iva = 21;
            FechaAlta = DateTime.Now;
        }

        #endregion

        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public HitoFacturacionValue HitoFacturacion { get; set; }
        public string NoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? Iva { get; set; }
        public decimal? ImporteTotal { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Usuario { get; set; }
        public bool Aprobada { get; set; }

        public virtual ICollection<ExpedienteFactura> ExpedienteFacturaSet { get; set; }
        public virtual Gnr_Cliente Gnr_Cliente { get; set; }

        #region Properties ReadOnly

        public bool IsOwnerOfChildrenExpedienteFactura => HitoFacturacion == HitoFacturacionValue.OrdinarioCsHito1 ||
                                                          HitoFacturacion == HitoFacturacionValue.OrdinarioCsHito2;

        private HitoFacturacionValue HitoFacturacionValue => HitoFacturacion;

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public List<ExpedienteFactura> LstExpedienteFacturaPosibles { get; set; }

        #endregion
    }
}
