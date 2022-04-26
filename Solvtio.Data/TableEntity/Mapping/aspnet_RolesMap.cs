using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class aspnet_RolesMap : IEntityTypeConfiguration<aspnet_Roles>
    //{
    //    public aspnet_RolesMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => t.RoleId);

    //        // Properties
    //       builder.Property(t => t.RoleName)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.LoweredRoleName)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.Description)
    //            .HasMaxLength(256);

    //        // Table & Column Mappings
    //       builder.ToTable("aspnet_Roles");
    //       builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
    //       builder.Property(t => t.RoleId).HasColumnName("RoleId");
    //       builder.Property(t => t.RoleName).HasColumnName("RoleName");
    //       builder.Property(t => t.LoweredRoleName).HasColumnName("LoweredRoleName");
    //       builder.Property(t => t.Description).HasColumnName("Description");

    //        // Relationships
    //        HasMany(t => t.aspnet_Users)
    //            .WithMany(t => t.aspnet_Roles)
    //            .Map(m =>
    //                {
    //                    m.ToTable("aspnet_UsersInRoles");
    //                    m.MapLeftKey("RoleId");
    //                    m.MapRightKey("UserId");
    //                });

    //        //HasRequired(t => t.aspnet_Applications)
    //        //    .WithMany(t => t.aspnet_Roles)
    //        //    .HasForeignKey(d => d.ApplicationId);

    //    }
    //}
}
