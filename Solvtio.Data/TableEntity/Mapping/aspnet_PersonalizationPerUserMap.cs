using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class aspnet_PersonalizationPerUserMap : IEntityTypeConfiguration<aspnet_PersonalizationPerUser>
    //{
    //    public aspnet_PersonalizationPerUserMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => t.Id);

    //        // Properties
    //       builder.Property(t => t.PageSettings)
    //            .IsRequired();

    //        // Table & Column Mappings
    //       builder.ToTable("aspnet_PersonalizationPerUser");
    //       builder.Property(t => t.Id).HasColumnName("Id");
    //       builder.Property(t => t.PathId).HasColumnName("PathId");
    //       builder.Property(t => t.UserId).HasColumnName("UserId");
    //       builder.Property(t => t.PageSettings).HasColumnName("PageSettings");
    //       builder.Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");

    //        // Relationships
    //        //HasOptional(t => t.aspnet_Paths)
    //        //    .WithMany(t => t.aspnet_PersonalizationPerUser)
    //        //    .HasForeignKey(d => d.PathId);
    //        //HasOptional(t => t.aspnet_Users)
    //        //    .WithMany(t => t.aspnet_PersonalizationPerUser)
    //        //    .HasForeignKey(d => d.UserId);

    //    }
    //}
}
