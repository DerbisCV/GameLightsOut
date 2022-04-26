using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class PropuestaComercialMap : IEntityTypeConfiguration<PropuestaComercial>
    {
        public PropuestaComercialMap()
        {
           } public void Configure(EntityTypeBuilder<PropuestaComercial> builder) {
           builder.HasKey(t => t.IdPropuestaComercial);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired();

           builder.Property(t => t.PorcientoVariableDescripcion)
                .HasMaxLength(250);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("PropuestaComercial");
           builder.Property(t => t.IdPropuestaComercial).HasColumnName("IdPropuestaComercial");
           builder.Property(t => t.IdCliente).HasColumnName("IdCliente");
           builder.Property(t => t.IdDepartamento).HasColumnName("IdDepartamento");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.ImporteFijo).HasColumnName("ImporteFijo");
           builder.Property(t => t.PeriodicidadId).HasColumnName("PeriodicidadId");
           builder.Property(t => t.PorcientoVariable).HasColumnName("PorcientoVariable");
           builder.Property(t => t.PorcientoVariableDescripcion).HasColumnName("PorcientoVariableDescripcion");
           builder.Property(t => t.Aceptada).HasColumnName("Aceptada");
           builder.Property(t => t.DocumentoPropuestaComercialId).HasColumnName("DocumentoPropuestaComercialId");
           builder.Property(t => t.IdFormaPago).HasColumnName("IdFormaPago");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Departamento)
                //  .WithMany(t => t.PropuestaComercialSet)
                //  .HasForeignKey(d => d.IdDepartamento);
            //// HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.PropuestaComercials)
            //    //  .HasForeignKey(d => d.DocumentoPropuestaComercialId);
            //HasRequired(t => t.Gnr_Cliente)
                //  .WithMany(t => t.PropuestaComercials)
                //  .HasForeignKey(d => d.IdCliente);
            //HasRequired(t => t.Hip_TipoPeriodicidad)
                //  .WithMany(t => t.PropuestaComercials)
                //  .HasForeignKey(d => d.PeriodicidadId);

        }
    }
}
