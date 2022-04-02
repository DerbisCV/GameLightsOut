using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoNotificacionMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoNotificacion>
    {
        public Ejc_ExpedienteEstadoNotificacionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.AdmitidaNoAuto)
                .HasMaxLength(100);

            //this.Property(t => t.AdmitidaJuzgado)
            //    .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoNotificacion");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
            Property(t => t.AdmitidaNoAuto).HasColumnName("AdmitidaNoAuto");
            //this.Property(t => t.AdmitidaJuzgado).HasColumnName("AdmitidaJuzgado");
            Property(t => t.Oposicion).HasColumnName("Oposicion");
            Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
            Property(t => t.OposicionFechaVista).HasColumnName("OposicionFechaVista");
            Property(t => t.OposicionFechaResolucion).HasColumnName("OposicionFechaResolucion");
            Property(t => t.IdDocumentoAutoEjecucion).HasColumnName("IdDocumentoAutoEjecucion");
            Property(t => t.IdDocumentoOposicion).HasColumnName("IdDocumentoOposicion");
            Property(t => t.IdDocumentoOposicionVista).HasColumnName("IdDocumentoOposicionVista");
            Property(t => t.IdDocumentoOposicionResolucion).HasColumnName("IdDocumentoOposicionResolucion");
            Property(t => t.Apelacion).HasColumnName("Apelacion");
            Property(t => t.ApelacionFecha).HasColumnName("ApelacionFecha");
            Property(t => t.ApelacionPor).HasColumnName("ApelacionPor");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoNotificacion);
            HasOptional(t => t.ExpedienteDocumentoAutoEjecucion)
                .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion)
                .HasForeignKey(d => d.IdDocumentoAutoEjecucion);
            HasOptional(t => t.ExpedienteDocumentoOposicion)
                .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion1)
                .HasForeignKey(d => d.IdDocumentoOposicion);
            HasOptional(t => t.ExpedienteDocumentoOposicionResolucion)
                .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion2)
                .HasForeignKey(d => d.IdDocumentoOposicionResolucion);
            HasOptional(t => t.ExpedienteDocumentoOposicionVista)
                .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion3)
                .HasForeignKey(d => d.IdDocumentoOposicionVista);

        }
    }
}
