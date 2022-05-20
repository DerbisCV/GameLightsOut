using Solvtio.Common;

namespace Solvtio.Models.Common
{
    public class KpiInfo
    {
        public KpiInfo() { }

        public KpiInfo(int? count, TipoIndicadorQa tipoIndicadorQa)
        {
            Count = count ?? 0;
            TipoIndicador = tipoIndicadorQa;
            Id = (int)tipoIndicadorQa;
            Name = tipoIndicadorQa.GetDescriptionShort();
            Description = tipoIndicadorQa.GetDescription();
            DescriptionLarge = tipoIndicadorQa.HtmlGetDescriptionLargeOf();
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public TipoIndicadorQa? TipoIndicador { get; set; }
        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public string? DescriptionLarge { get; set; }
    }
}
