using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vAlq_DEMANDAMap : EntityTypeConfiguration<vAlq_DEMANDA>
    {
        public vAlq_DEMANDAMap()
        {
            // Primary Key
            HasKey(t => new { t.IdExpediente, t.NumeroExpediente, t.AntecesorBanco, t.Abogados, t.NombreDeudor, t.DNIDeudor, t.DomicilioNotificacionDeudor, t.DireccionInmueble, t.NumeroFincaRegistral, t.Registro, t.TipoInmueble, t.AnejoInmueble, t.NombreArrendatario, t.FechaContrato, t.CantidadDeuda, t.IndiceRevision, t.CantidadRentaMensual, t.FechaBurofax, t.CuantiaPleito, t.FechaSolicitud, t.NumeroColegiadoProcurador });

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.NumeroExpediente)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Juzgado)
                .HasMaxLength(100);

            Property(t => t.NombreProcurador)
                .HasMaxLength(351);

            Property(t => t.NombreCliente)
                .HasMaxLength(50);

            Property(t => t.AntecesorBanco)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.CIFCliente)
                .HasMaxLength(9);

            Property(t => t.Abogados)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.NombreDeudor)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.DNIDeudor)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.DomicilioNotificacionDeudor)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.DireccionInmueble)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.NumeroFincaRegistral)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.Registro)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.TipoInmueble)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.AnejoInmueble)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.NombreArrendatario)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.FechaContrato)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.CantidadDeuda)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.IndiceRevision)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.CantidadRentaMensual)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.FechaBurofax)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.CuantiaPleito)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.FechaSolicitud)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.NumeroColegiadoProcurador)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            ToTable("vAlq_DEMANDA");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.NumeroExpediente).HasColumnName("NumeroExpediente");
            Property(t => t.Juzgado).HasColumnName("Juzgado");
            Property(t => t.NombreProcurador).HasColumnName("NombreProcurador");
            Property(t => t.NombreCliente).HasColumnName("NombreCliente");
            Property(t => t.AntecesorBanco).HasColumnName("AntecesorBanco");
            Property(t => t.CIFCliente).HasColumnName("CIFCliente");
            Property(t => t.DireccionCliente).HasColumnName("DireccionCliente");
            Property(t => t.Abogados).HasColumnName("Abogados");
            Property(t => t.NombreDeudor).HasColumnName("NombreDeudor");
            Property(t => t.DNIDeudor).HasColumnName("DNIDeudor");
            Property(t => t.DomicilioNotificacionDeudor).HasColumnName("DomicilioNotificacionDeudor");
            Property(t => t.DireccionInmueble).HasColumnName("DireccionInmueble");
            Property(t => t.NumeroFincaRegistral).HasColumnName("NumeroFincaRegistral");
            Property(t => t.Registro).HasColumnName("Registro");
            Property(t => t.TipoInmueble).HasColumnName("TipoInmueble");
            Property(t => t.AnejoInmueble).HasColumnName("AnejoInmueble");
            Property(t => t.NombreArrendatario).HasColumnName("NombreArrendatario");
            Property(t => t.FechaContrato).HasColumnName("FechaContrato");
            Property(t => t.CantidadDeuda).HasColumnName("CantidadDeuda");
            Property(t => t.IndiceRevision).HasColumnName("IndiceRevision");
            Property(t => t.CantidadRentaMensual).HasColumnName("CantidadRentaMensual");
            Property(t => t.FechaBurofax).HasColumnName("FechaBurofax");
            Property(t => t.CuantiaPleito).HasColumnName("CuantiaPleito");
            Property(t => t.FechaSolicitud).HasColumnName("FechaSolicitud");
            Property(t => t.NumeroColegiadoProcurador).HasColumnName("NumeroColegiadoProcurador");
        }
    }
}
