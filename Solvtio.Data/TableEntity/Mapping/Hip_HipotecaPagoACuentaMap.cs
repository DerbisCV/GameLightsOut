using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_HipotecaPagoACuentaMap : IEntityTypeConfiguration<Hip_HipotecaPagoACuenta>
    {
        public Hip_HipotecaPagoACuentaMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_HipotecaPagoACuenta> builder) {
           builder.HasKey(t => t.IdPagoACuenta);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Hip_HipotecaPagoACuenta");
           builder.Property(t => t.IdPagoACuenta).HasColumnName("IdPagoACuenta");
           builder.Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.Importe).HasColumnName("Importe");

            // Relationships
            //HasRequired(t => t.Hip_Hipoteca)
                //  .WithMany(t => t.Hip_HipotecaPagoACuenta)
                //  .HasForeignKey(d => d.IdHipoteca);

        }
    }
}
