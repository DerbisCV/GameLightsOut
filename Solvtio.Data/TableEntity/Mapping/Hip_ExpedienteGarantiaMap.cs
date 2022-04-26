using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteGarantiaMap : IEntityTypeConfiguration<Hip_ExpedienteGarantia>
    {
        public Hip_ExpedienteGarantiaMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_ExpedienteGarantia> builder) {
           builder.HasKey(t => t.IdExpedienteGarantia);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteGarantia");
           builder.Property(t => t.IdExpedienteGarantia).HasColumnName("IdExpedienteGarantia");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");

            // Relationships
            //HasRequired(t => t.Hip_Expediente)
                //  .WithMany(t => t.Hip_ExpedienteGarantia)
                //  .HasForeignKey(d => d.IdExpediente);

        }
    }
}
