using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class GNR_ProcuradoresMap : IEntityTypeConfiguration<GNR_Procuradores>
    {
        public GNR_ProcuradoresMap()
        {
        } public void Configure(EntityTypeBuilder<GNR_Procuradores> builder) {
           builder.HasKey(t => t.IdProcurador);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

           builder.Property(t => t.Apellidos)
                .IsRequired()
                .HasMaxLength(250);

           builder.Property(t => t.Telefono)
                .HasMaxLength(50);

           builder.Property(t => t.Telefono2)
                .HasMaxLength(50);

           builder.Property(t => t.Movil)
                .HasMaxLength(50);

           builder.Property(t => t.Fax)
                .HasMaxLength(50);

           builder.Property(t => t.Email)
                .HasMaxLength(200);

           builder.Property(t => t.Provincia)
                .HasMaxLength(200);

           builder.Property(t => t.EnvioDemandas)
                .HasMaxLength(250);

            // Table & Column Mappings
           builder.ToTable("GNR_Procuradores");
           builder.Property(t => t.IdProcurador).HasColumnName("IdProcurador");
           builder.Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.Apellidos).HasColumnName("Apellidos");
           builder.Property(t => t.Telefono).HasColumnName("Telefono");
           builder.Property(t => t.Telefono2).HasColumnName("Telefono2");
           builder.Property(t => t.Movil).HasColumnName("Movil");
           builder.Property(t => t.Fax).HasColumnName("Fax");
           builder.Property(t => t.Email).HasColumnName("Email");
           builder.Property(t => t.Provincia).HasColumnName("Provincia");
           builder.Property(t => t.Direccion).HasColumnName("Direccion");
           builder.Property(t => t.IdTratamiento).HasColumnName("IdTratamiento");
           builder.Property(t => t.EnvioDemandas).HasColumnName("EnvioDemandas");
        }
    }
}
