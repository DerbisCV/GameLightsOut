using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_ClienteOficinaMap : EntityTypeConfiguration<Gnr_ClienteOficina>
    {
        public Gnr_ClienteOficinaMap()
        {
            // Primary Key
            HasKey(t => t.IdClienteOficina);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.NombreCorto)
                .HasMaxLength(10);

            Property(t => t.NoCuenta)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_ClienteOficina");
            Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.IdCliente).HasColumnName("IdCliente");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            Property(t => t.NombreCorto).HasColumnName("NombreCorto");
            Property(t => t.NoCuenta).HasColumnName("NoCuenta");

            // Relationships
            HasRequired(t => t.Gnr_Cliente)
                .WithMany(t => t.Gnr_ClienteOficina)
                .HasForeignKey(d => d.IdCliente);
            HasOptional(t => t.Gnr_TipoExpediente)
                .WithMany(t => t.Gnr_ClienteOficina)
                .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
