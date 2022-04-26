using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class AccionFlujoMap : IEntityTypeConfiguration<AccionFlujo>
    {
        public void Configure(EntityTypeBuilder<AccionFlujo> builder)
        {
            builder
                .ToTable("AccionFlujo")
                .HasKey(t => t.IdAccionFlujo);


            //builder.HasKey(o => o.OrderNumber);
            //builder.Property(t => t.TipoAccion).HasOne();
            
            //        .HasColumnType("Date")
            //        .HasDefaultValueSql("GetDate())"

        }
    }
}
