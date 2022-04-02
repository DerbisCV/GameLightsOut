using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_PlantillasDocMap : EntityTypeConfiguration<Gnr_PlantillasDoc>
    {
        public Gnr_PlantillasDocMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Descripcion)
                .HasMaxLength(50);

            Property(t => t.Clave)
                .HasMaxLength(50);

            Property(t => t.Detalle)
                .HasMaxLength(2500);

            Property(t => t.VistaBD)
                .HasMaxLength(100);

            Property(t => t.DelimitadorCampos)
                .HasMaxLength(5);

            Property(t => t.ListaCamposEnPlantilla)
                .HasMaxLength(1000);

            Property(t => t.ListaCamposVistaBD)
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("Gnr_PlantillasDoc");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Clave).HasColumnName("Clave");
            Property(t => t.Detalle).HasColumnName("Detalle");
            Property(t => t.IdTipoFormato).HasColumnName("IdTipoFormato");
            Property(t => t.VistaBD).HasColumnName("VistaBD");
            Property(t => t.Documento).HasColumnName("Documento");
            Property(t => t.DelimitadorCampos).HasColumnName("DelimitadorCampos");
            Property(t => t.ListaCamposEnPlantilla).HasColumnName("ListaCamposEnPlantilla");
            Property(t => t.ListaCamposVistaBD).HasColumnName("ListaCamposVistaBD");
        }
    }
}
