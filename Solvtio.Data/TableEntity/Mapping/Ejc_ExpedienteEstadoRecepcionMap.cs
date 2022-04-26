using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoRecepcionMap : IEntityTypeConfiguration<Ejc_ExpedienteEstadoRecepcion>
    {

            public void Configure(EntityTypeBuilder<Ejc_ExpedienteEstadoRecepcion> builder) {
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Ejc_ExpedienteEstadoRecepcion");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.TituloEjecutivo).HasColumnName("TituloEjecutivo");
           builder.Property(t => t.TituloInscrito).HasColumnName("TituloInscrito");
           builder.Property(t => t.BurofaxesEnviados).HasColumnName("BurofaxesEnviados");
           builder.Property(t => t.BurofaxesFiadores).HasColumnName("BurofaxesFiadores");
           builder.Property(t => t.PagosCuenta).HasColumnName("PagosCuenta");
           builder.Property(t => t.CantidadesConsignar).HasColumnName("CantidadesConsignar");
           builder.Property(t => t.NotaSimple).HasColumnName("NotaSimple");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Ejc_ExpedienteEstadoRecepcion);

        }
    }
}
