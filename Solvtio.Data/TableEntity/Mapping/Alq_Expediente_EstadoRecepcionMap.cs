using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_EstadoRecepcionMap : IEntityTypeConfiguration<Alq_Expediente_EstadoRecepcion>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_EstadoRecepcion> builder)
        {
            // 
           builder.HasKey(t => t.IdExpedienteEstado);

            // Properties
           builder.Property(t => t.ID)
                .ValueGeneratedOnAdd();

           builder.Property(t => t.IdExpedienteEstado)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_EstadoRecepcion");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
           builder.Property(t => t.PendienteDocumentacion).HasColumnName("PendienteDocumentacion");
           builder.Property(t => t.BurofaxFiadores).HasColumnName("BurofaxFiadores");
           builder.Property(t => t.PagosACuenta).HasColumnName("PagosACuenta");

            // Relationships
            //HasRequired(t => t.ExpedienteEstado)
            //    .WithOptional(t => t.Alq_Expediente_EstadoRecepcion);

        }
    }
}
