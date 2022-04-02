using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class View_1Map : EntityTypeConfiguration<View_1>
    {
        public View_1Map()
        {
            // Primary Key
            HasKey(t => new { t.IdExpediente, t.IdValija, t.NoExpediente, t.Descripcion, t.IdClienteOficina, t.Nombre, t.FechaAlta, t.Expr1, t.IdTipoExpediente });

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.IdValija)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.NoExpediente)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.ReferenciaExterna)
                .HasMaxLength(50);

            Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.IdClienteOficina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Expr1)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.IdTipoExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("View_1");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdValija).HasColumnName("IdValija");
            Property(t => t.NoExpediente).HasColumnName("NoExpediente");
            Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.FechaCierre).HasColumnName("FechaCierre");
            Property(t => t.DeudaFinal).HasColumnName("DeudaFinal");
            Property(t => t.IdTipoEstadoLast).HasColumnName("IdTipoEstadoLast");
            Property(t => t.Expr1).HasColumnName("Expr1");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
        }
    }
}
