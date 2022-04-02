using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class ProcuradoresClienteMap : EntityTypeConfiguration<ProcuradoresCliente>
    {
        public ProcuradoresClienteMap()
        {
            // Primary Key
            HasKey(t => t.IdProcuradorCliente);

            // Properties
            // Table & Column Mappings
            ToTable("ProcuradoresClientes");
            Property(t => t.IdProcuradorCliente).HasColumnName("IdProcuradorCliente");
            Property(t => t.IdCliente).HasColumnName("IdCliente");
            Property(t => t.IdProcurador).HasColumnName("IdProcurador");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            HasRequired(t => t.Gnr_Cliente)
                .WithMany(t => t.ProcuradoresClientes)
                .HasForeignKey(d => d.IdCliente);
            HasRequired(t => t.GNR_Procuradores)
                .WithMany(t => t.ProcuradoresClientes)
                .HasForeignKey(d => d.IdProcurador);

        }
    }
}
