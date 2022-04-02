using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoExpedienteMap : EntityTypeConfiguration<Gnr_TipoExpediente>
    {
        public Gnr_TipoExpedienteMap()
        {
            HasKey(t => t.IdTipoExpediente);

            // Properties
            Property(t => t.Abreviado)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            //// Table & Column Mappings
            ToTable("Gnr_TipoExpediente");
            //Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            //Property(t => t.Abreviado).HasColumnName("Abreviado");
            //Property(t => t.Descripcion).HasColumnName("Descripcion");
            //Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
