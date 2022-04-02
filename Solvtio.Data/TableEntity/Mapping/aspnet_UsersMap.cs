using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_UsersMap : EntityTypeConfiguration<aspnet_Users>
    {
        public aspnet_UsersMap()
        {
            // Primary Key
            HasKey(t => t.UserId);

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
            ToTable("aspnet_Users");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.UserName).HasColumnName("UserName");
            Property(t => t.LoweredUserName).HasColumnName("LoweredUserName");
            Property(t => t.MobileAlias).HasColumnName("MobileAlias");
            Property(t => t.IsAnonymous).HasColumnName("IsAnonymous");
            Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");

            // Relationships
            HasRequired(t => t.aspnet_Applications)
                .WithMany(t => t.aspnet_Users)
                .HasForeignKey(d => d.ApplicationId);

        }
    }
}
