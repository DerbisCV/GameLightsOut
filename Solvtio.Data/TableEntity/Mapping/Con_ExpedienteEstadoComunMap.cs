using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteEstadoComunMap : EntityTypeConfiguration<Con_ExpedienteEstadoComun>
    {
        public Con_ExpedienteEstadoComunMap()
        {
            // Primary Key
            HasKey(t => t.ExpedienteEstadoId);

            // Properties
            Property(t => t.ExpedienteEstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Con_ExpedienteEstadoComun");
            Property(t => t.ExpedienteEstadoId).HasColumnName("ExpedienteEstadoId");
            Property(t => t.ActivoProvisional).HasColumnName("ActivoProvisional");
            Property(t => t.PasivoProvisional).HasColumnName("PasivoProvisional");
            Property(t => t.ActivoDefinitivo).HasColumnName("ActivoDefinitivo");
            Property(t => t.PasivoDefinitivo).HasColumnName("PasivoDefinitivo");
            Property(t => t.FechaInformeProvisional).HasColumnName("FechaInformeProvisional");
            Property(t => t.FechaInformeDefinitivo).HasColumnName("FechaInformeDefinitivo");
            Property(t => t.FechaComunicarCredito).HasColumnName("FechaComunicarCredito");
            //Property(t => t.DocumentoCreditosClienteId).HasColumnName("DocumentoCreditosClienteId");
            //Property(t => t.DocumentoComunicacionCreditosId).HasColumnName("DocumentoComunicacionCreditosId");
            //Property(t => t.DocumentoInformeAdministradorId).HasColumnName("DocumentoInformeAdministradorId");
            //Property(t => t.DocumentoAutoJuezId).HasColumnName("DocumentoAutoJuezId");
            Property(t => t.FechaFinPlazoPresentacionCredito).HasColumnName("FechaFinPlazoPresentacionCredito");

            // Relationships
            //HasOptional(t => t.ExpedienteDocumento)
            //    .WithMany(t => t.Con_ExpedienteEstadoComun)
            //    .HasForeignKey(d => d.DocumentoCreditosClienteId);
            //HasOptional(t => t.ExpedienteDocumento1)
            //    .WithMany(t => t.Con_ExpedienteEstadoComun1)
            //    .HasForeignKey(d => d.DocumentoComunicacionCreditosId);
            //HasOptional(t => t.ExpedienteDocumento2)
            //    .WithMany(t => t.Con_ExpedienteEstadoComun2)
            //    .HasForeignKey(d => d.DocumentoInformeAdministradorId);
            //HasOptional(t => t.ExpedienteDocumento3)
            //    .WithMany(t => t.Con_ExpedienteEstadoComun3)
            //    .HasForeignKey(d => d.DocumentoAutoJuezId);
            HasRequired(t => t.ExpedienteEstado)
                .WithOptional(t => t.Con_ExpedienteEstadoComun);

        }
    }
}
