using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class FacturaMap : IEntityTypeConfiguration<Factura>
    {

            public void Configure(EntityTypeBuilder<Factura> builder) {
           builder.HasKey(t => t.IdFactura);

            // Properties
           builder.Property(t => t.NoFactura)
                .HasMaxLength(20);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Factura");
           builder.Property(t => t.IdFactura).HasColumnName("IdFactura");
           builder.Property(t => t.IdCliente).HasColumnName("IdCliente");
           builder.Property(t => t.HitoFacturacion).HasColumnName("HitoFacturacion");
           builder.Property(t => t.NoFactura).HasColumnName("NoFactura");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.BaseImponible).HasColumnName("BaseImponible");
           builder.Property(t => t.Iva).HasColumnName("Iva");
           builder.Property(t => t.ImporteTotal).HasColumnName("ImporteTotal");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.Aprobada).HasColumnName("Aprobada");

            // Relationships
            //HasRequired(t => t.Gnr_Cliente)
                //  .WithMany(t => t.Facturas)
                //  .HasForeignKey(d => d.IdCliente);

        }
    }
}
