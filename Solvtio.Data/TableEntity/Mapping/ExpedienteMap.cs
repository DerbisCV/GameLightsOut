using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteMap : EntityTypeConfiguration<Expediente>
    {
        public ExpedienteMap()
        {
            // Primary Key
            HasKey(t => t.IdExpediente);

            // Properties
            Property(t => t.NoExpediente)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            Property(t => t.NoAuto)
                .HasMaxLength(50);

            //this.Property(t => t.JuzgadoName)
            //    .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Expediente");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //Property(t => t.IdValija).HasColumnName("IdValija");
            Property(t => t.NoExpediente).HasColumnName("NoExpediente");
            Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            Property(t => t.IdAbogado).HasColumnName("IdAbogado");
            Property(t => t.IdTipoArea).HasColumnName("IdTipoArea");
            Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
            Property(t => t.IdProcurador).HasColumnName("IdProcurador");
            Property(t => t.FechaCierre).HasColumnName("FechaCierre");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.DeudaFinal).HasColumnName("DeudaFinal");
            Property(t => t.IdTipoEstadoLast).HasColumnName("IdTipoEstadoLast");
            Property(t => t.NoAuto).HasColumnName("NoAuto");
            //this.Property(t => t.JuzgadoName).HasColumnName("Juzgado");
            Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");

            // Relationships
            HasOptional(t => t.Gnr_Abogado)
                .WithMany(t => t.Expedientes)
                .HasForeignKey(d => d.IdAbogado);
            HasRequired(t => t.Gnr_ClienteOficina)
                .WithMany(t => t.Expedientes)
                .HasForeignKey(d => d.IdClienteOficina);
            HasOptional(t => t.Gnr_Procurador)
                .WithMany(t => t.Expedientes)
                .HasForeignKey(d => d.IdProcurador);
            //HasRequired(t => t.Gnr_Valija)
            //    .WithMany(t => t.Expedientes)
            //    .HasForeignKey(d => d.IdValija);
            HasOptional(t => t.Hip_PartidoJudicial)
                .WithMany(t => t.Expedientes)
                .HasForeignKey(d => d.IdPartidoJudicial);
            HasRequired(t => t.Gnr_TipoArea)
                .WithMany(t => t.Expedientes)
                .HasForeignKey(d => d.IdTipoArea);
            HasRequired(t => t.Gnr_TipoExpediente)
                .WithMany(t => t.Expedientes)
                .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
