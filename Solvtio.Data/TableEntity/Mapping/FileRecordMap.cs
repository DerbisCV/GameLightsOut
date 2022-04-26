using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class FileRecordMap : IEntityTypeConfiguration<FileRecord>
    {
    
            public void Configure(EntityTypeBuilder<FileRecord> builder) {
           builder.HasKey(t => t.FileName);

            // Properties
           builder.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("FileRecord");
           builder.Property(t => t.FileName).HasColumnName("FileName");
        }
    }
}
