using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoFinalizacionMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoFinalizacion>
    {
        public Ejc_ExpedienteEstadoFinalizacionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoFinalizacion");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdMotivo).HasColumnName("IdMotivo");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoFinalizacion);
            HasOptional(t => t.Gnr_TipoEstadoMotivo)
                .WithMany(t => t.Ejc_ExpedienteEstadoFinalizacion)
                .HasForeignKey(d => d.IdMotivo);

        }
    }
}
