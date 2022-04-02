using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoMap : EntityTypeConfiguration<Con_ExpedienteCredito>
    {
        public Con_ExpedienteCreditoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteCredito);

            // Properties
            Property(t => t.NoCuentaPrestamo)
                .HasMaxLength(50);

            Property(t => t.NoReferencia)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Con_ExpedienteCredito");
            Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.NoCuentaPrestamo).HasColumnName("NoCuentaPrestamo");
            Property(t => t.Concepto).HasColumnName("Concepto");
            Property(t => t.NoReferencia).HasColumnName("NoReferencia");
            Property(t => t.Importe).HasColumnName("Importe");
            Property(t => t.ImporteReconocidoProvisional).HasColumnName("ImporteReconocidoProvisional");
            Property(t => t.CuantiaReconocidoDefinitivo).HasColumnName("CuantiaReconocidoDefinitivo");
            Property(t => t.ImporteIntereses).HasColumnName("ImporteIntereses");
            Property(t => t.ImportePrincipal).HasColumnName("ImportePrincipal");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.Con_ExpedienteCredito)
                .HasForeignKey(d => d.IdExpediente);

        }
    }
}
