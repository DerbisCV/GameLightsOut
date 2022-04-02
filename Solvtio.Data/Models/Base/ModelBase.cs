namespace Solvtio.Models
{
    public class ModelBase
	{
		#region Properties

		public string InfoMessage { get; set; }
		public string ErrorMessage { get; set; }

		#endregion

		#region Properties ReadOnly

		public bool HasInfo => !string.IsNullOrWhiteSpace(InfoMessage);
	    public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);

	    #endregion
	}

    public class ModelWithFilterBase : ModelBase
    {
        public ModelWithFilterBase() { }
        public ModelWithFilterBase(ModelFilterBase filter)
        {
            Filter = filter;
        }

        public ModelFilterBase Filter { get; set; }

       
    }
}
