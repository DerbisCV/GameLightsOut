using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoNegociacionPosesionMap : IEntityTypeConfiguration<Hip_ExpedienteEstadoNegociacionPosesion>
    {
        public Hip_ExpedienteEstadoNegociacionPosesionMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_ExpedienteEstadoNegociacionPosesion> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoNegociacionPosesion");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.DatosContacto).HasColumnName("DatosContacto");
           builder.Property(t => t.Incidencias).HasColumnName("Incidencias");
           builder.Property(t => t.NegociacionFinalizadaPor).HasColumnName("NegociacionFinalizadaPor");
           builder.Property(t => t.FechaPropuestaEnviada).HasColumnName("FechaPropuestaEnviada");
           builder.Property(t => t.FechaPropuestaAceptada).HasColumnName("FechaPropuestaAceptada");
           builder.Property(t => t.FechaCartaPagoEnviada).HasColumnName("FechaCartaPagoEnviada");
           builder.Property(t => t.FechaCartaPagoFirmada).HasColumnName("FechaCartaPagoFirmada");
           builder.Property(t => t.FechaCartaPagoEnviadaAlProcurador).HasColumnName("FechaCartaPagoEnviadaAlProcurador");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Hip_ExpedienteEstadoNegociacionPosesion);

        }
    }
}
