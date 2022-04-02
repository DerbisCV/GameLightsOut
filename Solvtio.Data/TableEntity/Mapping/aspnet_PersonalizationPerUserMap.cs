using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_PersonalizationPerUserMap : EntityTypeConfiguration<aspnet_PersonalizationPerUser>
    {
        public aspnet_PersonalizationPerUserMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.PageSettings)
                .IsRequired();

            // Table & Column Mappings
            ToTable("aspnet_PersonalizationPerUser");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.PathId).HasColumnName("PathId");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.PageSettings).HasColumnName("PageSettings");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");

            // Relationships
            HasOptional(t => t.aspnet_Paths)
                .WithMany(t => t.aspnet_PersonalizationPerUser)
                .HasForeignKey(d => d.PathId);
            HasOptional(t => t.aspnet_Users)
                .WithMany(t => t.aspnet_PersonalizationPerUser)
                .HasForeignKey(d => d.UserId);

        }
    }
}
