using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_MembershipUsersMap : EntityTypeConfiguration<vw_aspnet_MembershipUsers>
    {
        public vw_aspnet_MembershipUsersMap()
        {
            // Primary Key
            HasKey(t => new { t.UserId, t.PasswordFormat, t.IsApproved, t.IsLockedOut, t.CreateDate, t.LastLoginDate, t.LastPasswordChangedDate, t.LastLockoutDate, t.FailedPasswordAttemptCount, t.FailedPasswordAttemptWindowStart, t.FailedPasswordAnswerAttemptCount, t.FailedPasswordAnswerAttemptWindowStart, t.ApplicationId, t.UserName, t.IsAnonymous, t.LastActivityDate });

            // Properties
            Property(t => t.PasswordFormat)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.MobilePIN)
                .HasMaxLength(16);

            Property(t => t.Email)
                .HasMaxLength(256);

            Property(t => t.LoweredEmail)
                .HasMaxLength(256);

            Property(t => t.PasswordQuestion)
                .HasMaxLength(256);

            Property(t => t.PasswordAnswer)
                .HasMaxLength(128);

            Property(t => t.FailedPasswordAttemptCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.FailedPasswordAnswerAttemptCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.MobileAlias)
                .HasMaxLength(16);

            // Table & Column Mappings
            ToTable("vw_aspnet_MembershipUsers");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.PasswordFormat).HasColumnName("PasswordFormat");
            Property(t => t.MobilePIN).HasColumnName("MobilePIN");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.LoweredEmail).HasColumnName("LoweredEmail");
            Property(t => t.PasswordQuestion).HasColumnName("PasswordQuestion");
            Property(t => t.PasswordAnswer).HasColumnName("PasswordAnswer");
            Property(t => t.IsApproved).HasColumnName("IsApproved");
            Property(t => t.IsLockedOut).HasColumnName("IsLockedOut");
            Property(t => t.CreateDate).HasColumnName("CreateDate");
            Property(t => t.LastLoginDate).HasColumnName("LastLoginDate");
            Property(t => t.LastPasswordChangedDate).HasColumnName("LastPasswordChangedDate");
            Property(t => t.LastLockoutDate).HasColumnName("LastLockoutDate");
            Property(t => t.FailedPasswordAttemptCount).HasColumnName("FailedPasswordAttemptCount");
            Property(t => t.FailedPasswordAttemptWindowStart).HasColumnName("FailedPasswordAttemptWindowStart");
            Property(t => t.FailedPasswordAnswerAttemptCount).HasColumnName("FailedPasswordAnswerAttemptCount");
            Property(t => t.FailedPasswordAnswerAttemptWindowStart).HasColumnName("FailedPasswordAnswerAttemptWindowStart");
            Property(t => t.Comment).HasColumnName("Comment");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.UserName).HasColumnName("UserName");
            Property(t => t.MobileAlias).HasColumnName("MobileAlias");
            Property(t => t.IsAnonymous).HasColumnName("IsAnonymous");
            Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");
        }
    }
}
