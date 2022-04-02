using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Ejc_ExpedienteEstadoRecepcionMap : EntityTypeConfiguration<Ejc_ExpedienteEstadoRecepcion>
    {
        public Ejc_ExpedienteEstadoRecepcionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Ejc_ExpedienteEstadoRecepcion");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.TituloEjecutivo).HasColumnName("TituloEjecutivo");
            Property(t => t.TituloInscrito).HasColumnName("TituloInscrito");
            Property(t => t.BurofaxesEnviados).HasColumnName("BurofaxesEnviados");
            Property(t => t.BurofaxesFiadores).HasColumnName("BurofaxesFiadores");
            Property(t => t.PagosCuenta).HasColumnName("PagosCuenta");
            Property(t => t.CantidadesConsignar).HasColumnName("CantidadesConsignar");
            Property(t => t.NotaSimple).HasColumnName("NotaSimple");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Ejc_ExpedienteEstadoRecepcion);

        }
    }
}
