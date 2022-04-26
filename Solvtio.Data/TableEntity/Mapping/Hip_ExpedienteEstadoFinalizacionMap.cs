using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoFinalizacionMap : IEntityTypeConfiguration<Hip_ExpedienteEstadoFinalizacion>
    {
        public Hip_ExpedienteEstadoFinalizacionMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_ExpedienteEstadoFinalizacion> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoFinalizacion");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.PagoDeuda).HasColumnName("PagoDeuda");
           builder.Property(t => t.DacionPago).HasColumnName("DacionPago");
           builder.Property(t => t.EstimacionOposicion).HasColumnName("EstimacionOposicion");
           builder.Property(t => t.Devuelto).HasColumnName("Devuelto");
           builder.Property(t => t.Llaves).HasColumnName("Llaves");
           builder.Property(t => t.IdMotivo).HasColumnName("IdMotivo");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Hip_ExpedienteEstadoFinalizacion);
            //// HasOptional(t => t.Gnr_TipoEstadoMotivo)
            //    //  .WithMany(t => t.Hip_ExpedienteEstadoFinalizacion)
            //    //  .HasForeignKey(d => d.IdMotivo);

        }
    }
}
