using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_ClienteMap : EntityTypeConfiguration<Gnr_Cliente>
    {
        public Gnr_ClienteMap()
        {
            // Primary Key
            HasKey(t => t.IdCliente);

            // Properties
            Property(t => t.CodigoCliente)
                .HasMaxLength(50);

            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.NoDocumento)
                .IsRequired()
                .HasMaxLength(9);

            Property(t => t.Email)
                .HasMaxLength(500);

            Property(t => t.Telefono)
                .HasMaxLength(30);

            Property(t => t.FacturacionNombre)
                .HasMaxLength(250);

            Property(t => t.FacturacionNoDocumento)
                .HasMaxLength(9);

            Property(t => t.FacturacionEmail)
                .HasMaxLength(500);

            Property(t => t.FacturacionTelefono)
                .HasMaxLength(30);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_Cliente");
            Property(t => t.IdCliente).HasColumnName("IdCliente");
            Property(t => t.CodigoCliente).HasColumnName("CodigoCliente");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.IdTipoIdentidad).HasColumnName("IdTipoIdentidad");
            Property(t => t.NoDocumento).HasColumnName("NoDocumento");
            Property(t => t.Direccion).HasColumnName("Direccion");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Telefono).HasColumnName("Telefono");
            Property(t => t.PersonaContacto).HasColumnName("PersonaContacto");
            Property(t => t.IdAbogadoPadrino).HasColumnName("IdAbogadoPadrino");
            Property(t => t.FechaCaptacion).HasColumnName("FechaCaptacion");
            Property(t => t.FacturacionNombre).HasColumnName("FacturacionNombre");
            Property(t => t.FacturacionNoDocumento).HasColumnName("FacturacionNoDocumento");
            Property(t => t.FacturacionDireccion).HasColumnName("FacturacionDireccion");
            Property(t => t.FacturacionEmail).HasColumnName("FacturacionEmail");
            Property(t => t.FacturacionTelefono).HasColumnName("FacturacionTelefono");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.RequerimientoProcurador).HasColumnName("RequerimientoProcurador");
            Property(t => t.IdSupervisorNoEjecutivo).HasColumnName("IdSupervisorNoEjecutivo");

            // Relationships
            HasOptional(t => t.AlertaSupervisor)
                .WithMany(t => t.Gnr_Cliente)
                .HasForeignKey(d => d.IdSupervisorNoEjecutivo);
            HasOptional(t => t.Gnr_Abogado)
                .WithMany(t => t.Gnr_Cliente)
                .HasForeignKey(d => d.IdAbogadoPadrino);
            HasRequired(t => t.Gnr_TipoIdentidad)
                .WithMany(t => t.Gnr_Cliente)
                .HasForeignKey(d => d.IdTipoIdentidad);

        }
    }
}
