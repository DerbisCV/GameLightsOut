using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoEfectividadEmbargoMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoEfectividadEmbargo>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoEfectividadEmbargo> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoEfectividadEmbargo");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.BienesInmuebles).HasColumnName("BienesInmuebles");
           builder.Property(t => t.BienesMuebles).HasColumnName("BienesMuebles");
           builder.Property(t => t.BienesSalarios).HasColumnName("BienesSalarios");
           builder.Property(t => t.BienesSaldosRetenciones).HasColumnName("BienesSaldosRetenciones");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoEfectividadEmbargo);

        }
    }
}
