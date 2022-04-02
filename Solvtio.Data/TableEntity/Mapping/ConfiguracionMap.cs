using Solvtio.Data;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ConfiguracionMap : EntityTypeConfiguration<Configuracion>
    {
        public ConfiguracionMap()
        {
            // Primary Key
            HasKey(t => t.Clave);

            // Properties
            Property(t => t.Clave)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Valor)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Configuracion");
            Property(t => t.Clave).HasColumnName("Clave");
            Property(t => t.Valor).HasColumnName("Valor");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
        }
    }
}
