using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoConvenioMap : IEntityTypeConfiguration<Con_ExpedienteEstadoConvenio>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteEstadoConvenio> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteEstadoConvenio");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.FechaApertura).HasColumnName("FechaApertura");
           builder.Property(t => t.FechaJuntaAcreedores).HasColumnName("FechaJuntaAcreedores");
           builder.Property(t => t.FechaPresentacionPropuestaConvenio).HasColumnName("FechaPresentacionPropuestaConvenio");
           builder.Property(t => t.ConvenioAnticipado).HasColumnName("ConvenioAnticipado");
           builder.Property(t => t.SentenciaAprobandoConvenio).HasColumnName("SentenciaAprobandoConvenio");
           builder.Property(t => t.SuperaLimites).HasColumnName("SuperaLimites");
           builder.Property(t => t.DocumentoSentenciaConvenioId).HasColumnName("DocumentoSentenciaConvenioId");
           builder.Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoConvenio)
            //    //  .HasForeignKey(d => d.DocumentoSentenciaConvenioId);
            //HasOptional(t => t.ExpedienteDocumento1)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoConvenio1)
            //    //  .HasForeignKey(d => d.DocumentoAutoJuezId);
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Con_ExpedienteEstadoConvenio);

        }
    }
}
