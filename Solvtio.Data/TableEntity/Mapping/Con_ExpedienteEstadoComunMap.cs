using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoComunMap : IEntityTypeConfiguration<Con_ExpedienteEstadoComun>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteEstadoComun> builder) {
           builder.HasKey(t => t.ExpedienteEstadoId);

            // Properties
           builder.Property(t => t.ExpedienteEstadoId)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteEstadoComun");
           builder.Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
           builder.Property(t => t.ActivoProvisional).HasColumnName("ActivoProvisional");
           builder.Property(t => t.PasivoProvisional).HasColumnName("PasivoProvisional");
           builder.Property(t => t.ActivoDefinitivo).HasColumnName("ActivoDefinitivo");
           builder.Property(t => t.PasivoDefinitivo).HasColumnName("PasivoDefinitivo");
           builder.Property(t => t.FechaInformeProvisional).HasColumnName("FechaInformeProvisional");
           builder.Property(t => t.FechaInformeDefinitivo).HasColumnName("FechaInformeDefinitivo");
           builder.Property(t => t.FechaComunicarCredito).HasColumnName("FechaComunicarCredito");
            //Property(t => t.DocumentoCreditosClienteId).HasColumnName("DocumentoCreditosClienteId");
            //Property(t => t.DocumentoComunicacionCreditosId).HasColumnName("DocumentoComunicacionCreditosId");
            //Property(t => t.DocumentoInformeAdministradorId).HasColumnName("DocumentoInformeAdministradorId");
            //Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");
           builder.Property(t => t.FechaFinPlazoPresentacionCredito).HasColumnName("FechaFinPlazoPresentacionCredito");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoComun)
            //    //  .HasForeignKey(d => d.DocumentoCreditosClienteId);
            //HasOptional(t => t.ExpedienteDocumento1)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoComun1)
            //    //  .HasForeignKey(d => d.DocumentoComunicacionCreditosId);
            //HasOptional(t => t.ExpedienteDocumento2)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoComun2)
            //    //  .HasForeignKey(d => d.DocumentoInformeAdministradorId);
            //HasOptional(t => t.ExpedienteDocumento3)
            //    //  .WithMany(t => t.Con_ExpedienteEstadoComun3)
            //    //  .HasForeignKey(d => d.DocumentoAutoJuezId);
            //HasRequired(t => t.ExpedienteEstado)
                //  .WithOptional(t => t.Con_ExpedienteEstadoComun);

        }
    }
}
