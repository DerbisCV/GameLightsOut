using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class View_5Map : EntityTypeConfiguration<View_5>
    {
        public View_5Map()
        {
            // Primary Key
            HasKey(t => new { t.IdExpediente, t.NoExpediente, t.IdTipoExpediente, t.IdClienteOficina, t.Nombre, t.Descripcion, t.IdTipoEstado });

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.NoExpediente)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

            Property(t => t.IdTipoExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.IdClienteOficina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.IdTipoEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("View_5");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.NoExpediente).HasColumnName("NoExpediente");
            Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.FechaCierre).HasColumnName("FechaCierre");
            Property(t => t.DeudaFinal).HasColumnName("DeudaFinal");
            Property(t => t.IdTipoEstadoLast).HasColumnName("IdTipoEstadoLast");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
        }
    }
}
