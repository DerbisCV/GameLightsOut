using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_ProfileMap : EntityTypeConfiguration<aspnet_Profile>
    {
        public aspnet_ProfileMap()
        {
            // Primary Key
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.PropertyNames)
                .IsRequired();

            Property(t => t.PropertyValuesString)
                .IsRequired();

            Property(t => t.PropertyValuesBinary)
                .IsRequired();

            // Table & Column Mappings
            ToTable("aspnet_Profile");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.PropertyNames).HasColumnName("PropertyNames");
            Property(t => t.PropertyValuesString).HasColumnName("PropertyValuesString");
            Property(t => t.PropertyValuesBinary).HasColumnName("PropertyValuesBinary");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");

            // Relationships
            HasRequired(t => t.aspnet_Users)
                .WithOptional(t => t.aspnet_Profile);

        }
    }
}
