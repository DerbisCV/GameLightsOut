using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLastMap : EntityTypeConfiguration<vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLast>
    {
        public vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLastMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Observaciones)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLast");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IDestado).HasColumnName("IDestado");
            Property(t => t.Fecha).HasColumnName("Fecha");
            Property(t => t.IDtipo).HasColumnName("IDtipo");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
        }
    }
}
