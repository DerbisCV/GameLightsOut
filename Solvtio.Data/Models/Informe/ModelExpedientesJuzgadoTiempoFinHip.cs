namespace Solvtio.Models
{
    public class ModelExpedientesJuzgadoTiempoFinHip
    {
        public int IdJuzgado { get; set; }
        public int IdTipoExpediente { get; set; }
        public int CountAgil { get; set; }
        public int CountNormal { get; set; }
        public int CountLento { get; set; }
        public int CountMuyLento { get; set; }
        public Juzgado Juzgado { get; set; }

    }
}
