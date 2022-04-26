using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_ClienteOficinaMap : IEntityTypeConfiguration<Gnr_ClienteOficina>
    {
   
            public void Configure(EntityTypeBuilder<Gnr_ClienteOficina> builder) {
           builder.HasKey(t => t.IdClienteOficina);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

           builder.Property(t => t.NombreCorto)
                .HasMaxLength(10);

           builder.Property(t => t.NoCuenta)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_ClienteOficina");
           builder.Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.IdCliente).HasColumnName("IdCliente");
           builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
           builder.Property(t => t.NombreCorto).HasColumnName("NombreCorto");
           builder.Property(t => t.NoCuenta).HasColumnName("NoCuenta");

            // Relationships
            //HasRequired(t => t.Gnr_Cliente)
                //  .WithMany(t => t.Gnr_ClienteOficina)
                //  .HasForeignKey(d => d.IdCliente);
            // HasOptional(t => t.Gnr_TipoExpediente)
                //  .WithMany(t => t.Gnr_ClienteOficina)
                //  .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
