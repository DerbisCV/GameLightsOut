using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class FacturaMap : EntityTypeConfiguration<Factura>
    {
        public FacturaMap()
        {
            // Primary Key
            HasKey(t => t.IdFactura);

            // Properties
            Property(t => t.NoFactura)
                .HasMaxLength(20);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Factura");
            Property(t => t.IdFactura).HasColumnName("IdFactura");
            Property(t => t.IdCliente).HasColumnName("IdCliente");
            Property(t => t.HitoFacturacion).HasColumnName("HitoFacturacion");
            Property(t => t.NoFactura).HasColumnName("NoFactura");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.BaseImponible).HasColumnName("BaseImponible");
            Property(t => t.Iva).HasColumnName("Iva");
            Property(t => t.ImporteTotal).HasColumnName("ImporteTotal");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.Aprobada).HasColumnName("Aprobada");

            // Relationships
            HasRequired(t => t.Gnr_Cliente)
                .WithMany(t => t.Facturas)
                .HasForeignKey(d => d.IdCliente);

        }
    }
}
