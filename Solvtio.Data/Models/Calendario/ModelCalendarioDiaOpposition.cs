namespace Solvtio.Models
{
    public class ModelCalendarioDiaOpposition //: IModelCalendarioDiaBase
    {
        public ModelCalendarioDiaOpposition() { }
		public ModelCalendarioDiaOpposition(int countTotal, int countWithOpposition)
        {
            CountWithOpposition = countWithOpposition;
            CountWithOutOpposition = countTotal - countWithOpposition;
        }

        public int CountWithOpposition { get; set; }
        public int CountWithOutOpposition { get; set; }
    }
}
