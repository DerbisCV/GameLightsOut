using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Neg_GestionEstadoMap : EntityTypeConfiguration<Neg_GestionEstado>
    {
        public Neg_GestionEstadoMap()
        {
            // Primary Key
            HasKey(t => t.GestionEstadoId);

            // Properties
            Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Neg_GestionEstado");
            Property(t => t.GestionEstadoId).HasColumnName("GestionEstadoId");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
            Property(t => t.Observacion).HasColumnName("Observacion");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Gnr_TipoEstado)
                .WithMany(t => t.Neg_GestionEstado)
                .HasForeignKey(d => d.IdTipoEstado);
            HasRequired(t => t.Neg_Gestion)
                .WithMany(t => t.Neg_GestionEstados)
                .HasForeignKey(d => d.IdExpediente);

        }
    }
}
