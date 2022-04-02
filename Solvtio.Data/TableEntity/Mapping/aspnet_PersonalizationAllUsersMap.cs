using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_PersonalizationAllUsersMap : EntityTypeConfiguration<aspnet_PersonalizationAllUsers>
    {
        public aspnet_PersonalizationAllUsersMap()
        {
            // Primary Key
            HasKey(t => t.PathId);

            // Properties
            Property(t => t.PageSettings)
                .IsRequired();

            // Table & Column Mappings
            ToTable("aspnet_PersonalizationAllUsers");
            Property(t => t.PathId).HasColumnName("PathId");
            Property(t => t.PageSettings).HasColumnName("PageSettings");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");

            // Relationships
            HasRequired(t => t.aspnet_Paths)
                .WithOptional(t => t.aspnet_PersonalizationAllUsers);

        }
    }
}
