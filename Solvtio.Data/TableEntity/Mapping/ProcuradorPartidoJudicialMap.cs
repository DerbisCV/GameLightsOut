using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ProcuradorPartidoJudicialMap : EntityTypeConfiguration<ProcuradorPartidoJudicial>
    {
        public ProcuradorPartidoJudicialMap()
        {
            // Primary Key
            HasKey(t => t.IdProcuradorPartidoJudicial);

            // Properties
            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ProcuradorPartidoJudicial");
            Property(t => t.IdProcuradorPartidoJudicial).HasColumnName("IdProcuradorPartidoJudicial");
            Property(t => t.IdProcurador).HasColumnName("IdProcurador");
            Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.Usuario).HasColumnName("Usuario");

            // Relationships
            HasRequired(t => t.Procurador)
				.WithMany(t => t.PartidoJudicialSet)
                .HasForeignKey(d => d.IdProcurador);
            HasRequired(t => t.PartidoJudicial)
                .WithMany(t => t.ProcuradorPartidoJudicials)
                .HasForeignKey(d => d.IdPartidoJudicial);

        }
    }
}
