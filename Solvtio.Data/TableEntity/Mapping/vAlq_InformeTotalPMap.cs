using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class vAlq_InformeTotalPMap : EntityTypeConfiguration<vAlq_InformeTotalP>
    {
        public vAlq_InformeTotalPMap()
        {
            // Primary Key
            HasKey(t => new { t.IdExpediente, t.NoExpediente, t.Arrendador, t.TipoPropietario, t.NAU, t.FechaAlta, t.Estado, t.NIF });

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.NoExpediente)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.ReferenciaExternaMSGI)
                .HasMaxLength(50);

            Property(t => t.ReferenciaExternaMACRO)
                .HasMaxLength(50);

            Property(t => t.Arrendador)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.TipoPropietario)
                .IsRequired()
                .HasMaxLength(16);

            Property(t => t.NAU)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Estado)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.NIF)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.NombreDeudor)
                .HasMaxLength(801);

            Property(t => t.Procurador)
                .HasMaxLength(801);

            // Table & Column Mappings
            ToTable("vAlq_InformeTotalP");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.NoExpediente).HasColumnName("NoExpediente");
            Property(t => t.ReferenciaExternaMSGI).HasColumnName("ReferenciaExternaMSGI");
            Property(t => t.ReferenciaExternaMACRO).HasColumnName("ReferenciaExternaMACRO");
            Property(t => t.Arrendador).HasColumnName("Arrendador");
            Property(t => t.TipoPropietario).HasColumnName("TipoPropietario");
            Property(t => t.NAU).HasColumnName("NAU");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.DeudaInicial).HasColumnName("DeudaInicial");
            Property(t => t.DeudaPendiente).HasColumnName("DeudaPendiente");
            Property(t => t.Estado).HasColumnName("Estado");
            Property(t => t.FechaEstado).HasColumnName("FechaEstado");
            Property(t => t.NIF).HasColumnName("NIF");
            Property(t => t.NombreDeudor).HasColumnName("NombreDeudor");
            Property(t => t.DomicilioNotificacion).HasColumnName("DomicilioNotificacion");
            Property(t => t.IdProcurador).HasColumnName("IdProcurador");
            Property(t => t.Procurador).HasColumnName("Procurador");
        }
    }
}
