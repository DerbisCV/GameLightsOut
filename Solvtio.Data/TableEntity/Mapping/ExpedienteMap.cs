using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class ExpedienteMap : IEntityTypeConfiguration<Expediente>
    {
        public void Configure(EntityTypeBuilder<Expediente> builder)
        {
            builder.HasKey(t => t.IdExpediente);

            // Properties
            builder
                .Property(t => t.NoExpediente)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(t => t.ReferenciaExterna)
                 .HasMaxLength(50);

            builder.Property(t => t.Usuario)
                 .HasMaxLength(50);

            builder.Property(t => t.NoAuto)
                 .HasMaxLength(50);

            //this.Property(t => t.JuzgadoName)
            //    .HasMaxLength(500);

            // Table & Column Mappings
            builder.ToTable("Expediente");
            //builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //Property(t => t.IdValija).HasColumnName("IdValija");
            //builder.Property(t => t.NoExpediente).HasColumnName("NoExpediente");
            //builder.Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
            //builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            //builder.Property(t => t.IdAbogado).HasColumnName("IdAbogado");
            //builder.Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
            //builder.Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
            //builder.Property(t => t.IdProcurador).HasColumnName("IdProcurador");
            //builder.Property(t => t.FechaCierre).HasColumnName("FechaCierre");
            //builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            //builder.Property(t => t.Usuario).HasColumnName("Usuario");
            //builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
            //builder.Property(t => t.DeudaFinal).HasColumnName("DeudaFinal");
            //builder.Property(t => t.IdTipoEstadoLast).HasColumnName("IdTipoEstadoLast");
            //builder.Property(t => t.NoAuto).HasColumnName("NoAuto");
            ////this.Property(t => t.JuzgadoName).HasColumnName("Juzgado");
            //builder.Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");

            // Relationships
            // HasOptional(t => t.Gnr_Abogado)
            //  .WithMany(t => t.Expedientes)
            //  .HasForeignKey(d => d.IdAbogado);
            //HasRequired(t => t.Gnr_ClienteOficina)
            //  .WithMany(t => t.Expedientes)
            //  .HasForeignKey(d => d.IdClienteOficina);
            // HasOptional(t => t.Gnr_Procurador)
            //  .WithMany(t => t.Expedientes)
            //  .HasForeignKey(d => d.IdProcurador);
            ////HasRequired(t => t.Gnr_Valija)
            //    //  .WithMany(t => t.Expedientes)
            //    //  .HasForeignKey(d => d.IdValija);
            // HasOptional(t => t.Hip_PartidoJudicial)
            //  .WithMany(t => t.Expedientes)
            //  .HasForeignKey(d => d.IdPartidoJudicial);
            //HasRequired(t => t.Gnr_TipoArea)
            //  .WithMany(t => t.Expedientes)
            //  .HasForeignKey(d => d.IdTipoArea);
            //HasRequired(t => t.Gnr_TipoExpediente)
            //  .WithMany(t => t.Expedientes)
            //  .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
