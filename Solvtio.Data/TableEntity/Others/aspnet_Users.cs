using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class aspnet_Users
    {
        public aspnet_Users()
        {
            aspnet_PersonalizationPerUser = new List<aspnet_PersonalizationPerUser>();
            Gnr_Persona = new List<Gnr_Persona>();
            aspnet_Roles = new List<aspnet_Roles>();
        }

        public System.Guid ApplicationId { get; set; }
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public System.DateTime LastActivityDate { get; set; }
        //public virtual aspnet_Applications aspnet_Applications { get; set; }
        //public virtual aspnet_Membership aspnet_Membership { get; set; }
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        //public virtual aspnet_Profile aspnet_Profile { get; set; }
        public virtual ICollection<Gnr_Persona> Gnr_Persona { get; set; }
        public virtual ICollection<aspnet_Roles> aspnet_Roles { get; set; }
    }
}
