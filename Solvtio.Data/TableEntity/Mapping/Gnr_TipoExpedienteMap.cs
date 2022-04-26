using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_TipoExpedienteMap : IEntityTypeConfiguration<Gnr_TipoExpediente>
    {
        public void Configure(EntityTypeBuilder<Gnr_TipoExpediente> builder)
        {
           builder.HasKey(t => t.IdTipoExpediente);

            // Properties
           builder.Property(t => t.Abreviado)
                .IsRequired()
                .HasMaxLength(50);

           builder.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            //// Table & Column Mappings
           builder.ToTable("Gnr_TipoExpediente");
            //Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
            //Property(t => t.Abreviado).HasColumnName("Abreviado");
            //Property(t => t.Descripcion).HasColumnName("Descripcion");
            //Property(t => t.Activo).HasColumnName("Activo");
        }

  
    }
}
