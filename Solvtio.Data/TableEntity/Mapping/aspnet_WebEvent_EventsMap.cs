using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class aspnet_WebEvent_EventsMap : IEntityTypeConfiguration<aspnet_WebEvent_Events>
    //{
    //    public aspnet_WebEvent_EventsMap()
    //    {
    //        // public void Configure(EntityTypeBuilder<object> builder)
    //       builder.HasKey(t => t.EventId);

    //        // Properties
    //       builder.Property(t => t.EventId)
    //            .IsRequired()
    //            .IsFixedLength()
    //            .HasMaxLength(32);

    //       builder.Property(t => t.EventType)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.Message)
    //            .HasMaxLength(1024);

    //       builder.Property(t => t.ApplicationPath)
    //            .HasMaxLength(256);

    //       builder.Property(t => t.ApplicationVirtualPath)
    //            .HasMaxLength(256);

    //       builder.Property(t => t.MachineName)
    //            .IsRequired()
    //            .HasMaxLength(256);

    //       builder.Property(t => t.RequestUrl)
    //            .HasMaxLength(1024);

    //       builder.Property(t => t.ExceptionType)
    //            .HasMaxLength(256);

    //        // Table & Column Mappings
    //       builder.ToTable("aspnet_WebEvent_Events");
    //       builder.Property(t => t.EventId).HasColumnName("EventId");
    //       builder.Property(t => t.EventTimeUtc).HasColumnName("EventTimeUtc");
    //       builder.Property(t => t.EventTime).HasColumnName("EventTime");
    //       builder.Property(t => t.EventType).HasColumnName("EventType");
    //       builder.Property(t => t.EventSequence).HasColumnName("EventSequence");
    //       builder.Property(t => t.EventOccurrence).HasColumnName("EventOccurrence");
    //       builder.Property(t => t.EventCode).HasColumnName("EventCode");
    //       builder.Property(t => t.EventDetailCode).HasColumnName("EventDetailCode");
    //       builder.Property(t => t.Message).HasColumnName("Message");
    //       builder.Property(t => t.ApplicationPath).HasColumnName("ApplicationPath");
    //       builder.Property(t => t.ApplicationVirtualPath).HasColumnName("ApplicationVirtualPath");
    //       builder.Property(t => t.MachineName).HasColumnName("MachineName");
    //       builder.Property(t => t.RequestUrl).HasColumnName("RequestUrl");
    //       builder.Property(t => t.ExceptionType).HasColumnName("ExceptionType");
    //       builder.Property(t => t.Details).HasColumnName("Details");
    //    }
    //}
}
