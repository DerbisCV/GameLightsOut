using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Mnt_ExpedienteMap : EntityTypeConfiguration<Mnt_Expediente>
    {
        public Mnt_ExpedienteMap()
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
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Mnt_Expediente");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.CuentaOficina).HasColumnName("CuentaOficina");
            Property(t => t.CuentaNo).HasColumnName("CuentaNo");
            Property(t => t.Importe).HasColumnName("Importe");
            Property(t => t.IdDeudorPrincipal).HasColumnName("IdDeudorPrincipal");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithOptional(t => t.Mnt_Expediente);
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Mnt_Expediente)
                .HasForeignKey(d => d.IdDeudorPrincipal);

        }
    }
}
