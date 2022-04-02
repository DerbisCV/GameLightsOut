using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vw_aspnet_WebPartState_PathsMap : EntityTypeConfiguration<vw_aspnet_WebPartState_Paths>
    {
        public vw_aspnet_WebPartState_PathsMap()
        {
            // Primary Key
            HasKey(t => new { t.ApplicationId, t.PathId, t.Path, t.LoweredPath });

            // Properties
            Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.LoweredPath)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            ToTable("vw_aspnet_WebPartState_Paths");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.PathId).HasColumnName("PathId");
            Property(t => t.Path).HasColumnName("Path");
            Property(t => t.LoweredPath).HasColumnName("LoweredPath");
        }
    }
}
