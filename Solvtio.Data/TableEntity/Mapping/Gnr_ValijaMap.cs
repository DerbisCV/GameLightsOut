using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class Gnr_ValijaMap : IEntityTypeConfiguration<Gnr_Valija>
    //{
    //    public Gnr_ValijaMap()
    //    {
    //       } public void Configure(EntityTypeBuilder<Gnr_Valija> builder) {
    //       builder.HasKey(t => t.IdValija);

    //        // Properties
    //       builder.Property(t => t.Referencia)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //       builder.Property(t => t.Usuario)
    //            .HasMaxLength(50);

    //        // Table & Column Mappings
    //       builder.ToTable("Gnr_Valija");
    //       builder.Property(t => t.IdValija).HasColumnName("IdValija");
    //       builder.Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
    //       builder.Property(t => t.FechaRecepcion).HasColumnName("FechaRecepcion");
    //       builder.Property(t => t.Referencia).HasColumnName("Referencia");
    //       builder.Property(t => t.Usuario).HasColumnName("Usuario");
    //       builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
    //       builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");

    //        // Relationships
    //        //HasRequired(t => t.Gnr_ClienteOficina)
    //            //  .WithMany(t => t.Gnr_Valija)
    //            //  .HasForeignKey(d => d.IdClienteOficina);
    //        //HasRequired(t => t.Gnr_TipoExpediente)
    //            //  .WithMany(t => t.Gnr_Valija)
    //            //  .HasForeignKey(d => d.IdTipoExpediente);

    //    }
    //}
}
