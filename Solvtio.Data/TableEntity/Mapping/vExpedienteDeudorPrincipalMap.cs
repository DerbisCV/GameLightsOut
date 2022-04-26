using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class vExpedienteDeudorPrincipalMap : IEntityTypeConfiguration<vExpedienteDeudorPrincipal>
    //{
    //    public vExpedienteDeudorPrincipalMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => new { t.IdExpediente, t.IdTipoDeudor });

    //        // Properties
    //       builder.Property(t => t.IdExpediente)
    //            .ValueGeneratedNever();

    //       builder.Property(t => t.IdTipoDeudor)
    //            .ValueGeneratedNever();

    //        // Table & Column Mappings
    //       builder.ToTable("vExpedienteDeudorPrincipal");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.IdTipoDeudor).HasColumnName("IdTipoDeudor");
    //       builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
    //    }
    //}
}
