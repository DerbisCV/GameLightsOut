using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class TipoFormaPagoMap : IEntityTypeConfiguration<TipoFormaPago>
    {
        public TipoFormaPagoMap()
        {
           } public void Configure(EntityTypeBuilder<TipoFormaPago> builder) {
           builder.HasKey(t => t.IdFormaPago);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("TipoFormaPago");
           builder.Property(t => t.IdFormaPago).HasColumnName("IdFormaPago");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
        }
    }
}
