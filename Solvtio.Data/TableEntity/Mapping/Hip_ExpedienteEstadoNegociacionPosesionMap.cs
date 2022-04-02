using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoNegociacionPosesionMap : EntityTypeConfiguration<Hip_ExpedienteEstadoNegociacionPosesion>
    {
        public Hip_ExpedienteEstadoNegociacionPosesionMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Hip_ExpedienteEstadoNegociacionPosesion");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.DatosContacto).HasColumnName("DatosContacto");
            Property(t => t.Incidencias).HasColumnName("Incidencias");
            Property(t => t.NegociacionFinalizadaPor).HasColumnName("NegociacionFinalizadaPor");
            Property(t => t.FechaPropuestaEnviada).HasColumnName("FechaPropuestaEnviada");
            Property(t => t.FechaPropuestaAceptada).HasColumnName("FechaPropuestaAceptada");
            Property(t => t.FechaCartaPagoEnviada).HasColumnName("FechaCartaPagoEnviada");
            Property(t => t.FechaCartaPagoFirmada).HasColumnName("FechaCartaPagoFirmada");
            Property(t => t.FechaCartaPagoEnviadaAlProcurador).HasColumnName("FechaCartaPagoEnviadaAlProcurador");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Hip_ExpedienteEstadoNegociacionPosesion);

        }
    }
}
