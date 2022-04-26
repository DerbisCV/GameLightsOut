using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ProcuradorPartidoJudicialMap : IEntityTypeConfiguration<ProcuradorPartidoJudicial>
    {
        public ProcuradorPartidoJudicialMap()
        {
           } public void Configure(EntityTypeBuilder<ProcuradorPartidoJudicial> builder) {
           builder.HasKey(t => t.IdProcuradorPartidoJudicial);

            // Properties
           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("ProcuradorPartidoJudicial");
           builder.Property(t => t.IdProcuradorPartidoJudicial).HasColumnName("IdProcuradorPartidoJudicial");
           builder.Property(t => t.IdProcurador).HasColumnName("IdProcurador");
           builder.Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");

            // Relationships
            //HasRequired(t => t.Procurador)
				//  .WithMany(t => t.PartidoJudicialSet)
                //  .HasForeignKey(d => d.IdProcurador);
            //HasRequired(t => t.PartidoJudicial)
                //  .WithMany(t => t.ProcuradorPartidoJudicials)
                //  .HasForeignKey(d => d.IdPartidoJudicial);

        }
    }
}
