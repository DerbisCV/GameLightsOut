using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoTelefonoMap : EntityTypeConfiguration<Gnr_TipoTelefono>
    {
        public Gnr_TipoTelefonoMap()
        {
            // Primary Key
            HasKey(t => t.IdTipoTelefono);

            // Properties
            Property(t => t.Abreviacion)
                .HasMaxLength(5);

            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable("Gnr_TipoTelefono");
            Property(t => t.IdTipoTelefono).HasColumnName("IdTipoTelefono");
            Property(t => t.Abreviacion).HasColumnName("Abreviacion");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Activo).HasColumnName("Activo");
        }
    }
}
