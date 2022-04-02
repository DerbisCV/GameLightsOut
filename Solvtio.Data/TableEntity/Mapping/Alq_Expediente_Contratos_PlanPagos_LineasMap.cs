using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_Contratos_PlanPagos_LineasMap : EntityTypeConfiguration<Alq_Expediente_Contratos_PlanPagos_Lineas>
    {
        public Alq_Expediente_Contratos_PlanPagos_LineasMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Observaciones)
                .HasMaxLength(250);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            Property(t => t.UsuarioSatisfecho)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Alq_Expediente_Contratos_PlanPagos_Lineas");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.IdContrato).HasColumnName("IdContrato");
            Property(t => t.FechaVencimiento).HasColumnName("FechaVencimiento");
            Property(t => t.AmortizacionDeuda).HasColumnName("AmortizacionDeuda");
            Property(t => t.RentaMes).HasColumnName("RentaMes");
            Property(t => t.Satisfecho).HasColumnName("Satisfecho");
            Property(t => t.FechaNotificacion).HasColumnName("FechaNotificacion");
            Property(t => t.DeudaPendiente).HasColumnName("DeudaPendiente");
            Property(t => t.Observaciones).HasColumnName("Observaciones");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.UsuarioSatisfecho).HasColumnName("UsuarioSatisfecho");
            Property(t => t.FechaSatisfecho).HasColumnName("FechaSatisfecho");

            // Relationships
            HasOptional(t => t.Alq_Expediente_Contratos)
                .WithMany(t => t.Alq_Expediente_Contratos_PlanPagos_Lineas)
                .HasForeignKey(d => d.IdContrato);

        }
    }
}
