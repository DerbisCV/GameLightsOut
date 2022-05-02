namespace Solvtio.Data.Common
{
    public class ModelResult
    {
        public string ErrorMessage { get; set; }
        public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);
    }
}
