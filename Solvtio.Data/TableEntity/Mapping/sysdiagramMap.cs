using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class sysdiagramMap : IEntityTypeConfiguration<sysdiagram>
    //{
    //    public sysdiagramMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => t.diagram_id);

    //        // Properties
    //       builder.Property(t => t.name)
    //            .IsRequired()
    //            .HasMaxLength(128);

    //        // Table & Column Mappings
    //       builder.ToTable("sysdiagrams");
    //       builder.Property(t => t.name).HasColumnName("name");
    //       builder.Property(t => t.principal_id).HasColumnName("principal_id");
    //       builder.Property(t => t.diagram_id).HasColumnName("diagram_id");
    //       builder.Property(t => t.version).HasColumnName("version");
    //       builder.Property(t => t.definition).HasColumnName("definition");
    //    }
    //}
}
