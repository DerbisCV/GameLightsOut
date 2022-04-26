using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vw_aspnet_UsersMap : IEntityTypeConfiguration<vw_aspnet_Users>
    //{
        //public vw_aspnet_UsersMap()
        //{
        //    // public void Configure(EntityTypeBuilder<object> builder)
        //   builder.HasKey(t => new { t.ApplicationId, t.UserId, t.UserName, t.LoweredUserName, t.IsAnonymous, t.LastActivityDate });

        //    // Properties
        //   builder.Property(t => t.UserName)
        //        .IsRequired()
        //        .HasMaxLength(256);

        //   builder.Property(t => t.LoweredUserName)
        //        .IsRequired()
        //        .HasMaxLength(256);

        //   builder.Property(t => t.MobileAlias)
        //        .HasMaxLength(16);

        //    // Table & Column Mappings
        //   builder.ToTable("vw_aspnet_Users");
        //   builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
        //   builder.Property(t => t.UserId).HasColumnName("UserId");
        //   builder.Property(t => t.UserName).HasColumnName("UserName");
        //   builder.Property(t => t.LoweredUserName).HasColumnName("LoweredUserName");
        //   builder.Property(t => t.MobileAlias).HasColumnName("MobileAlias");
        //   builder.Property(t => t.IsAnonymous).HasColumnName("IsAnonymous");
        //   builder.Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");
        //}
    //}
}
