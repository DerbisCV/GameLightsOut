using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_UsersMap : EntityTypeConfiguration<vw_aspnet_Users>
    {
        public vw_aspnet_UsersMap()
        {
            // Primary Key
            HasKey(t => new { t.ApplicationId, t.UserId, t.UserName, t.LoweredUserName, t.IsAnonymous, t.LastActivityDate });

            // Properties
            Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.LoweredUserName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.MobileAlias)
                .HasMaxLength(16);

            // Table & Column Mappings
            ToTable("vw_aspnet_Users");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.UserName).HasColumnName("UserName");
            Property(t => t.LoweredUserName).HasColumnName("LoweredUserName");
            Property(t => t.MobileAlias).HasColumnName("MobileAlias");
            Property(t => t.IsAnonymous).HasColumnName("IsAnonymous");
            Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");
        }
    }
}
