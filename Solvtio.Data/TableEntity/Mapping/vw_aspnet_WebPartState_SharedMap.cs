using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_WebPartState_SharedMap : EntityTypeConfiguration<vw_aspnet_WebPartState_Shared>
    {
        public vw_aspnet_WebPartState_SharedMap()
        {
            // Primary Key
            HasKey(t => new { t.PathId, t.LastUpdatedDate });

            // Properties
            // Table & Column Mappings
            ToTable("vw_aspnet_WebPartState_Shared");
            Property(t => t.PathId).HasColumnName("PathId");
            Property(t => t.DataSize).HasColumnName("DataSize");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
        }
    }
}
