using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class RolePermissionMap : IEntityTypeConfiguration<RolePermission>
    {
        public RolePermissionMap()
        {
           } public void Configure(EntityTypeBuilder<RolePermission> builder) {
           builder.HasKey(t => new { t.RoleName, t.PermissionId });

            // Properties
           builder.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(128);

           builder.Property(t => t.PermissionId)
                .IsRequired()
                .HasMaxLength(322);

            // Table & Column Mappings
           builder.ToTable("RolePermissions");
           builder.Property(t => t.RoleName).HasColumnName("RoleName");
           builder.Property(t => t.PermissionId).HasColumnName("PermissionId");
        }
    }
}
