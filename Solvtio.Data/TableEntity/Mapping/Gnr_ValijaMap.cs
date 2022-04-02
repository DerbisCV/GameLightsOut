using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_ValijaMap : EntityTypeConfiguration<Gnr_Valija>
    {
        public Gnr_ValijaMap()
        {
            // Primary Key
            HasKey(t => t.IdValija);

            // Properties
            Property(t => t.Referencia)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Gnr_Valija");
            Property(t => t.IdValija).HasColumnName("IdValija");
            Property(t => t.IdClienteOficina).HasColumnName("IdClienteOficina");
            Property(t => t.FechaRecepcion).HasColumnName("FechaRecepcion");
            Property(t => t.Referencia).HasColumnName("Referencia");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.IdTipoExpediente).HasColumnName("IdTipoExpediente");

            // Relationships
            HasRequired(t => t.Gnr_ClienteOficina)
                .WithMany(t => t.Gnr_Valija)
                .HasForeignKey(d => d.IdClienteOficina);
            HasRequired(t => t.Gnr_TipoExpediente)
                .WithMany(t => t.Gnr_Valija)
                .HasForeignKey(d => d.IdTipoExpediente);

        }
    }
}
