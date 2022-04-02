using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_RolesMap : EntityTypeConfiguration<vw_aspnet_Roles>
    {
        public vw_aspnet_RolesMap()
        {
            // Primary Key
            HasKey(t => new { t.ApplicationId, t.RoleId, t.RoleName, t.LoweredRoleName });

            // Properties
            Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.LoweredRoleName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.Description)
                .HasMaxLength(256);

            // Table & Column Mappings
            ToTable("vw_aspnet_Roles");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.RoleId).HasColumnName("RoleId");
            Property(t => t.RoleName).HasColumnName("RoleName");
            Property(t => t.LoweredRoleName).HasColumnName("LoweredRoleName");
            Property(t => t.Description).HasColumnName("Description");
        }
    }
}
