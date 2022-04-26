using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoMap : IEntityTypeConfiguration<Con_ExpedienteCredito>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteCredito> builder) {
           builder.HasKey(t => t.IdExpedienteCredito);

            // Properties
           builder.Property(t => t.NoCuentaPrestamo)
                .HasMaxLength(50);

           builder.Property(t => t.NoReferencia)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteCredito");
           builder.Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
           builder.Property(t => t.Concepto).HasColumnName("Concepto");
           builder.Property(t => t.NoReferencia).HasColumnName("NoReferencia");
           builder.Property(t => t.Importe).HasColumnName("Importe");
           builder.Property(t => t.ImporteReconocidoProvisional).HasColumnName("ImporteReconocidoProvisional");
           builder.Property(t => t.CuantiaReconocidoDefinitivo).HasColumnName("CuantiaReconocidoDefinitivo");
           builder.Property(t => t.ImporteIntereses).HasColumnName("ImporteIntereses");
           builder.Property(t => t.ImportePrincipal).HasColumnName("ImportePrincipal");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.Con_ExpedienteCredito)
                //  .HasForeignKey(d => d.IdExpediente);

        }
    }
}
