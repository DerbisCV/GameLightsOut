using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoSolicitudSubastaMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoSolicitudSubasta>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoSolicitudSubasta> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoSolicitudSubasta");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.FechaSolicitudSubasta).HasColumnName("FechaSolicitudSubasta");
           builder.Property(t => t.IdDocumentoSolicitudSubasta).HasColumnName("IdDocumentoSolicitudSubasta");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoSolicitudSubasta);
            //// HasOptional(t => t.ExpedienteDocumentoSolicitudSubasta)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoSolicitudSubasta)
            //    //  .HasForeignKey(d => d.IdDocumentoSolicitudSubasta);

        }
    }
}
