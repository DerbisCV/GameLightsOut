using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteFacturaMap : EntityTypeConfiguration<ExpedienteFactura>
    {
        public ExpedienteFacturaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteFactura);

            // Properties
            //this.Property(t => t.NoFactura)
            //    .HasMaxLength(20);

            Property(t => t.UsuarioAlta)
                .HasMaxLength(50);

            Property(t => t.UsuarioActualizacion)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ExpedienteFactura");
            Property(t => t.IdExpedienteFactura).HasColumnName("IdExpedienteFactura");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.HitoFacturacion).HasColumnName("HitoFacturacion");
            //this.Property(t => t.NoFactura).HasColumnName("NoFactura");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.FechaActualizacion).HasColumnName("FechaActualizacion");
            Property(t => t.UsuarioAlta).HasColumnName("UsuarioAlta");
            Property(t => t.UsuarioActualizacion).HasColumnName("UsuarioActualizacion");
            Property(t => t.IdFactura).HasColumnName("IdFactura");
            Property(t => t.Importe).HasColumnName("Importe");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.FacturaSet)
                .HasForeignKey(d => d.IdExpediente);
            HasOptional(t => t.Factura)
                .WithMany(t => t.ExpedienteFacturaSet)
                .HasForeignKey(d => d.IdFactura);

        }
    }
}
