using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class aspnet_MembershipMap : IEntityTypeConfiguration<aspnet_Membership>
    //{
    //    public aspnet_MembershipMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => t.UserId);

    //        // Properties
    //       builder.Property(t => t.Password)
    //            .IsRequired()
    //            .HasMaxLength(128);

    //       builder.Property(t => t.PasswordSalt)
    //            .IsRequired()
    //            .HasMaxLength(128);

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

    //        // Table & Column Mappings
    //       builder.ToTable("aspnet_Membership");
    //       builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
    //       builder.Property(t => t.UserId).HasColumnName("UserId");
    //       builder.Property(t => t.Password).HasColumnName("Password");
    //       builder.Property(t => t.PasswordFormat).HasColumnName("PasswordFormat");
    //       builder.Property(t => t.PasswordSalt).HasColumnName("PasswordSalt");
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

    //        // Relationships
    //        //HasRequired(t => t.aspnet_Applications)
    //        //    .WithMany(t => t.aspnet_Membership)
    //        //    .HasForeignKey(d => d.ApplicationId);
    //        //HasRequired(t => t.aspnet_Users)
    //        //    .WithOptional(t => t.aspnet_Membership);

    //    }
    //}
}
