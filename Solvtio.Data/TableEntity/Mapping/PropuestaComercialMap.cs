using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class PropuestaComercialMap : EntityTypeConfiguration<PropuestaComercial>
    {
        public PropuestaComercialMap()
        {
            // Primary Key
            HasKey(t => t.IdPropuestaComercial);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired();

            Property(t => t.PorcientoVariableDescripcion)
                .HasMaxLength(250);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("PropuestaComercial");
            Property(t => t.IdPropuestaComercial).HasColumnName("IdPropuestaComercial");
            Property(t => t.IdCliente).HasColumnName("IdCliente");
            Property(t => t.IdDepartamento).HasColumnName("IdDepartamento");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.ImporteFijo).HasColumnName("ImporteFijo");
            Property(t => t.PeriodicidadId).HasColumnName("PeriodicidadId");
            Property(t => t.PorcientoVariable).HasColumnName("PorcientoVariable");
            Property(t => t.PorcientoVariableDescripcion).HasColumnName("PorcientoVariableDescripcion");
            Property(t => t.Aceptada).HasColumnName("Aceptada");
            Property(t => t.DocumentoPropuestaComercialId).HasColumnName("DocumentoPropuestaComercialId");
            Property(t => t.IdFormaPago).HasColumnName("IdFormaPago");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Departamento)
                .WithMany(t => t.PropuestaComercialSet)
                .HasForeignKey(d => d.IdDepartamento);
            HasOptional(t => t.ExpedienteDocumento)
                .WithMany(t => t.PropuestaComercials)
                .HasForeignKey(d => d.DocumentoPropuestaComercialId);
            HasRequired(t => t.Gnr_Cliente)
                .WithMany(t => t.PropuestaComercials)
                .HasForeignKey(d => d.IdCliente);
            HasRequired(t => t.Hip_TipoPeriodicidad)
                .WithMany(t => t.PropuestaComercials)
                .HasForeignKey(d => d.PeriodicidadId);

        }
    }
}
