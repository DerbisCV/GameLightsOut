using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoTramiteEmbargoMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoTramiteEmbargo>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoTramiteEmbargo> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoTramiteEmbargo");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.FechaAveriguacion).HasColumnName("FechaAveriguacion");
           builder.Property(t => t.AveriguacionBienesInmuebles).HasColumnName("AveriguacionBienesInmuebles");
           builder.Property(t => t.AveriguacionBienesMuebles).HasColumnName("AveriguacionBienesMuebles");
           builder.Property(t => t.AveriguacionBienesSalarios).HasColumnName("AveriguacionBienesSalarios");
           builder.Property(t => t.AveriguacionBienesSaldosRetenciones).HasColumnName("AveriguacionBienesSaldosRetenciones");
           builder.Property(t => t.FechaDecretoEmbargo).HasColumnName("FechaDecretoEmbargo");
           builder.Property(t => t.DecretoEmbargoBienesInmuebles).HasColumnName("DecretoEmbargoBienesInmuebles");
           builder.Property(t => t.DecretoEmbargoBienesMuebles).HasColumnName("DecretoEmbargoBienesMuebles");
           builder.Property(t => t.DecretoEmbargoBienesSalarios).HasColumnName("DecretoEmbargoBienesSalarios");
           builder.Property(t => t.DecretoEmbargoBienesSaldosRetenciones).HasColumnName("DecretoEmbargoBienesSaldosRetenciones");
            //Property(t => t.IdDocumentoAveriguacion).HasColumnName("IdDocumentoAveriguacion");
            //Property(t => t.IdDocumentoDecretoEmbargo).HasColumnName("IdDocumentoDecretoEmbargo");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoTramiteEmbargo);
            //// HasOptional(t => t.ExpedienteDocumentoAveriguacion)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoTramiteEmbargo)
            //    //  .HasForeignKey(d => d.IdDocumentoAveriguacion);
            //// HasOptional(t => t.ExpedienteDocumentoDecretoEmbargo)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoTramiteEmbargo1)
            //    //  .HasForeignKey(d => d.IdDocumentoDecretoEmbargo);

        }
    }
}
