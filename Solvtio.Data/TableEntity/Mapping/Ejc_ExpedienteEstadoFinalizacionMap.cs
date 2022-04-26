using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoFinalizacionMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoFinalizacion>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoFinalizacion> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoFinalizacion");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdMotivo).HasColumnName("IdMotivo");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoFinalizacion);
            //// HasOptional(t => t.Gnr_TipoEstadoMotivo)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoFinalizacion)
            //    //  .HasForeignKey(d => d.IdMotivo);

        }
    }
}
