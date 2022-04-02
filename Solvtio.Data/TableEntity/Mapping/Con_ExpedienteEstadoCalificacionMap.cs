using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    //public class Con_ExpedienteEstadoCalificacionMap : EntityTypeConfiguration<Con_ExpedienteEstadoCalificacion>
    //{
    //    public Con_ExpedienteEstadoCalificacionMap()
    //    {
    //        // Primary Key
    //        HasKey(t => t.ExpedienteEstadoId);

    //        // Properties
    //        Property(t => t.ExpedienteEstadoId)
    //            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

    //        // Table & Column Mappings
    //        ToTable("Con_ExpedienteEstadoCalificacion");
    //        Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
    //        Property(t => t.FechaApertura).HasColumnName("FechaApertura");
    //        Property(t => t.FechaPersonacion).HasColumnName("FechaPersonacion");
    //        Property(t => t.CalificacionAC).HasColumnName("CalificacionAC");
    //        Property(t => t.CalificacionFiscal).HasColumnName("CalificacionFiscal");
    //        Property(t => t.CalificacionDefinitiva).HasColumnName("CalificacionDefinitiva");
    //        Property(t => t.FechaVista).HasColumnName("FechaVista");
    //        Property(t => t.FechaSentencia).HasColumnName("FechaSentencia");
    //        Property(t => t.DocumentoSentenciaId).HasColumnName("DocumentoSentenciaId");
    //        Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");
    //        Property(t => t.DocumentoPersonacionId).HasColumnName("DocumentoPersonacionId");

    //        // Relationships
    //        HasOptional(t => t.ExpedienteDocumento)
    //            .WithMany(t => t.Con_ExpedienteEstadoCalificacion)
    //            .HasForeignKey(d => d.DocumentoSentenciaId);
    //        HasOptional(t => t.ExpedienteDocumento1)
    //            .WithMany(t => t.Con_ExpedienteEstadoCalificacion1)
    //            .HasForeignKey(d => d.DocumentoAutoJuezId);
    //        HasOptional(t => t.ExpedienteDocumento2)
    //            .WithMany(t => t.Con_ExpedienteEstadoCalificacion2)
    //            .HasForeignKey(d => d.DocumentoPersonacionId);
    //        HasRequired(t => t.ExpedienteEstado)
    //            .WithOptional(t => t.Con_ExpedienteEstadoCalificacion);
    //        HasOptional(t => t.Con_TipoCalificacion)
    //            .WithMany(t => t.Con_ExpedienteEstadoCalificacion)
    //            .HasForeignKey(d => d.CalificacionAC);
    //        HasOptional(t => t.Con_TipoCalificacion1)
    //            .WithMany(t => t.Con_ExpedienteEstadoCalificacion1)
    //            .HasForeignKey(d => d.CalificacionFiscal);
    //        HasOptional(t => t.Con_TipoCalificacion2)
    //            .WithMany(t => t.Con_ExpedienteEstadoCalificacion2)
    //            .HasForeignKey(d => d.CalificacionDefinitiva);

    //    }
    //}
}
