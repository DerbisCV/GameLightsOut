using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteIncidenteMap : IEntityTypeConfiguration<Con_ExpedienteIncidente>
    {

            public void Configure(EntityTypeBuilder<Con_ExpedienteIncidente> builder) {
           builder.HasKey(t => t.IdExpedienteIncidente);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired();

           builder.Property(t => t.Actor)
                .HasMaxLength(50);

           builder.Property(t => t.Demandado)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteIncidente");
           builder.Property(t => t.IdExpedienteIncidente).HasColumnName("IdExpedienteIncidente");
            //Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //Property(t => t.IdTipoIncidente).HasColumnName("IdTipoIncidente");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Actor).HasColumnName("Actor");
           builder.Property(t => t.Demandado).HasColumnName("Demandado");
           builder.Property(t => t.FechaInterposicion).HasColumnName("FechaInterposicion");
           builder.Property(t => t.FechaVista).HasColumnName("FechaVista");
           builder.Property(t => t.FechaSentencia).HasColumnName("FechaSentencia");
           builder.Property(t => t.Apelacion).HasColumnName("Apelacion");
            //Property(t => t.DocumentoDemandaId).HasColumnName("DocumentoDemandaId");
            //Property(t => t.DocumentoSentenciaId).HasColumnName("DocumentoSentenciaId");
            //Property(t => t.IdFase).HasColumnName("IdFase");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Con_ExpedienteIncidente)
            //    //  .HasForeignKey(d => d.DocumentoDemandaId);
            //HasOptional(t => t.ExpedienteDocumento1)
            //    //  .WithMany(t => t.Con_ExpedienteIncidente1)
            //    //  .HasForeignKey(d => d.DocumentoSentenciaId);
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.Con_ExpedienteIncidente)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasOptional(t => t.Con_TipoFase)
                //  .WithMany(t => t.Con_ExpedienteIncidente)
                //  .HasForeignKey(d => d.IdFase);
            //HasRequired(t => t.Con_TipoIncidente)
                //  .WithMany(t => t.Con_ExpedienteIncidente)
                //  .HasForeignKey(d => d.IdTipoIncidente);

        }
    }
}
