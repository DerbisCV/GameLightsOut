using Solvtio.Data;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ConfiguracionMap : IEntityTypeConfiguration<Configuracion>
    {
        public void Configure(EntityTypeBuilder<Configuracion> builder)
        {
            // 
           builder.HasKey(t => t.Clave);

            // Properties
           builder.Property(t => t.Clave)
                .IsRequired()
                .HasMaxLength(50);

           builder.Property(t => t.Valor)
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("Configuracion");
           builder.Property(t => t.Clave).HasColumnName("Clave");
           builder.Property(t => t.Valor).HasColumnName("Valor");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
        }
    }
}
