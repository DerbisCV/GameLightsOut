using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class ExpedienteDocumentoMap : IEntityTypeConfiguration<ExpedienteDocumento>
    //{
    //    public ExpedienteDocumentoMap()
    //    {
    //        public void Configure(EntityTypeBuilder<object> builder) {
    //       builder.HasKey(t => t.IdDocumento);

    //        // Properties
    //       builder.Property(t => t.Ruta)
    //            .HasMaxLength(500);

    //       builder.Property(t => t.DocumentoNombre)
    //            .IsRequired()
    //            .HasMaxLength(250);

    //       builder.Property(t => t.Descripcion)
    //            .IsRequired()
    //            .HasMaxLength(500);

    //       builder.Property(t => t.Usuario)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //        // Table & Column Mappings
    //       builder.ToTable("ExpedienteDocumento");
    //       builder.Property(t => t.IdDocumento).HasColumnName("IdDocumento");
    //       builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //       builder.Property(t => t.IdTipoDocumento).HasColumnName("IdTipoDocumento");
    //       builder.Property(t => t.Ruta).HasColumnName("Ruta");
    //       builder.Property(t => t.DocumentoNombre).HasColumnName("DocumentoNombre");
    //       builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
    //       builder.Property(t => t.Usuario).HasColumnName("Usuario");
    //       builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
    //       builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
    //       builder.Property(t => t.IdReferencia).HasColumnName("IdReferencia");

    //        // Relationships
    //        //HasRequired(t => t.Expediente)
    //            //  .WithMany(t => t.ExpedienteDocumentoes)
    //            //  .HasForeignKey(d => d.IdExpediente);
    //        //HasRequired(t => t.Gnr_TipoExpedienteDocumento)
    //            //  .WithMany(t => t.ExpedienteDocumentoes)
    //            //  .HasForeignKey(d => d.IdTipoDocumento);

    //    }
    //}
}
