using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_ProcuradorMap : IEntityTypeConfiguration<Gnr_Procurador>
    {
        public Gnr_ProcuradorMap()
        {
           } public void Configure(EntityTypeBuilder<Gnr_Procurador> builder) {
           builder.HasKey(t => t.IdPersona);

            // Properties
           builder.Property(t => t.IdPersona)
                .ValueGeneratedNever();

           builder.Property(t => t.EnvioDemandas)
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("Gnr_Procurador");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.EnvioDemandas).HasColumnName("EnvioDemandas");
           builder.Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");

            // Relationships
            //HasRequired(t => t.Gnr_Persona)
                //  .WithOptional(t => t.Gnr_Procurador);

        }
    }
}
