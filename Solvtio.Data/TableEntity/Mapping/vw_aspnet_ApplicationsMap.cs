using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
//    public class vw_aspnet_ApplicationsMap : IEntityTypeConfiguration<vw_aspnet_Applications>
//    {
//        public vw_aspnet_ApplicationsMap()
//        {
//            public void Configure(EntityTypeBuilder<object> builder) {
//           builder.HasKey(t => new { t.ApplicationName, t.LoweredApplicationName, t.ApplicationId });

//            // Properties
//           builder.Property(t => t.ApplicationName)
//                .IsRequired()
//                .HasMaxLength(256);

//           builder.Property(t => t.LoweredApplicationName)
//                .IsRequired()
//                .HasMaxLength(256);

//           builder.Property(t => t.Description)
//                .HasMaxLength(256);

//            // Table & Column Mappings
//           builder.ToTable("vw_aspnet_Applications");
//           builder.Property(t => t.ApplicationName).HasColumnName("ApplicationName");
//           builder.Property(t => t.LoweredApplicationName).HasColumnName("LoweredApplicationName");
//           builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
//           builder.Property(t => t.Description).HasColumnName("Description");
//        }
//    }
}
