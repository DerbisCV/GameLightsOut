using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vGnr_PlantillaDoc_ALQUILER_BUROFAXMap : IEntityTypeConfiguration<vGnr_PlantillaDoc_ALQUILER_BUROFAX>
    //{
    //    public vGnr_PlantillaDoc_ALQUILER_BUROFAXMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.IdExpediente, t.NoExpediente, t.DocumentoDeudor, t.TipoInmueble });

    //        // Properties
    //       builder.Property(t => t.FechaActual)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.IdExpediente)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.NoExpediente)
    //            .IsRequired()
    //            .HasMaxLength(20);

    //       builder.Property(t => t.ReferenciaExterna)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.ReferenciaExternaMACRO)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.ReferenciaExternaMSGI)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.NombreDeudor)
    //            .HasMaxLength(801);

    //       builder.Property(t => t.DocumentoDeudor)
    //            .IsRequired()
    //            .HasMaxLength(301);

    //       builder.Property(t => t.TipoInmueble)
    //            .IsRequired()
    //            .HasMaxLength(500);

    //       builder.Property(t => t.DireccionInmueble)
    //            .HasMaxLength(362);

    //        // Table & Column Mappings
    //       builder.ToTable("vGnr_PlantillaDoc_ALQUILER_BUROFAX");
    //       builder.Property(t => t.FechaActual).HasColumnName("FechaActual");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.NoExpediente).HasColumnName("NoExpediente");
    //       builder.Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
    //       builder.Property(t => t.ReferenciaExternaMACRO).HasColumnName("ReferenciaExternaMACRO");
    //       builder.Property(t => t.ReferenciaExternaMSGI).HasColumnName("ReferenciaExternaMSGI");
    //       builder.Property(t => t.NombreDeudor).HasColumnName("NombreDeudor");
    //       builder.Property(t => t.DocumentoDeudor).HasColumnName("DocumentoDeudor");
    //       builder.Property(t => t.DomicilioNotificacion).HasColumnName("DomicilioNotificacion");
    //       builder.Property(t => t.TipoInmueble).HasColumnName("TipoInmueble");
    //       builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
    //       builder.Property(t => t.DireccionInmueble).HasColumnName("DireccionInmueble");
    //    }
    //}
}
