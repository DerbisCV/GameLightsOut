using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_ListasValores_Valores
    {
        public Gnr_ListasValores_Valores()
        {
            Alq_Expediente_Contratos = new List<Alq_Expediente_Contrato>();
            Alq_Expediente_Contratos1 = new List<Alq_Expediente_Contrato>();
            Alq_Expediente_Contratos2 = new List<Alq_Expediente_Contrato>();
            Alq_Expediente_Contratos3 = new List<Alq_Expediente_Contrato>();
            Alq_Expediente_EstadoTramitaJuzgado_Actuaciones = new List<Alq_Expediente_EstadoTramitaJuzgado_Actuacion>();
        }

        public int ID { get; set; }
        public int IDlista { get; set; }
        public string Codigo { get; set; }
        public string Etiqueta { get; set; }
        public decimal? ValorNumerico { get; set; }
        public int Orden { get; set; }
        public bool Baja { get; set; }
        public virtual ICollection<Alq_Expediente_Contrato> Alq_Expediente_Contratos { get; set; }
        public virtual ICollection<Alq_Expediente_Contrato> Alq_Expediente_Contratos1 { get; set; }
        public virtual ICollection<Alq_Expediente_Contrato> Alq_Expediente_Contratos2 { get; set; }
        public virtual ICollection<Alq_Expediente_Contrato> Alq_Expediente_Contratos3 { get; set; }
        public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> Alq_Expediente_EstadoTramitaJuzgado_Actuaciones { get; set; }
        public virtual Gnr_ListasValores_Listas Gnr_ListasValores_Listas { get; set; }
    }
}
