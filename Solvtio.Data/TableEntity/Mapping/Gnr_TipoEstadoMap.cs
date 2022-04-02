using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
	public class Gnr_TipoEstadoMap : EntityTypeConfiguration<Gnr_TipoEstado>
	{
		public Gnr_TipoEstadoMap()
		{
            // Primary Key
            HasKey(t => t.IdTipoEstado);

            // Properties
            Property(t => t.IdTipoEstado)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Descripcion)
				.IsRequired()
				.HasMaxLength(50);

            Property(t => t.Clave)
				.HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_TipoEstado");
            Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            Property(t => t.Clave).HasColumnName("Clave");
            Property(t => t.Inactivo).HasColumnName("Inactivo");
            Property(t => t.Inicio).HasColumnName("Inicio");
            Property(t => t.Fin).HasColumnName("Fin");
            //this.Property(t => t.Paralizado).HasColumnName("Paralizado");

            // Relationships
            HasRequired(t => t.Gnr_TipoExpediente)
				.WithMany(t => t.Gnr_TipoEstado)
				.HasForeignKey(d => d.IdTipoExpediente);

		}
	}
}
