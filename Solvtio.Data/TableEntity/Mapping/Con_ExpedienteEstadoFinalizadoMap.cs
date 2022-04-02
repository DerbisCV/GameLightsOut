using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoFinalizadoMap : EntityTypeConfiguration<Con_ExpedienteEstadoFinalizado>
    {
        public Con_ExpedienteEstadoFinalizadoMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Con_ExpedienteEstadoFinalizado");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaFinalizacion).HasColumnName("FechaFinalizacion");
            //Property(t => t.DocumentoAutoConclusionId).HasColumnName("DocumentoAutoConclusionId");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    .WithMany(t => t.Con_ExpedienteEstadoFinalizado)
            //    .HasForeignKey(d => d.DocumentoAutoConclusionId);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Con_ExpedienteEstadoFinalizado);

        }
    }
}
