using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vGnr_PlantillaDoc_ALQUILER_BUROFAXMap : EntityTypeConfiguration<vGnr_PlantillaDoc_ALQUILER_BUROFAX>
    {
        public vGnr_PlantillaDoc_ALQUILER_BUROFAXMap()
        {
            // Primary Key
            HasKey(t => new { t.IdExpediente, t.NoExpediente, t.DocumentoDeudor, t.TipoInmueble });

            // Properties
            Property(t => t.FechaActual)
                .HasMaxLength(50);

            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.NoExpediente)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

            Property(t => t.ReferenciaExternaMACRO)
                .HasMaxLength(50);

            Property(t => t.ReferenciaExternaMSGI)
                .HasMaxLength(50);

            Property(t => t.NombreDeudor)
                .HasMaxLength(801);

            Property(t => t.DocumentoDeudor)
                .IsRequired()
                .HasMaxLength(301);

            Property(t => t.TipoInmueble)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.DireccionInmueble)
                .HasMaxLength(362);

            // Table & Column Mappings
            ToTable("vGnr_PlantillaDoc_ALQUILER_BUROFAX");
            Property(t => t.FechaActual).HasColumnName("FechaActual");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.NoExpediente).HasColumnName("NoExpediente");
            Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
            Property(t => t.ReferenciaExternaMACRO).HasColumnName("ReferenciaExternaMACRO");
            Property(t => t.ReferenciaExternaMSGI).HasColumnName("ReferenciaExternaMSGI");
            Property(t => t.NombreDeudor).HasColumnName("NombreDeudor");
            Property(t => t.DocumentoDeudor).HasColumnName("DocumentoDeudor");
            Property(t => t.DomicilioNotificacion).HasColumnName("DomicilioNotificacion");
            Property(t => t.TipoInmueble).HasColumnName("TipoInmueble");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.DireccionInmueble).HasColumnName("DireccionInmueble");
        }
    }
}
