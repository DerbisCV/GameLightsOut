using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Neg_GestionEstadoMap : IEntityTypeConfiguration<Neg_GestionEstado>
    {
        public Neg_GestionEstadoMap()
        {
           } public void Configure(EntityTypeBuilder<Neg_GestionEstado> builder) {
           builder.HasKey(t => t.GestionEstadoId);

            // Properties
           builder.Property(t => t.Usuario)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Neg_GestionEstado");
           builder.Property(t => t.GestionEstadoId).HasColumnName("GestionEstadoId");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
           builder.Property(t => t.Observacion).HasColumnName("Observacion");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Gnr_TipoEstado)
                //  .WithMany(t => t.Neg_GestionEstado)
                //  .HasForeignKey(d => d.IdTipoEstado);
            //HasRequired(t => t.Neg_Gestion)
                //  .WithMany(t => t.Neg_GestionEstados)
                //  .HasForeignKey(d => d.IdExpediente);

        }
    }
}
