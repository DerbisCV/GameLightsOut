using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_HipotecaPagoACuentaMap : EntityTypeConfiguration<Hip_HipotecaPagoACuenta>
    {
        public Hip_HipotecaPagoACuentaMap()
        {
            // Primary Key
            HasKey(t => t.IdPagoACuenta);

            // Properties
            // Table & Column Mappings
            ToTable("Hip_HipotecaPagoACuenta");
            Property(t => t.IdPagoACuenta).HasColumnName("IdPagoACuenta");
            Property(t => t.IdHipoteca).HasColumnName("IdHipoteca");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.Importe).HasColumnName("Importe");

            // Relationships
            HasRequired(t => t.Hip_Hipoteca)
                .WithMany(t => t.Hip_HipotecaPagoACuenta)
                .HasForeignKey(d => d.IdHipoteca);

        }
    }
}
