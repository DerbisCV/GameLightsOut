using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteEstadoRecepcionMap : IEntityTypeConfiguration<HipExpedienteEstadoRecepcion>
    {
        public Hip_ExpedienteEstadoRecepcionMap()
        {
           } public void Configure(EntityTypeBuilder<HipExpedienteEstadoRecepcion> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Hip_ExpedienteEstadoRecepcion");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("ExpedienteEstadoId");
            //Property(t => t.TituloEjecutivo).HasColumnName("TituloEjecutivo");
            //Property(t => t.TituloInscrito).HasColumnName("TituloInscrito");
            //Property(t => t.RevisionCargas).HasColumnName("RevisionCargas");
            //Property(t => t.BurofaxesEnviados).HasColumnName("BurofaxesEnviados");
            //Property(t => t.BurofaxesFiadores).HasColumnName("BurofaxesFiadores");
            //Property(t => t.PagosCuenta).HasColumnName("PagosCuenta");
            //Property(t => t.CantidadesConsignar).HasColumnName("CantidadesConsignar");
            //Property(t => t.NotaSimple).HasColumnName("NotaSimple");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Hip_ExpedienteEstadoRecepcion);

        }
    }
}
