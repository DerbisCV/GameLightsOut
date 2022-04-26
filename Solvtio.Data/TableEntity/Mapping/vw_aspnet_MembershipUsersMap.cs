using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vw_aspnet_MembershipUsersMap : IEntityTypeConfiguration<vw_aspnet_MembershipUsers>
    //{
    //    public vw_aspnet_MembershipUsersMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.UserId, t.PasswordFormat, t.IsApproved, t.IsLockedOut, t.CreateDate, t.LastLoginDate, t.LastPasswordChangedDate, t.LastLockoutDate, t.FailedPasswordAttemptCount, t.FailedPasswordAttemptWindowStart, t.FailedPasswordAnswerAttemptCount, t.FailedPasswordAnswerAttemptWindowStart, t.ApplicationId, t.UserName, t.IsAnonymous, t.LastActivityDate });

    //        // Properties
    //       builder.Property(t => t.PasswordFormat)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.MobilePIN)
    //            .HasMaxLength(16);

    //       builder.Property(t => t.Email)
    //            .HasMaxLength(256);

    //       builder.Property(t => t.LoweredEmail)
    //            .HasMaxLength(256);

    //       builder.Property(t => t.PasswordQuestion)
    //            .HasMaxLength(256);

    //       builder.Property(t => t.PasswordAnswer)
    //            .HasMaxLength(128);

    //       builder.Property(t => t.FailedPasswordAttemptCount)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.FailedPasswordAnswerAttemptCount)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.UserName)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.MobileAlias)
    //            .HasMaxLength(16);

    //        // Table & Column Mappings
    //       builder.ToTable("vw_aspnet_MembershipUsers");
    //       builder.Property(t => t.UserId).HasColumnName("UserId");
    //       builder.Property(t => t.PasswordFormat).HasColumnName("PasswordFormat");
    //       builder.Property(t => t.MobilePIN).HasColumnName("MobilePIN");
    //       builder.Property(t => t.Email).HasColumnName("Email");
    //       builder.Property(t => t.LoweredEmail).HasColumnName("LoweredEmail");
    //       builder.Property(t => t.PasswordQuestion).HasColumnName("PasswordQuestion");
    //       builder.Property(t => t.PasswordAnswer).HasColumnName("PasswordAnswer");
    //       builder.Property(t => t.IsApproved).HasColumnName("IsApproved");
    //       builder.Property(t => t.IsLockedOut).HasColumnName("IsLockedOut");
    //       builder.Property(t => t.CreateDate).HasColumnName("CreateDate");
    //       builder.Property(t => t.LastLoginDate).HasColumnName("LastLoginDate");
    //       builder.Property(t => t.LastPasswordChangedDate).HasColumnName("LastPasswordChangedDate");
    //       builder.Property(t => t.LastLockoutDate).HasColumnName("LastLockoutDate");
    //       builder.Property(t => t.FailedPasswordAttemptCount).HasColumnName("FailedPasswordAttemptCount");
    //       builder.Property(t => t.FailedPasswordAttemptWindowStart).HasColumnName("FailedPasswordAttemptWindowStart");
    //       builder.Property(t => t.FailedPasswordAnswerAttemptCount).HasColumnName("FailedPasswordAnswerAttemptCount");
    //       builder.Property(t => t.FailedPasswordAnswerAttemptWindowStart).HasColumnName("FailedPasswordAnswerAttemptWindowStart");
    //       builder.Property(t => t.Comment).HasColumnName("Comment");
    //       builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
    //       builder.Property(t => t.UserName).HasColumnName("UserName");
    //       builder.Property(t => t.MobileAlias).HasColumnName("MobileAlias");
    //       builder.Property(t => t.IsAnonymous).HasColumnName("IsAnonymous");
    //       builder.Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");
    //    }
    //}
}
