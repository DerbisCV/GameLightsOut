using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_PlantillasDocMap : IEntityTypeConfiguration<Gnr_PlantillasDoc>
    {
     
            public void Configure(EntityTypeBuilder<Gnr_PlantillasDoc> builder) {
           builder.HasKey(t => t.ID);

            // Properties
           builder.Property(t => t.Descripcion)
                .HasMaxLength(50);

           builder.Property(t => t.Clave)
                .HasMaxLength(50);

           builder.Property(t => t.Detalle)
                .HasMaxLength(2500);

           builder.Property(t => t.VistaBD)
                .HasMaxLength(100);

           builder.Property(t => t.DelimitadorCampos)
                .HasMaxLength(5);

           builder.Property(t => t.ListaCamposEnPlantilla)
                .HasMaxLength(1000);

           builder.Property(t => t.ListaCamposVistaBD)
                .HasMaxLength(1000);

            // Table & Column Mappings
           builder.ToTable("Gnr_PlantillasDoc");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Clave).HasColumnName("Clave");
           builder.Property(t => t.Detalle).HasColumnName("Detalle");
           builder.Property(t => t.IdTipoFormato).HasColumnName("IdTipoFormato");
           builder.Property(t => t.VistaBD).HasColumnName("VistaBD");
           builder.Property(t => t.Documento).HasColumnName("Documento");
           builder.Property(t => t.DelimitadorCampos).HasColumnName("DelimitadorCampos");
           builder.Property(t => t.ListaCamposEnPlantilla).HasColumnName("ListaCamposEnPlantilla");
           builder.Property(t => t.ListaCamposVistaBD).HasColumnName("ListaCamposVistaBD");
        }
    }
}
