using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteIncidenteMap : EntityTypeConfiguration<Con_ExpedienteIncidente>
    {
        public Con_ExpedienteIncidenteMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteIncidente);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired();

            Property(t => t.Actor)
                .HasMaxLength(50);

            Property(t => t.Demandado)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Con_ExpedienteIncidente");
            Property(t => t.IdExpedienteIncidente).HasColumnName("IdExpedienteIncidente");
            //Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //Property(t => t.IdTipoIncidente).HasColumnName("IdTipoIncidente");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Actor).HasColumnName("Actor");
            Property(t => t.Demandado).HasColumnName("Demandado");
            Property(t => t.FechaInterposicion).HasColumnName("FechaInterposicion");
            Property(t => t.FechaVista).HasColumnName("FechaVista");
            Property(t => t.FechaSentencia).HasColumnName("FechaSentencia");
            Property(t => t.Apelacion).HasColumnName("Apelacion");
            //Property(t => t.DocumentoDemandaId).HasColumnName("DocumentoDemandaId");
            //Property(t => t.DocumentoSentenciaId).HasColumnName("DocumentoSentenciaId");
            //Property(t => t.IdFase).HasColumnName("IdFase");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    .WithMany(t => t.Con_ExpedienteIncidente)
            //    .HasForeignKey(d => d.DocumentoDemandaId);
            //HasOptional(t => t.ExpedienteDocumento1)
            //    .WithMany(t => t.Con_ExpedienteIncidente1)
            //    .HasForeignKey(d => d.DocumentoSentenciaId);
            HasRequired(t => t.Expediente)
                .WithMany(t => t.Con_ExpedienteIncidente)
                .HasForeignKey(d => d.IdExpediente);
            HasOptional(t => t.Con_TipoFase)
                .WithMany(t => t.Con_ExpedienteIncidente)
                .HasForeignKey(d => d.IdFase);
            HasRequired(t => t.Con_TipoIncidente)
                .WithMany(t => t.Con_ExpedienteIncidente)
                .HasForeignKey(d => d.IdTipoIncidente);

        }
    }
}
