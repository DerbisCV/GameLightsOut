using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_ProfilesMap : EntityTypeConfiguration<vw_aspnet_Profiles>
    {
        public vw_aspnet_ProfilesMap()
        {
            // Primary Key
            HasKey(t => new { t.UserId, t.LastUpdatedDate });

            // Properties
            // Table & Column Mappings
            ToTable("vw_aspnet_Profiles");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.DataSize).HasColumnName("DataSize");
        }
    }
}
