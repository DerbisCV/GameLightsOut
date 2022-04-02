using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class DepartamentoMap : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoMap()
        {
            // Primary Key
            HasKey(t => t.IdDepartamento);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Departamento");
            Property(t => t.IdDepartamento).HasColumnName("IdDepartamento");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.Activo).HasColumnName("Activo");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
        }
    }
}
