using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoProcesoParalizadoMap : IEntityTypeConfiguration<Hip_ExpedienteEstadoProcesoParalizado>
    {
        public Hip_ExpedienteEstadoProcesoParalizadoMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_ExpedienteEstadoProcesoParalizado> builder) {
           builder.HasKey(t => t.IdExpedienteEstadoParalizado);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoProcesoParalizado");
           builder.Property(t => t.IdExpedienteEstadoParalizado).HasColumnName("IdExpedienteEstadoParalizado");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaParalizado).HasColumnName("FechaParalizado");
           builder.Property(t => t.ImporteParalizado).HasColumnName("ImporteParalizado");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
           builder.Property(t => t.IdMotivo).HasColumnName("IdMotivo");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithMany(t => t.Hip_ExpedienteEstadoProcesoParalizado)
                //  .HasForeignKey(d => d.ExpedienteEstadoId);
            //// HasOptional(t => t.Gnr_TipoEstadoMotivo)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoProcesoParalizado)
            //    //  .HasForeignKey(d => d.IdMotivo);

        }
    }
}
