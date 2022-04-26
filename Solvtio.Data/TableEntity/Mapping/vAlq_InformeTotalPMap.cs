using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vAlq_InformeTotalPMap : IEntityTypeConfiguration<vAlq_InformeTotalP>
    //{
    //    public vAlq_InformeTotalPMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.IdExpediente, t.NoExpediente, t.Arrendador, t.TipoPropietario, t.NAU, t.FechaAlta, t.Estado, t.NIF });

    //        // Properties
    //       builder.Property(t => t.IdExpediente)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.NoExpediente)
    //            .IsRequired()
    //            .HasMaxLength(20);

    //       builder.Property(t => t.ReferenciaExternaMSGI)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.ReferenciaExternaMACRO)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.Arrendador)
    //            .IsRequired()
    //            .HasMaxLength(10);

    //       builder.Property(t => t.TipoPropietario)
    //            .IsRequired()
    //            .HasMaxLength(16);

    //       builder.Property(t => t.NAU)
    //            .IsRequired()
    //            .HasMaxLength(3);

    //       builder.Property(t => t.Estado)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //       builder.Property(t => t.NIF)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //       builder.Property(t => t.NombreDeudor)
    //            .HasMaxLength(801);

    //       builder.Property(t => t.Procurador)
    //            .HasMaxLength(801);

    //        // Table & Column Mappings
    //       builder.ToTable("vAlq_InformeTotalP");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.NoExpediente).HasColumnName("NoExpediente");
    //       builder.Property(t => t.ReferenciaExternaMSGI).HasColumnName("ReferenciaExternaMSGI");
    //       builder.Property(t => t.ReferenciaExternaMACRO).HasColumnName("ReferenciaExternaMACRO");
    //       builder.Property(t => t.Arrendador).HasColumnName("Arrendador");
    //       builder.Property(t => t.TipoPropietario).HasColumnName("TipoPropietario");
    //       builder.Property(t => t.NAU).HasColumnName("NAU");
    //       builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
    //       builder.Property(t => t.DeudaInicial).HasColumnName("DeudaInicial");
    //       builder.Property(t => t.DeudaPendiente).HasColumnName("DeudaPendiente");
    //       builder.Property(t => t.Estado).HasColumnName("Estado");
    //       builder.Property(t => t.FechaEstado).HasColumnName("FechaEstado");
    //       builder.Property(t => t.NIF).HasColumnName("NIF");
    //       builder.Property(t => t.NombreDeudor).HasColumnName("NombreDeudor");
    //       builder.Property(t => t.DomicilioNotificacion).HasColumnName("DomicilioNotificacion");
    //       builder.Property(t => t.IdProcurador).HasColumnName("IdProcurador");
    //       builder.Property(t => t.Procurador).HasColumnName("Procurador");
    //    }
    //}
}
