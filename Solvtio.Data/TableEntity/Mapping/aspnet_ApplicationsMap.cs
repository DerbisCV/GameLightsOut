using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_ApplicationsMap : EntityTypeConfiguration<aspnet_Applications>
    {
        public aspnet_ApplicationsMap()
        {
            // Primary Key
            HasKey(t => t.ApplicationId);

            // Properties
            Property(t => t.ApplicationName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.LoweredApplicationName)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.Description)
                .HasMaxLength(256);

            // Table & Column Mappings
            ToTable("aspnet_Applications");
            Property(t => t.ApplicationName).HasColumnName("ApplicationName");
            Property(t => t.LoweredApplicationName).HasColumnName("LoweredApplicationName");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.Description).HasColumnName("Description");
        }
    }
}
