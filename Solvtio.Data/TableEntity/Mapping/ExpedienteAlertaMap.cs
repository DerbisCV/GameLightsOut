using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ExpedienteAlertaMap : EntityTypeConfiguration<ExpedienteAlerta>
    {
        public ExpedienteAlertaMap()
        {
            // Primary Key
            HasKey(t => t.IdAlerta);

            // Properties
            Property(t => t.Descripcion)
                .IsRequired();

            // Table & Column Mappings
            ToTable("ExpedienteAlerta");
            Property(t => t.IdAlerta).HasColumnName("IdAlerta");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdTipoAlerta).HasColumnName("IdTipoAlerta");
            Property(t => t.FechaAviso).HasColumnName("FechaAviso");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.IdDestinatario).HasColumnName("IdDestinatario");
            Property(t => t.IdSupervidor).HasColumnName("IdSupervidor");
            Property(t => t.Activo).HasColumnName("Activo");
            Property(t => t.FechaActivacion).HasColumnName("FechaActivacion");
            Property(t => t.FechaDesactivacion).HasColumnName("FechaDesactivacion");
            Property(t => t.FechaCorreoEnviado).HasColumnName("FechaCorreoEnviado");
            Property(t => t.CC).HasColumnName("CC");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.AlertaDestinatario)
                .WithMany(t => t.ExpedienteAlertas)
                .HasForeignKey(d => d.IdDestinatario);
            HasRequired(t => t.AlertaSupervisor)
                .WithMany(t => t.ExpedienteAlertas)
                .HasForeignKey(d => d.IdSupervidor);
            HasRequired(t => t.Expediente)
                .WithMany(t => t.ExpedienteAlertas)
                .HasForeignKey(d => d.IdExpediente);
            HasRequired(t => t.Gnr_TipoAlerta)
                .WithMany(t => t.ExpedienteAlertas)
                .HasForeignKey(d => d.IdTipoAlerta);

        }
    }
}
