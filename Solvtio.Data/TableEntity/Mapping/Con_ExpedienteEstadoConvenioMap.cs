using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoConvenioMap : EntityTypeConfiguration<Con_ExpedienteEstadoConvenio>
    {
        public Con_ExpedienteEstadoConvenioMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Con_ExpedienteEstadoConvenio");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.FechaApertura).HasColumnName("FechaApertura");
            Property(t => t.FechaJuntaAcreedores).HasColumnName("FechaJuntaAcreedores");
            Property(t => t.FechaPresentacionPropuestaConvenio).HasColumnName("FechaPresentacionPropuestaConvenio");
            Property(t => t.ConvenioAnticipado).HasColumnName("ConvenioAnticipado");
            Property(t => t.SentenciaAprobandoConvenio).HasColumnName("SentenciaAprobandoConvenio");
            Property(t => t.SuperaLimites).HasColumnName("SuperaLimites");
            Property(t => t.DocumentoSentenciaConvenioId).HasColumnName("DocumentoSentenciaConvenioId");
            Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");

            // Relationships
            HasOptional(t => t.ExpedienteDocumento)
                .WithMany(t => t.Con_ExpedienteEstadoConvenio)
                .HasForeignKey(d => d.DocumentoSentenciaConvenioId);
            HasOptional(t => t.ExpedienteDocumento1)
                .WithMany(t => t.Con_ExpedienteEstadoConvenio1)
                .HasForeignKey(d => d.DocumentoAutoJuezId);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Con_ExpedienteEstadoConvenio);

        }
    }
}
