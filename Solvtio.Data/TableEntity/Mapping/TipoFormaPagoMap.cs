using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class TipoFormaPagoMap : EntityTypeConfiguration<TipoFormaPago>
    {
        public TipoFormaPagoMap()
        {
            // Primary Key
            HasKey(t => t.IdFormaPago);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TipoFormaPago");
            Property(t => t.IdFormaPago).HasColumnName("IdFormaPago");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
        }
    }
}
