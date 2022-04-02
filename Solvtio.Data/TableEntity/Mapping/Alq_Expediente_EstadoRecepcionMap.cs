using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoRecepcionMap : EntityTypeConfiguration<Alq_Expediente_EstadoRecepcion>
    {
        public Alq_Expediente_EstadoRecepcionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteEstado);

            // Properties
            Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.IdExpedienteEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Alq_Expediente_EstadoRecepcion");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
            Property(t => t.PendienteDocumentacion).HasColumnName("PendienteDocumentacion");
            Property(t => t.BurofaxFiadores).HasColumnName("BurofaxFiadores");
            Property(t => t.PagosACuenta).HasColumnName("PagosACuenta");

            // Relationships
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Alq_Expediente_EstadoRecepcion);

        }
    }
}
