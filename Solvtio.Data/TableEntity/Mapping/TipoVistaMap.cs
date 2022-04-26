using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class TipoVistaMap : IEntityTypeConfiguration<TipoVista>
    {
        public TipoVistaMap()
        {
           } public void Configure(EntityTypeBuilder<TipoVista> builder) {
           builder.HasKey(t => t.IdTipoVista);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(250);

           builder.Property(t => t.Clasificacion)
                .HasMaxLength(50);

           builder.Property(t => t.Grupo)
                .HasMaxLength(100);

            // Table & Column Mappings
           builder.ToTable("TipoVista");
           builder.Property(t => t.IdTipoVista).HasColumnName("IdTipoVista");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.Clasificacion).HasColumnName("Clasificacion");
           builder.Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");
           builder.Property(t => t.Grupo).HasColumnName("Grupo");

            // Relationships
            //HasRequired(t => t.Gnr_TipoExpediente)
                //  .WithMany(t => t.TipoVistas)
                //  .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
