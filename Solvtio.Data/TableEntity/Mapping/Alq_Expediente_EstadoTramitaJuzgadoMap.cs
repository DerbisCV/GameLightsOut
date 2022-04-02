using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoTramitaJuzgadoMap : EntityTypeConfiguration<Alq_Expediente_EstadoTramitaJuzgado>
    {
        public Alq_Expediente_EstadoTramitaJuzgadoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Alq_Expediente_EstadoTramitaJuzgado");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.FechaCertificacionCargas).HasColumnName("FechaCertificacionCargas");

            //Property(t => t.Oposicion).HasColumnName("Oposicion");
            //Property(t => t.OposicionFechaLanzamientoInicial).HasColumnName("OposicionFechaLanzamientoInicial");
            Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            Property(t => t.OposicionFechaDecretoFin).HasColumnName("OposicionFechaDecretoFin");
            Property(t => t.OposicionFechaSentencia).HasColumnName("OposicionFechaSentencia");
            Property(t => t.OposicionFechaRecursoApelacion).HasColumnName("OposicionFechaRecursoApelacion");
            Property(t => t.OposicionFechaNulidadActuaciones).HasColumnName("OposicionFechaNulidadActuaciones");
            Property(t => t.DocumentoCertificacionCargasId).HasColumnName("DocumentoCertificacionCargasId");
            Property(t => t.DocumentoDecretoAdmision).HasColumnName("DocumentoDecretoAdmision");
            Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
            Property(t => t.OposicionSuspensionVista).HasColumnName("OposicionSuspensionVista");
            Property(t => t.OposicionFechaSuspension60Dias).HasColumnName("OposicionFechaSuspension60Dias");
            Property(t => t.OposicionSentenciaResultado).HasColumnName("OposicionSentenciaResultado");
            Property(t => t.IdAbogadoVista).HasColumnName("IdAbogadoVista");
            Property(t => t.FechaSentencia2).HasColumnName("FechaSentencia2");

            // Relationships
            HasOptional(t => t.ExpedienteDocumento)
                .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado)
                .HasForeignKey(d => d.DocumentoCertificacionCargasId);
            HasOptional(t => t.ExpedienteDocumento1)
                .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado1)
                .HasForeignKey(d => d.DocumentoDecretoAdmision);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Alq_Expediente_EstadoTramitaJuzgado);
            HasOptional(t => t.Gnr_Abogado)
                .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado)
                .HasForeignKey(d => d.IdAbogadoVista);

        }
    }
}
