using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoPresentacionDemandaMap : IEntityTypeConfiguration<Alq_Expediente_EstadoPresentacionDemanda>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_EstadoPresentacionDemanda> builder)
        {
            // public void Configure(EntityTypeBuilder<object> builder)
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.ID)
                .ValueGeneratedOnAdd();

            

            builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

           builder.Property(t => t.AdmitidaNoAuto)
                .HasMaxLength(100);

           builder.Property(t => t.AdmitidaJuzgado)
                .HasMaxLength(500);

            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_EstadoPresentacionDemanda");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.FechaPagoTasas).HasColumnName("FechaPagoTasas");
           builder.Property(t => t.FechaPagoTasasAutomaticas).HasColumnName("FechaPagoTasasAutomaticas");
           builder.Property(t => t.FechaEnvioProcurador).HasColumnName("FechaEnvioProcurador");
           builder.Property(t => t.FechaPresentacion).HasColumnName("FechaPresentacion");
           builder.Property(t => t.DocumentoTasasId).HasColumnName("DocumentoTasasId");
           builder.Property(t => t.DocumentoPresentacionId).HasColumnName("DocumentoPresentacionId");
           builder.Property(t => t.DocumentoAutoEjecucionId).HasColumnName("DocumentoAutoEjecucionId");
            //this.Property(t => t.AdmitidaFecha).HasColumnName("AdmitidaFecha");
           builder.Property(t => t.AdmitidaDocumentoId).HasColumnName("AdmitidaDocumentoId");
           builder.Property(t => t.AdmitidaNoAuto).HasColumnName("AdmitidaNoAuto");
           builder.Property(t => t.AdmitidaJuzgado).HasColumnName("AdmitidaJuzgado");
           builder.Property(t => t.NoAdmitidaFecha).HasColumnName("NoAdmitidaFecha");
           builder.Property(t => t.NoAdmitidaFechaApelacion).HasColumnName("NoAdmitidaFechaApelacion");
           builder.Property(t => t.NoAdmitidaApelacion).HasColumnName("NoAdmitidaApelacion");
           builder.Property(t => t.NoAdmitidaDocumentoId).HasColumnName("NoAdmitidaDocumentoId");
           builder.Property(t => t.NoAdmitidaDocumentoApelacionId).HasColumnName("NoAdmitidaDocumentoApelacionId");

            // Relationships
            //builder.HasOne(t => t.ExpedienteEstado).IsRequired();
            //    .WithOptional(t => t.Alq_Expediente_EstadoPresentacionDemanda);


       //     modelBuilder.Entity<MyEntity>()
       //.HasOne(p => p.Relationship).IsRequired();

            
            //HasOptional(t => t.ExpedienteDocumento)
            //    .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda)
            //    .HasForeignKey(d => d.AdmitidaDocumentoId);
            //HasOptional(t => t.ExpedienteDocumento1)
            //    .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda1)
            //    .HasForeignKey(d => d.NoAdmitidaDocumentoApelacionId);
            //HasOptional(t => t.ExpedienteDocumento2)
            //    .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda2)
            //    .HasForeignKey(d => d.DocumentoAutoEjecucionId);
            //HasOptional(t => t.ExpedienteDocumento3)
            //    .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda3)
            //    .HasForeignKey(d => d.NoAdmitidaDocumentoId);
            //HasOptional(t => t.ExpedienteDocumento4)
            //    .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda4)
            //    .HasForeignKey(d => d.DocumentoPresentacionId);
            //HasOptional(t => t.ExpedienteDocumento5)
            //    .WithMany(t => t.Alq_Expediente_EstadoPresentacionDemanda5)
            //    .HasForeignKey(d => d.DocumentoTasasId);

        }
    }
}
