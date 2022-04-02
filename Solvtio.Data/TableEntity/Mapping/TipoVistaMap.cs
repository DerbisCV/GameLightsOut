using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class TipoVistaMap : EntityTypeConfiguration<TipoVista>
    {
        public TipoVistaMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoVista);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.Clasificacion)
                .HasMaxLength(50);

            Property(t => t.Grupo)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("TipoVista");
            Property(t => t.IdTipoVista).HasColumnName("IdTipoVista");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.Clasificacion).HasColumnName("Clasificacion");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            Property(t => t.Grupo).HasColumnName("Grupo");

            // Relationships
            HasRequired(t => t.Gnr_TipoExpediente)
                .WithMany(t => t.TipoVistas)
                .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
