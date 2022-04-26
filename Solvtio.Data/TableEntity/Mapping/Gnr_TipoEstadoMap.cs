using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
	public class Gnr_TipoEstadoMap : IEntityTypeConfiguration<Gnr_TipoEstado>
	{
		public Gnr_TipoEstadoMap()
		{
           } public void Configure(EntityTypeBuilder<Gnr_TipoEstado> builder) {
           builder.HasKey(t => t.IdTipoEstado);

            // Properties
           builder.Property(t => t.IdTipoEstado)
				.ValueGeneratedNever();

           builder.Property(t => t.Descripcion)
				.IsRequired()
				.HasMaxLength(50);

           builder.Property(t => t.Clave)
				.HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Gnr_TipoEstado");
           builder.Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
           builder.Property(t => t.Clave).HasColumnName("Clave");
           builder.Property(t => t.Inactivo).HasColumnName("Inactivo");
           builder.Property(t => t.Inicio).HasColumnName("Inicio");
           builder.Property(t => t.Fin).HasColumnName("Fin");
            //this.Property(t => t.Paralizado).HasColumnName("Paralizado");

            // Relationships
            //HasRequired(t => t.Gnr_TipoExpediente)
				//  .WithMany(t => t.Gnr_TipoEstado)
				//  .HasForeignKey(d => d.IdTipoExpediente);

		}
	}
}
