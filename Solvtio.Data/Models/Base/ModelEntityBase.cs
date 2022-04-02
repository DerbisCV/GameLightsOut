namespace Solvtio.Models
{
    public class ModelEntityBase
    {
        #region Constructors
        public ModelEntityBase() { }
        public ModelEntityBase(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
