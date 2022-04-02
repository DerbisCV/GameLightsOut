namespace Solvtio.Models
{
    public partial class Gnr_PlantillasDoc
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        public string Detalle { get; set; }
        public int? IdTipoFormato { get; set; }
        public string VistaBD { get; set; }
        public string Documento { get; set; }
        public string DelimitadorCampos { get; set; }
        public string ListaCamposEnPlantilla { get; set; }
        public string ListaCamposVistaBD { get; set; }
    }
}
