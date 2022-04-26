using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoTramitaJuzgado_ActuacionesMap : IEntityTypeConfiguration<Alq_Expediente_EstadoTramitaJuzgado_Actuacion>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> builder)
        {
            // 
           builder.HasKey(t => t.ID);

            // Properties
           builder.Property(t => t.Observaciones)
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_EstadoTramitaJuzgado_Actuaciones");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.IDestado).HasColumnName("IDestado");
           builder.Property(t => t.Fecha).HasColumnName("Fecha");
           builder.Property(t => t.IDtipo).HasColumnName("IDtipo");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");

            // Relationships
            //HasOptional(t => t.Alq_Expediente_EstadoTramitaJuzgado)
            //    .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado_Actuaciones)
            //    .HasForeignKey(d => d.IDestado);
            //HasOptional(t => t.Gnr_ListasValores_Valores)
            //    .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado_Actuaciones)
            //    .HasForeignKey(d => d.IDtipo);

        }
    }
}
