using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteFacturaMap : IEntityTypeConfiguration<ExpedienteFactura>
    {
      
            public void Configure(EntityTypeBuilder<ExpedienteFactura> builder) {
           builder.HasKey(t => t.IdExpedienteFactura);

            // Properties
            //this.Property(t => t.NoFactura)
            //    .HasMaxLength(20);

           builder.Property(t => t.UsuarioAlta)
                .HasMaxLength(50);

           builder.Property(t => t.UsuarioActualizacion)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("ExpedienteFactura");
           builder.Property(t => t.IdExpedienteFactura).HasColumnName("IdExpedienteFactura");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.HitoFacturacion).HasColumnName("HitoFacturacion");
            //this.Property(t => t.NoFactura).HasColumnName("NoFactura");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.FechaActualizacion).HasColumnName("FechaActualizacion");
           builder.Property(t => t.UsuarioAlta).HasColumnName("UsuarioAlta");
           builder.Property(t => t.UsuarioActualizacion).HasColumnName("UsuarioActualizacion");
           builder.Property(t => t.IdFactura).HasColumnName("IdFactura");
           builder.Property(t => t.Importe).HasColumnName("Importe");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.FacturaSet)
                //  .HasForeignKey(d => d.IdExpediente);
            // HasOptional(t => t.Factura)
                //  .WithMany(t => t.ExpedienteFacturaSet)
                //  .HasForeignKey(d => d.IdFactura);

        }
    }
}
