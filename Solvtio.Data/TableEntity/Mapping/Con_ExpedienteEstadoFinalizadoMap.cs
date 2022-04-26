using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoFinalizadoMap : IEntityTypeConfiguration<Con_ExpedienteEstadoFinalizado>
    {
           public void Configure(EntityTypeBuilder<Con_ExpedienteEstadoFinalizado> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteEstadoFinalizado");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaFinalizacion).HasColumnName("FechaFinalizacion");
            //Property(t => t.DocumentoAutoConclusionId).HasColumnName("DocumentoAutoConclusionId");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoFinalizado)
            //    //  .HasForeignKey(d => d.DocumentoAutoConclusionId);
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Con_ExpedienteEstadoFinalizado);

        }
    }
}
