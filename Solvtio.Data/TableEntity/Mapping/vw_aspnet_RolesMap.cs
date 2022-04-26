using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vw_aspnet_RolesMap : IEntityTypeConfiguration<vw_aspnet_Roles>
    //{
    //    public vw_aspnet_RolesMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => new { t.ApplicationId, t.RoleId, t.RoleName, t.LoweredRoleName });

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
    //       builder.ToTable("vw_aspnet_Roles");
    //       builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
    //       builder.Property(t => t.RoleId).HasColumnName("RoleId");
    //       builder.Property(t => t.RoleName).HasColumnName("RoleName");
    //       builder.Property(t => t.LoweredRoleName).HasColumnName("LoweredRoleName");
    //       builder.Property(t => t.Description).HasColumnName("Description");
    //    }
    //}
}
