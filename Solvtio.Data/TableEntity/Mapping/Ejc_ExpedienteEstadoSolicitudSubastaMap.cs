using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoSolicitudSubastaMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoSolicitudSubasta>
    {
        public Ejc_ExpedienteEstadoSolicitudSubastaMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoSolicitudSubasta");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.FechaSolicitudSubasta).HasColumnName("FechaSolicitudSubasta");
            Property(t => t.IdDocumentoSolicitudSubasta).HasColumnName("IdDocumentoSolicitudSubasta");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoSolicitudSubasta);
            HasOptional(t => t.ExpedienteDocumentoSolicitudSubasta)
                .WithMany(t => t.Ejc_ExpedienteEstadoSolicitudSubasta)
                .HasForeignKey(d => d.IdDocumentoSolicitudSubasta);

        }
    }
}
