using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class aspnet_PathsMap : IEntityTypeConfiguration<aspnet_Paths>
    //{
    //    public aspnet_PathsMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => t.PathId);

    //        // Properties
    //       builder.Property(t => t.Path)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.LoweredPath)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //        // Table & Column Mappings
    //       builder.ToTable("aspnet_Paths");
    //       builder.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
    //       builder.Property(t => t.PathId).HasColumnName("PathId");
    //       builder.Property(t => t.Path).HasColumnName("Path");
    //       builder.Property(t => t.LoweredPath).HasColumnName("LoweredPath");

    //        // Relationships
    //        //HasRequired(t => t.aspnet_Applications)
    //        //    .WithMany(t => t.aspnet_Paths)
    //        //    .HasForeignKey(d => d.ApplicationId);

    //    }
    //}
}
