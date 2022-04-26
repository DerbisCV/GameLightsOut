using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteMap : IEntityTypeConfiguration<Ejc_Expediente>
    {

            public void Configure(EntityTypeBuilder<Ejc_Expediente> builder) {
           builder.HasKey(t => t.IdExpediente);

            // Properties
           builder.Property(t => t.IdExpediente)
                .ValueGeneratedNever();

           builder.Property(t => t.CuentaOficina)
                .IsRequired()
                .HasMaxLength(4);

           builder.Property(t => t.CuentaNo)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
           builder.ToTable("Ejc_Expediente");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.CuentaOficina).HasColumnName("CuentaOficina");
           builder.Property(t => t.CuentaNo).HasColumnName("CuentaNo");
           builder.Property(t => t.Importe).HasColumnName("Importe");
           builder.Property(t => t.IdDeudorPrincipal).HasColumnName("IdDeudorPrincipal");
           builder.Property(t => t.IdExpedienteHip).HasColumnName("IdExpedienteHip");
           builder.Property(t => t.IdExpedienteAlq).HasColumnName("IdExpedienteAlq");

            // Relationships
            //// HasOptional(t => t.Alq_Expediente)
            //    //  .WithMany(t => t.Ejc_Expediente1)
            //    //  .HasForeignKey(d => d.IdExpedienteAlq);
            //HasRequired(t => t.Expediente)
                //  .WithOptional(t => t.Ejc_Expediente);
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.Ejc_Expediente)
                //  .HasForeignKey(d => d.IdDeudorPrincipal);
            //// HasOptional(t => t.ExpedienteHipotecario)
            //    //  .WithMany(t => t.Ejc_Expediente)
            //    //  .HasForeignKey(d => d.IdExpedienteHip);

        }
    }
}
