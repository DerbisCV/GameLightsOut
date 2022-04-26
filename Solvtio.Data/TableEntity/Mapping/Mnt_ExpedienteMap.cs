using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Mnt_ExpedienteMap : IEntityTypeConfiguration<Mnt_Expediente>
    {
        public Mnt_ExpedienteMap()
        {
        }
        public void Configure(EntityTypeBuilder<Mnt_Expediente> builder)
        {
            builder.ToTable("Mnt_Expediente");
            builder.HasKey(t => t.IdExpediente);
            builder.Property(t => t.IdExpediente).ValueGeneratedNever();

            builder.Property(t => t.CuentaOficina)
                 .IsRequired()
                 .HasMaxLength(4);

            builder.Property(t => t.CuentaNo)
                 .IsRequired()
                 .HasMaxLength(10);

            // Table & Column Mappings
            
            //builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //builder.Property(t => t.CuentaOficina).HasColumnName("CuentaOficina");
            //builder.Property(t => t.CuentaNo).HasColumnName("CuentaNo");
            //builder.Property(t => t.Importe).HasColumnName("Importe");
            //builder.Property(t => t.IdDeudorPrincipal).HasColumnName("IdDeudorPrincipal");

            // Relationships
            //HasRequired(t => t.Expediente)
            //  .WithOptional(t => t.Mnt_Expediente);
            //HasRequired(t => t.Gnr_Persona)
            //  .WithMany(t => t.Mnt_Expediente)
            //  .HasForeignKey(d => d.IdDeudorPrincipal);

        }
    }
}
