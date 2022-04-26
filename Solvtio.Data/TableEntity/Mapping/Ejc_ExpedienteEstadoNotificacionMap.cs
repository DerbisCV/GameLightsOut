using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoNotificacionMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoNotificacion>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoNotificacion> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

           builder.Property(t => t.AdmitidaNoAuto)
                .HasMaxLength(100);

            //this.Property(t => t.AdmitidaJuzgado)
            //    .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoNotificacion");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
           builder.Property(t => t.AdmitidaNoAuto).HasColumnName("AdmitidaNoAuto");
            //this.Property(t => t.AdmitidaJuzgado).HasColumnName("AdmitidaJuzgado");
           builder.Property(t => t.Oposicion).HasColumnName("Oposicion");
           builder.Property(t => t.OposicionFecha).HasColumnName("OposicionFecha");
           builder.Property(t => t.OposicionFechaVista).HasColumnName("OposicionFechaVista");
           builder.Property(t => t.OposicionFechaResolucion).HasColumnName("OposicionFechaResolucion");
           builder.Property(t => t.IdDocumentoAutoEjecucion).HasColumnName("IdDocumentoAutoEjecucion");
           builder.Property(t => t.IdDocumentoOposicion).HasColumnName("IdDocumentoOposicion");
           builder.Property(t => t.IdDocumentoOposicionVista).HasColumnName("IdDocumentoOposicionVista");
           builder.Property(t => t.IdDocumentoOposicionResolucion).HasColumnName("IdDocumentoOposicionResolucion");
           builder.Property(t => t.Apelacion).HasColumnName("Apelacion");
           builder.Property(t => t.ApelacionFecha).HasColumnName("ApelacionFecha");
           builder.Property(t => t.ApelacionPor).HasColumnName("ApelacionPor");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoNotificacion);
            //// HasOptional(t => t.ExpedienteDocumentoAutoEjecucion)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion)
            //    //  .HasForeignKey(d => d.IdDocumentoAutoEjecucion);
            //// HasOptional(t => t.ExpedienteDocumentoOposicion)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion1)
            //    //  .HasForeignKey(d => d.IdDocumentoOposicion);
            //// HasOptional(t => t.ExpedienteDocumentoOposicionResolucion)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion2)
            //    //  .HasForeignKey(d => d.IdDocumentoOposicionResolucion);
            //// HasOptional(t => t.ExpedienteDocumentoOposicionVista)
            //    //  .WithMany(t => t.Ejc_ExpedienteEstadoNotificacion3)
            //    //  .HasForeignKey(d => d.IdDocumentoOposicionVista);

        }
    }
}
