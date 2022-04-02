using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_UsersInRolesMap : EntityTypeConfiguration<vw_aspnet_UsersInRoles>
    {
        public vw_aspnet_UsersInRolesMap()
        {
            // Primary Key
            HasKey(t => new { t.UserId, t.RoleId });

            // Properties
            // Table & Column Mappings
            ToTable("vw_aspnet_UsersInRoles");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.RoleId).HasColumnName("RoleId");
        }
    }
}
