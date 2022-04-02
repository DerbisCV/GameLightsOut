using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoEfectividadEmbargoMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoEfectividadEmbargo>
    {
        public Ejc_ExpedienteEstadoEfectividadEmbargoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoEfectividadEmbargo");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.BienesInmuebles).HasColumnName("BienesInmuebles");
            Property(t => t.BienesMuebles).HasColumnName("BienesMuebles");
            Property(t => t.BienesSalarios).HasColumnName("BienesSalarios");
            Property(t => t.BienesSaldosRetenciones).HasColumnName("BienesSaldosRetenciones");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoEfectividadEmbargo);

        }
    }
}
