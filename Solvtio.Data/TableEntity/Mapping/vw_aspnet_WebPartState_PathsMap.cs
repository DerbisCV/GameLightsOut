using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vw_aspnet_WebPartState_PathsMap : IEntityTypeConfiguration<vw_aspnet_WebPartState_Paths>
    //{
    //    public vw_aspnet_WebPartState_PathsMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => new { t.ApplicationId, t.PathId, t.Path, t.LoweredPath });

    //        // Properties
    //       builder.Property(t => t.Path)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.LoweredPath)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //        // Table & Column Mappings
    //       builder.ToTable("vw_aspnet_WebPartState_Paths");
    //       builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
    //       builder.Property(t => t.PathId).HasColumnName("PathId");
    //       builder.Property(t => t.Path).HasColumnName("Path");
    //       builder.Property(t => t.LoweredPath).HasColumnName("LoweredPath");
    //    }
    //}
}
