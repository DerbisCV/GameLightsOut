using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_ClienteMap : IEntityTypeConfiguration<Gnr_Cliente>
    {
    
            public void Configure(EntityTypeBuilder<Gnr_Cliente> builder) {
           builder.HasKey(t => t.IdCliente);

            // Properties
           builder.Property(t => t.CodigoCliente)
                .HasMaxLength(50);

           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

           builder.Property(t => t.NoDocumento)
                .IsRequired()
                .HasMaxLength(9);

           builder.Property(t => t.Email)
                .HasMaxLength(500);

           builder.Property(t => t.Telefono)
                .HasMaxLength(30);

           builder.Property(t => t.FacturacionNombre)
                .HasMaxLength(250);

           builder.Property(t => t.FacturacionNoDocumento)
                .HasMaxLength(9);

           builder.Property(t => t.FacturacionEmail)
                .HasMaxLength(500);

           builder.Property(t => t.FacturacionTelefono)
                .HasMaxLength(30);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_Cliente");
           builder.Property(t => t.IdCliente).HasColumnName("IdCliente");
           builder.Property(t => t.CodigoCliente).HasColumnName("CodigoCliente");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.IdTipoIdentidad).HasColumnName("IdTipoIdentidad");
           builder.Property(t => t.NoDocumento).HasColumnName("NoDocumento");
           builder.Property(t => t.Direccion).HasColumnName("Direccion");
           builder.Property(t => t.Email).HasColumnName("Email");
           builder.Property(t => t.Telefono).HasColumnName("Telefono");
           builder.Property(t => t.PersonaContacto).HasColumnName("PersonaContacto");
           builder.Property(t => t.IdAbogadoPadrino).HasColumnName("IdAbogadoPadrino");
           builder.Property(t => t.FechaCaptacion).HasColumnName("FechaCaptacion");
           builder.Property(t => t.FacturacionNombre).HasColumnName("FacturacionNombre");
           builder.Property(t => t.FacturacionNoDocumento).HasColumnName("FacturacionNoDocumento");
           builder.Property(t => t.FacturacionDireccion).HasColumnName("FacturacionDireccion");
           builder.Property(t => t.FacturacionEmail).HasColumnName("FacturacionEmail");
           builder.Property(t => t.FacturacionTelefono).HasColumnName("FacturacionTelefono");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.RequerimientoProcurador).HasColumnName("RequerimientoProcurador");
           builder.Property(t => t.IdSupervisorNoEjecutivo).HasColumnName("IdSupervisorNoEjecutivo");

            // Relationships
            // HasOptional(t => t.AlertaSupervisor)
                //  .WithMany(t => t.Gnr_Cliente)
                //  .HasForeignKey(d => d.IdSupervisorNoEjecutivo);
            // HasOptional(t => t.Gnr_Abogado)
                //  .WithMany(t => t.Gnr_Cliente)
                //  .HasForeignKey(d => d.IdAbogadoPadrino);
            //HasRequired(t => t.Gnr_TipoIdentidad)
                //  .WithMany(t => t.Gnr_Cliente)
                //  .HasForeignKey(d => d.IdTipoIdentidad);

        }
    }
}
