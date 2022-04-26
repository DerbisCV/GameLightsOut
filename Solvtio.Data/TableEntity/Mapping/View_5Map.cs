using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class View_5Map : IEntityTypeConfiguration<View_5>
    //{
    //    public View_5Map()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.IdExpediente, t.NoExpediente, t.IdTipoExpediente, t.IdClienteOficina, t.Nombre, t.Descripcion, t.IdTipoEstado });

    //        // Properties
    //       builder.Property(t => t.IdExpediente)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.NoExpediente)
    //            .IsRequired()
    //            .HasMaxLength(20);

    //       builder.Property(t => t.ReferenciaExterna)
    //            .HasMaxLength(50);

    //       builder.Property(t => t.IdTipoExpediente)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.IdClienteOficina)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.Nombre)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //       builder.Property(t => t.Descripcion)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //       builder.Property(t => t.IdTipoEstado)
    //            .ValueGeneratedNever();

    //        // Table & Column Mappings
    //       builder.ToTable("View_5");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.NoExpediente).HasColumnName("NoExpediente");
    //       builder.Property(t => t.ReferenciaExterna).HasColumnName("ReferenciaExterna");
    //       builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
    //       builder.Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
    //       builder.Property(t => t.Nombre).HasColumnName("Nombre");
    //       builder.Property(t => t.FechaCierre).HasColumnName("FechaCierre");
    //       builder.Property(t => t.DeudaFinal).HasColumnName("DeudaFinal");
    //       builder.Property(t => t.IdTipoEstadoLast).HasColumnName("IdTipoEstadoLast");
    //       builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
    //       builder.Property(t => t.IdTipoEstado).HasColumnName("IdTipoEstado");
    //    }
    //}
}
