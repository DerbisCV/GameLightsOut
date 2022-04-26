using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ExpedienteAlertaMap : IEntityTypeConfiguration<ExpedienteAlerta>
    {

            public void Configure(EntityTypeBuilder<ExpedienteAlerta> builder) {
           builder.HasKey(t => t.IdAlerta);

            // Properties
           builder.Property(t => t.Descripcion)
                .IsRequired();

            // Table & Column Mappings
           builder.ToTable("ExpedienteAlerta");
           builder.Property(t => t.IdAlerta).HasColumnName("IdAlerta");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdTipoAlerta).HasColumnName("IdTipoAlerta");
           builder.Property(t => t.FechaAviso).HasColumnName("FechaAviso");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.IdDestinatario).HasColumnName("IdDestinatario");
           builder.Property(t => t.IdSupervidor).HasColumnName("IdSupervidor");
           builder.Property(t => t.Activo).HasColumnName("Activo");
           builder.Property(t => t.FechaActivacion).HasColumnName("FechaActivacion");
           builder.Property(t => t.FechaDesactivacion).HasColumnName("FechaDesactivacion");
           builder.Property(t => t.FechaCorreoEnviado).HasColumnName("FechaCorreoEnviado");
           builder.Property(t => t.CC).HasColumnName("CC");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            ////HasRequired(t => t.AlertaDestinatario)
            //    //  .WithMany(t => t.ExpedienteAlertas)
            //    //  .HasForeignKey(d => d.IdDestinatario);
            //HasRequired(t => t.AlertaSupervisor)
                //  .WithMany(t => t.ExpedienteAlertas)
                //  .HasForeignKey(d => d.IdSupervidor);
            //HasRequired(t => t.Expediente)
                //  .WithMany(t => t.ExpedienteAlertas)
                //  .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.Gnr_TipoAlerta)
                //  .WithMany(t => t.ExpedienteAlertas)
                //  .HasForeignKey(d => d.IdTipoAlerta);

        }
    }
}
