using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class aspnet_UsersMap : IEntityTypeConfiguration<aspnet_Users>
    //{
    //    public aspnet_UsersMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => t.UserId);

    //        // Properties
    //       builder.Property(t => t.UserName)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.LoweredUserName)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.MobileAlias)
    //            .HasMaxLength(16);

    //        // Table & Column Mappings
    //       builder.ToTable("aspnet_Users");
    //       builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
    //       builder.Property(t => t.UserId).HasColumnName("UserId");
    //       builder.Property(t => t.UserName).HasColumnName("UserName");
    //       builder.Property(t => t.LoweredUserName).HasColumnName("LoweredUserName");
    //       builder.Property(t => t.MobileAlias).HasColumnName("MobileAlias");
    //       builder.Property(t => t.IsAnonymous).HasColumnName("IsAnonymous");
    //       builder.Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");

    //        // Relationships
    //        //HasRequired(t => t.aspnet_Applications)
    //        //    .WithMany(t => t.aspnet_Users)
    //        //    .HasForeignKey(d => d.ApplicationId);

    //    }
    //}
}
