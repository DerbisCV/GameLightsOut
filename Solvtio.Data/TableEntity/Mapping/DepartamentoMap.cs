using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class DepartamentoMap : IEntityTypeConfiguration<Departamento>
    {

            public void Configure(EntityTypeBuilder<Departamento> builder) {
           builder.HasKey(t => t.IdDepartamento);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(500);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Departamento");
           builder.Property(t => t.IdDepartamento).HasColumnName("IdDepartamento");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.Activo).HasColumnName("Activo");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
        }
    }
}
