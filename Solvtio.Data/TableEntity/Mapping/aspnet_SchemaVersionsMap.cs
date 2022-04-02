using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class aspnet_SchemaVersionsMap : EntityTypeConfiguration<aspnet_SchemaVersions>
    {
        public aspnet_SchemaVersionsMap()
        {
            // Primary Key
            HasKey(t => new { t.Feature, t.CompatibleSchemaVersion });

            // Properties
            Property(t => t.Feature)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.CompatibleSchemaVersion)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            ToTable("aspnet_SchemaVersions");
            Property(t => t.Feature).HasColumnName("Feature");
            Property(t => t.CompatibleSchemaVersion).HasColumnName("CompatibleSchemaVersion");
            Property(t => t.IsCurrentVersion).HasColumnName("IsCurrentVersion");
        }
    }
}
