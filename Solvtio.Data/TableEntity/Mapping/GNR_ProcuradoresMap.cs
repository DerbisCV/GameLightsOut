using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class GNR_ProcuradoresMap : EntityTypeConfiguration<GNR_Procuradores>
    {
        public GNR_ProcuradoresMap()
        {
            // Primary Key
            HasKey(t => t.IdProcurador);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Apellidos)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.Telefono)
                .HasMaxLength(50);

            Property(t => t.Telefono2)
                .HasMaxLength(50);

            Property(t => t.Movil)
                .HasMaxLength(50);

            Property(t => t.Fax)
                .HasMaxLength(50);

            Property(t => t.Email)
                .HasMaxLength(200);

            Property(t => t.Provincia)
                .HasMaxLength(200);

            Property(t => t.EnvioDemandas)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("GNR_Procuradores");
            Property(t => t.IdProcurador).HasColumnName("IdProcurador");
            Property(t => t.IdPartidoJudicial).HasColumnName("IdPartidoJudicial");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.Apellidos).HasColumnName("Apellidos");
            Property(t => t.Telefono).HasColumnName("Telefono");
            Property(t => t.Telefono2).HasColumnName("Telefono2");
            Property(t => t.Movil).HasColumnName("Movil");
            Property(t => t.Fax).HasColumnName("Fax");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Provincia).HasColumnName("Provincia");
            Property(t => t.Direccion).HasColumnName("Direccion");
            Property(t => t.IdTratamiento).HasColumnName("IdTratamiento");
            Property(t => t.EnvioDemandas).HasColumnName("EnvioDemandas");
        }
    }
}
