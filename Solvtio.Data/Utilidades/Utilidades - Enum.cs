using Solvtio.Models;

namespace Solvtio.Models
{
    public static class ConversionesEnum
	{
		public static bool OnHipSubasta(this TipoFaseEstado? subFase)
		{
		    if (!subFase.HasValue) return false;

            var idSubFase = (int)subFase.Value;
            return idSubFase >= 1010600 && idSubFase <= 1010699;
		}

        public static bool OnHipSubasta(this int? idTipoFaseEstado)
        {
            if (!idTipoFaseEstado.HasValue) return false;
            return idTipoFaseEstado.Value.OnHipSubasta();
        }
        public static bool OnHipSubasta(this int idSubFase)
        {
            return idSubFase >= 1010600 && idSubFase <= 1010699;
        }

    }
}

