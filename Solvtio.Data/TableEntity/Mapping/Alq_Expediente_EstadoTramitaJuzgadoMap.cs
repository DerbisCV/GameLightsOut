using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoTramitaJuzgadoMap : IEntityTypeConfiguration<Alq_Expediente_EstadoTramitaJuzgado>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_EstadoTramitaJuzgado> builder)
        {
            // 
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_EstadoTramitaJuzgado");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.FechaCertificacionCargas).HasColumnName("FechaCertificacionCargas");

            //Property(t => t.Oposicion).HasColumnName("Oposicion");
            //Property(t => t.OposicionFechaLanzamientoInicial).HasColumnName("OposicionFechaLanzamientoInicial");
           builder.Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
           builder.Property(t => t.OposicionFechaDecretoFin).HasColumnName("OposicionFechaDecretoFin");
           builder.Property(t => t.OposicionFechaSentencia).HasColumnName("OposicionFechaSentencia");
           builder.Property(t => t.OposicionFechaRecursoApelacion).HasColumnName("OposicionFechaRecursoApelacion");
           builder.Property(t => t.OposicionFechaNulidadActuaciones).HasColumnName("OposicionFechaNulidadActuaciones");
           builder.Property(t => t.DocumentoCertificacionCargasId).HasColumnName("DocumentoCertificacionCargasId");
           builder.Property(t => t.DocumentoDecretoAdmision).HasColumnName("DocumentoDecretoAdmision");
           builder.Property(t => t.OposicionVistaFecha).HasColumnName("OposicionVistaFecha");
           builder.Property(t => t.OposicionSuspensionVista).HasColumnName("OposicionSuspensionVista");
           builder.Property(t => t.OposicionFechaSuspension60Dias).HasColumnName("OposicionFechaSuspension60Dias");
           builder.Property(t => t.OposicionSentenciaResultado).HasColumnName("OposicionSentenciaResultado");
           builder.Property(t => t.IdAbogadoVista).HasColumnName("IdAbogadoVista");
           builder.Property(t => t.FechaSentencia2).HasColumnName("FechaSentencia2");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
            //    .WithOptional(t => t.Alq_Expediente_EstadoTramitaJuzgado);
            //HasOptional(t => t.Gnr_Abogado)
            //    .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado)
            //    .HasForeignKey(d => d.IdAbogadoVista);

        }
    }
}
