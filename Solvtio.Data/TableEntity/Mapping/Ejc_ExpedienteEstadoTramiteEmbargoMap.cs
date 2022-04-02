using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoTramiteEmbargoMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoTramiteEmbargo>
    {
        public Ejc_ExpedienteEstadoTramiteEmbargoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoTramiteEmbargo");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.FechaAveriguacion).HasColumnName("FechaAveriguacion");
            Property(t => t.AveriguacionBienesInmuebles).HasColumnName("AveriguacionBienesInmuebles");
            Property(t => t.AveriguacionBienesMuebles).HasColumnName("AveriguacionBienesMuebles");
            Property(t => t.AveriguacionBienesSalarios).HasColumnName("AveriguacionBienesSalarios");
            Property(t => t.AveriguacionBienesSaldosRetenciones).HasColumnName("AveriguacionBienesSaldosRetenciones");
            Property(t => t.FechaDecretoEmbargo).HasColumnName("FechaDecretoEmbargo");
            Property(t => t.DecretoEmbargoBienesInmuebles).HasColumnName("DecretoEmbargoBienesInmuebles");
            Property(t => t.DecretoEmbargoBienesMuebles).HasColumnName("DecretoEmbargoBienesMuebles");
            Property(t => t.DecretoEmbargoBienesSalarios).HasColumnName("DecretoEmbargoBienesSalarios");
            Property(t => t.DecretoEmbargoBienesSaldosRetenciones).HasColumnName("DecretoEmbargoBienesSaldosRetenciones");
            //Property(t => t.IdDocumentoAveriguacion).HasColumnName("IdDocumentoAveriguacion");
            //Property(t => t.IdDocumentoDecretoEmbargo).HasColumnName("IdDocumentoDecretoEmbargo");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoTramiteEmbargo);
            //HasOptional(t => t.ExpedienteDocumentoAveriguacion)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoTramiteEmbargo)
            //    .HasForeignKey(d => d.IdDocumentoAveriguacion);
            //HasOptional(t => t.ExpedienteDocumentoDecretoEmbargo)
            //    .WithMany(t => t.Ejc_ExpedienteEstadoTramiteEmbargo1)
            //    .HasForeignKey(d => d.IdDocumentoDecretoEmbargo);

        }
    }
}
