namespace Solvtio.Models
{
    public class ModelMenuBarByUser
    {
        #region Constructors

        public ModelMenuBarByUser() { }
        public ModelMenuBarByUser(string email)
        {
            Email = email;
        }
        public ModelMenuBarByUser(string menuOption, string email)
        {
            MenuOption = menuOption;
            Email = email;
        }

        #endregion

        #region Properties

        public string MenuOption { get; set; }
        public string Email { get; set; }
        public int? CountNotification { get; set; }
        public Usuario Usuario { get; set; }

        #endregion

        public bool IsSuperUser => Usuario.IdRole == SolvtioValue.IdRolAdministrador || Usuario.IdDepartamento == SolvtioValue.IdDepartamentoDirGeneral;
    }
}
