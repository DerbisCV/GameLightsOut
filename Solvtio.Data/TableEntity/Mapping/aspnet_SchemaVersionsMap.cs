using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class aspnet_SchemaVersionsMap : IEntityTypeConfiguration<aspnet_SchemaVersions>
    //{
    //    public aspnet_SchemaVersionsMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => new { t.Feature, t.CompatibleSchemaVersion });

    //        // Properties
    //       builder.Property(t => t.Feature)
    //            .IsRequired()
    //            .HasMaxLength(128);

    //       builder.Property(t => t.CompatibleSchemaVersion)
    //            .IsRequired()
    //            .HasMaxLength(128);

    //        // Table & Column Mappings
    //       builder.ToTable("aspnet_SchemaVersions");
    //       builder.Property(t => t.Feature).HasColumnName("Feature");
    //       builder.Property(t => t.CompatibleSchemaVersion).HasColumnName("CompatibleSchemaVersion");
    //       builder.Property(t => t.IsCurrentVersion).HasColumnName("IsCurrentVersion");
    //    }
    //}
}
