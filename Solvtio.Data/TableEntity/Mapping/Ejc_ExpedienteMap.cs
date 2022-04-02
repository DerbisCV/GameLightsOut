using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteMap : EntityTypeConfiguration<Ejc_Expediente>
    {
        public Ejc_ExpedienteMap()
        {
            // Primary Key
            HasKey(t => t.IdExpediente);

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CuentaOficina)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.CuentaNo)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable("Ejc_Expediente");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.CuentaOficina).HasColumnName("CuentaOficina");
            Property(t => t.CuentaNo).HasColumnName("CuentaNo");
            Property(t => t.Importe).HasColumnName("Importe");
            Property(t => t.IdDeudorPrincipal).HasColumnName("IdDeudorPrincipal");
            Property(t => t.IdExpedienteHip).HasColumnName("IdExpedienteHip");
            Property(t => t.IdExpedienteAlq).HasColumnName("IdExpedienteAlq");

            // Relationships
            HasOptional(t => t.Alq_Expediente)
                .WithMany(t => t.Ejc_Expediente1)
                .HasForeignKey(d => d.IdExpedienteAlq);
            HasRequired(t => t.Expediente)
                .WithOptional(t => t.Ejc_Expediente);
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Ejc_Expediente)
                .HasForeignKey(d => d.IdDeudorPrincipal);
            HasOptional(t => t.ExpedienteHipotecario)
                .WithMany(t => t.Ejc_Expediente)
                .HasForeignKey(d => d.IdExpedienteHip);

        }
    }
}
