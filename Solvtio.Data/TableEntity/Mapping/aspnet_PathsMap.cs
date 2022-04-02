using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_PathsMap : EntityTypeConfiguration<aspnet_Paths>
    {
        public aspnet_PathsMap()
        {
            // Primary Key
            HasKey(t => t.PathId);

            // Properties
            Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.LoweredPath)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            ToTable("aspnet_Paths");
            Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            Property(t => t.PathId).HasColumnName("PathId");
            Property(t => t.Path).HasColumnName("Path");
            Property(t => t.LoweredPath).HasColumnName("LoweredPath");

            // Relationships
            HasRequired(t => t.aspnet_Applications)
                .WithMany(t => t.aspnet_Paths)
                .HasForeignKey(d => d.ApplicationId);

        }
    }
}
