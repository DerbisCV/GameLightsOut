using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoFinalizacionMap : EntityTypeConfiguration<Hip_ExpedienteEstadoFinalizacion>
    {
        public Hip_ExpedienteEstadoFinalizacionMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoFinalizacion");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.PagoDeuda).HasColumnName("PagoDeuda");
            Property(t => t.DacionPago).HasColumnName("DacionPago");
            Property(t => t.EstimacionOposicion).HasColumnName("EstimacionOposicion");
            Property(t => t.Devuelto).HasColumnName("Devuelto");
            Property(t => t.Llaves).HasColumnName("Llaves");
            Property(t => t.IdMotivo).HasColumnName("IdMotivo");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Hip_ExpedienteEstadoFinalizacion);
            HasOptional(t => t.Gnr_TipoEstadoMotivo)
                .WithMany(t => t.Hip_ExpedienteEstadoFinalizacion)
                .HasForeignKey(d => d.IdMotivo);

        }
    }
}
