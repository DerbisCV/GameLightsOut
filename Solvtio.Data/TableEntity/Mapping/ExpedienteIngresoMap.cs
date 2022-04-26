using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class ExpedienteIngresoMap : IEntityTypeConfiguration<ExpedienteIngreso>
    {
        public void Configure(EntityTypeBuilder<ExpedienteIngreso> builder)
        {
            builder.HasKey(t => t.IdExpedienteIngreso);

            // Properties
            builder.Property(t => t.Usuario)
                 .IsRequired()
                 .HasMaxLength(50);

            // Table & Column Mappings
            builder.ToTable("ExpedienteIngreso");
            builder.Property(t => t.IdExpedienteIngreso).HasColumnName("IdExpedienteIngreso");
            builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            builder.Property(t => t.Fecha).HasColumnName("Fecha");
            builder.Property(t => t.Importe).HasColumnName("Importe");
            builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
            builder.Property(t => t.Usuario).HasColumnName("Usuario");
            builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Expediente)
            //  .WithMany(t => t.ExpedienteIngresoes)
            //  .HasForeignKey(d => d.IdExpediente);

        }
    }
}