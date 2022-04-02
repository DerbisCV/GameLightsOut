using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoTramitaJuzgado_ActuacionesMap : EntityTypeConfiguration<Alq_Expediente_EstadoTramitaJuzgado_Actuacion>
    {
        public Alq_Expediente_EstadoTramitaJuzgado_ActuacionesMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Observaciones)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Alq_Expediente_EstadoTramitaJuzgado_Actuaciones");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IDestado).HasColumnName("IDestado");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.IDtipo).HasColumnName("IDtipo");
            Property(t => t.Observaciones).HasColumnName("Observaciones");

            // Relationships
            HasOptional(t => t.Alq_Expediente_EstadoTramitaJuzgado)
                .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado_Actuaciones)
                .HasForeignKey(d => d.IDestado);
            HasOptional(t => t.Gnr_ListasValores_Valores)
                .WithMany(t => t.Alq_Expediente_EstadoTramitaJuzgado_Actuaciones)
                .HasForeignKey(d => d.IDtipo);

        }
    }
}
