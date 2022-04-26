using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vAlq_DEMANDAMap : IEntityTypeConfiguration<vAlq_DEMANDA>
    //{
    //    public vAlq_DEMANDAMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.IdExpediente, t.NumeroExpediente, t.AntecesorBanco, t.Abogados, t.NombreDeudor, t.DNIDeudor, t.DomicilioNotificacionDeudor, t.DireccionInmueble, t.NumeroFincaRegistral, t.Registro, t.TipoInmueble, t.AnejoInmueble, t.NombreArrendatario, t.FechaContrato, t.CantidadDeuda, t.IndiceRevision, t.CantidadRentaMensual, t.FechaBurofax, t.CuantiaPleito, t.FechaSolicitud, t.NumeroColegiadoProcurador });

    //        // Properties
    //       builder.Property(t => t.IdExpediente)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.NumeroExpediente)
    //            .IsRequired()
    //            .HasMaxLength(20);

    //       builder.Property(t => t.Juzgado)
    //            .HasMaxLength(100);

    //       builder.Property(t => t.NombreProcurador)
    //            .HasMaxLength(351);

    //       builder.Property(t => t.NombreCliente)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.AntecesorBanco)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.CIFCliente)
    //            .HasMaxLength(9);

    //       builder.Property(t => t.Abogados)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.NombreDeudor)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.DNIDeudor)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.DomicilioNotificacionDeudor)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.DireccionInmueble)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.NumeroFincaRegistral)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.Registro)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.TipoInmueble)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.AnejoInmueble)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.NombreArrendatario)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.FechaContrato)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.CantidadDeuda)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.IndiceRevision)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.CantidadRentaMensual)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.FechaBurofax)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.CuantiaPleito)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.FechaSolicitud)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //       builder.Property(t => t.NumeroColegiadoProcurador)
    //            .IsRequired()
    //            .HasMaxLength(1);

    //        // Table & Column Mappings
    //       builder.ToTable("vAlq_DEMANDA");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.NumeroExpediente).HasColumnName("NumeroExpediente");
    //       builder.Property(t => t.Juzgado).HasColumnName("Juzgado");
    //       builder.Property(t => t.NombreProcurador).HasColumnName("NombreProcurador");
    //       builder.Property(t => t.NombreCliente).HasColumnName("NombreCliente");
    //       builder.Property(t => t.AntecesorBanco).HasColumnName("AntecesorBanco");
    //       builder.Property(t => t.CIFCliente).HasColumnName("CIFCliente");
    //       builder.Property(t => t.DireccionCliente).HasColumnName("DireccionCliente");
    //       builder.Property(t => t.Abogados).HasColumnName("Abogados");
    //       builder.Property(t => t.NombreDeudor).HasColumnName("NombreDeudor");
    //       builder.Property(t => t.DNIDeudor).HasColumnName("DNIDeudor");
    //       builder.Property(t => t.DomicilioNotificacionDeudor).HasColumnName("DomicilioNotificacionDeudor");
    //       builder.Property(t => t.DireccionInmueble).HasColumnName("DireccionInmueble");
    //       builder.Property(t => t.NumeroFincaRegistral).HasColumnName("NumeroFincaRegistral");
    //       builder.Property(t => t.Registro).HasColumnName("Registro");
    //       builder.Property(t => t.TipoInmueble).HasColumnName("TipoInmueble");
    //       builder.Property(t => t.AnejoInmueble).HasColumnName("AnejoInmueble");
    //       builder.Property(t => t.NombreArrendatario).HasColumnName("NombreArrendatario");
    //       builder.Property(t => t.FechaContrato).HasColumnName("FechaContrato");
    //       builder.Property(t => t.CantidadDeuda).HasColumnName("CantidadDeuda");
    //       builder.Property(t => t.IndiceRevision).HasColumnName("IndiceRevision");
    //       builder.Property(t => t.CantidadRentaMensual).HasColumnName("CantidadRentaMensual");
    //       builder.Property(t => t.FechaBurofax).HasColumnName("FechaBurofax");
    //       builder.Property(t => t.CuantiaPleito).HasColumnName("CuantiaPleito");
    //       builder.Property(t => t.FechaSolicitud).HasColumnName("FechaSolicitud");
    //       builder.Property(t => t.NumeroColegiadoProcurador).HasColumnName("NumeroColegiadoProcurador");
    //    }
    //}
}
