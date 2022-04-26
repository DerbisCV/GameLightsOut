using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class ProcuradoresClienteMap : IEntityTypeConfiguration<ProcuradoresCliente>
    {
        public ProcuradoresClienteMap()
        {
           } public void Configure(EntityTypeBuilder<ProcuradoresCliente> builder) {
           builder.HasKey(t => t.IdProcuradorCliente);

            // Properties
            // Table & Column Mappings
           builder.ToTable("ProcuradoresClientes");
           builder.Property(t => t.IdProcuradorCliente).HasColumnName("IdProcuradorCliente");
           builder.Property(t => t.IdCliente).HasColumnName("IdCliente");
           builder.Property(t => t.IdProcurador).HasColumnName("IdProcurador");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");

            // Relationships
            //HasRequired(t => t.Gnr_Cliente)
                //  .WithMany(t => t.ProcuradoresClientes)
                //  .HasForeignKey(d => d.IdCliente);
            //HasRequired(t => t.GNR_Procuradores)
                //  .WithMany(t => t.ProcuradoresClientes)
                //  .HasForeignKey(d => d.IdProcurador);

        }
    }
}
