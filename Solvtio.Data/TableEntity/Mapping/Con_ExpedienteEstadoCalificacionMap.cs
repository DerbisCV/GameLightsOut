using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class Con_ExpedienteEstadoCalificacionMap : IEntityTypeConfiguration<Con_ExpedienteEstadoCalificacion>
    //{
    //    public void Configure(EntityTypeBuilder<Con_ExpedienteEstadoCalificacion> builder) {
    //        builder.HasKey(t => t.ExpedienteEstadoId);

    //        // Properties
    //        builder.Property(t => t.ExpedienteEstadoId)
    //             .ValueGeneratedNever();

    //        // Table & Column Mappings
    //        builder.ToTable("Con_ExpedienteEstadoCalificacion");
    //        builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
    //        builder.Property(t => t.FechaApertura).HasColumnName("FechaApertura");
    //        builder.Property(t => t.FechaPersonacion).HasColumnName("FechaPersonacion");
    //        builder.Property(t => t.CalificacionAC).HasColumnName("CalificacionAC");
    //        builder.Property(t => t.CalificacionFiscal).HasColumnName("CalificacionFiscal");
    //        builder.Property(t => t.CalificacionDefinitiva).HasColumnName("CalificacionDefinitiva");
    //        builder.Property(t => t.FechaVista).HasColumnName("FechaVista");
    //        builder.Property(t => t.FechaSentencia).HasColumnName("FechaSentencia");
    //        builder.Property(t => t.DocumentoSentenciaId).HasColumnName("DocumentoSentenciaId");
    //        builder.Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");
    //        builder.Property(t => t.DocumentoPersonacionId).HasColumnName("DocumentoPersonacionId");

    //        // Relationships
    //        HasOptional(t => t.ExpedienteDocumento)
    //            //  .WithMany(t => t.Con_ExpedienteEstadoCalificacion)
    //            //  .HasForeignKey(d => d.DocumentoSentenciaId);
    //        HasOptional(t => t.ExpedienteDocumento1)
    //            //  .WithMany(t => t.Con_ExpedienteEstadoCalificacion1)
    //            //  .HasForeignKey(d => d.DocumentoAutoJuezId);
    //        HasOptional(t => t.ExpedienteDocumento2)
    //            //  .WithMany(t => t.Con_ExpedienteEstadoCalificacion2)
    //            //  .HasForeignKey(d => d.DocumentoPersonacionId);
    //            //HasRequired(t => t.ExpedienteEstado)
    //            .WithOptional(t => t.Con_ExpedienteEstadoCalificacion);
    //        HasOptional(t => t.Con_TipoCalificacion)
    //            //  .WithMany(t => t.Con_ExpedienteEstadoCalificacion)
    //            //  .HasForeignKey(d => d.CalificacionAC);
    //        HasOptional(t => t.Con_TipoCalificacion1)
    //            //  .WithMany(t => t.Con_ExpedienteEstadoCalificacion1)
    //            //  .HasForeignKey(d => d.CalificacionFiscal);
    //        HasOptional(t => t.Con_TipoCalificacion2)
    //            //  .WithMany(t => t.Con_ExpedienteEstadoCalificacion2)
    //            //  .HasForeignKey(d => d.CalificacionDefinitiva);

    //    }
    //}
}
