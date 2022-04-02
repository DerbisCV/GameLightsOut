using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteIngresoMap : EntityTypeConfiguration<ExpedienteIngreso>
    {
        public ExpedienteIngresoMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteIngreso);

            // Properties
            Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ExpedienteIngreso");
            Property(t => t.IdExpedienteIngreso).HasColumnName("IdExpedienteIngreso");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.Importe).HasColumnName("Importe");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithMany(t => t.ExpedienteIngresoes)
                .HasForeignKey(d => d.IdExpediente);

        }
    }
}
