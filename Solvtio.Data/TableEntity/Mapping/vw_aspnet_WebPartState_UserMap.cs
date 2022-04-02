using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_WebPartState_UserMap : EntityTypeConfiguration<vw_aspnet_WebPartState_User>
    {
        public vw_aspnet_WebPartState_UserMap()
        {
            // Primary Key
            HasKey(t => t.LastUpdatedDate);

            // Properties
            // Table & Column Mappings
            ToTable("vw_aspnet_WebPartState_User");
            Property(t => t.PathId).HasColumnName("PathId");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.DataSize).HasColumnName("DataSize");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
        }
    }
}
