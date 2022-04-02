using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_RolesMap : EntityTypeConfiguration<aspnet_Roles>
    {
        public aspnet_RolesMap()
        {
            // Primary Key
            HasKey(t => t.RoleId);

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
            ToTable("aspnet_Roles");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.RoleId).HasColumnName("RoleId");
            Property(t => t.RoleName).HasColumnName("RoleName");
            Property(t => t.LoweredRoleName).HasColumnName("LoweredRoleName");
            Property(t => t.Description).HasColumnName("Description");

            // Relationships
            HasMany(t => t.aspnet_Users)
                .WithMany(t => t.aspnet_Roles)
                .Map(m =>
                    {
                        m.ToTable("aspnet_UsersInRoles");
                        m.MapLeftKey("RoleId");
                        m.MapRightKey("UserId");
                    });

            HasRequired(t => t.aspnet_Applications)
                .WithMany(t => t.aspnet_Roles)
                .HasForeignKey(d => d.ApplicationId);

        }
    }
}
