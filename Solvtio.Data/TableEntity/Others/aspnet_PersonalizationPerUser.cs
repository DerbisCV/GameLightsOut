using System;

namespace Solvtio.Models
{
    public partial class aspnet_PersonalizationPerUser
    {
        public System.Guid Id { get; set; }
        public Guid? PathId { get; set; }
        public Guid? UserId { get; set; }
        public byte[] PageSettings { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public virtual aspnet_Paths aspnet_Paths { get; set; }
        public virtual aspnet_Users aspnet_Users { get; set; }
    }
}
