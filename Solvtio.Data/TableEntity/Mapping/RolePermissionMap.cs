using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class RolePermissionMap : EntityTypeConfiguration<RolePermission>
    {
        public RolePermissionMap()
        {
            // Primary Key
            HasKey(t => new { t.RoleName, t.PermissionId });

            // Properties
            Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.PermissionId)
                .IsRequired()
                .HasMaxLength(322);

            // Table & Column Mappings
            ToTable("RolePermissions");
            Property(t => t.RoleName).HasColumnName("RoleName");
            Property(t => t.PermissionId).HasColumnName("PermissionId");
        }
    }
}
