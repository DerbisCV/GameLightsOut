namespace Solvtio.Models
{
    public class ExpedienteExt : IExpedienteExt
    {
        public int IdExpediente { get; set; }
        public int Id => IdExpediente;
    }

    public interface IExpedienteExt
    {
        int IdExpediente { get; set; }
    }
}