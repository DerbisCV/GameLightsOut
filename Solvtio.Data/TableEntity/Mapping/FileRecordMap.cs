using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class FileRecordMap : EntityTypeConfiguration<FileRecord>
    {
        public FileRecordMap()
        {
            // Primary Key
            HasKey(t => t.FileName);

            // Properties
            Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("FileRecord");
            Property(t => t.FileName).HasColumnName("FileName");
        }
    }
}
