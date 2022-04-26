using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Alq_Expediente_Contratos_PlanPagos_LineasMap : IEntityTypeConfiguration<Alq_Expediente_Contratos_PlanPagos_Lineas>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente_Contratos_PlanPagos_Lineas> builder)
        {
            // public void Configure(EntityTypeBuilder<object> builder)
           builder.HasKey(t => t.ID);

            // Properties
           builder.Property(t => t.Observaciones)
                .HasMaxLength(250);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

           builder.Property(t => t.UsuarioSatisfecho)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Alq_Expediente_Contratos_PlanPagos_Lineas");
           builder.Property(t => t.ID).HasColumnName("ID");
           builder.Property(t => t.IdContrato).HasColumnName("IdContrato");
           builder.Property(t => t.FechaVencimiento).HasColumnName("FechaVencimiento");
           builder.Property(t => t.AmortizacionDeuda).HasColumnName("AmortizacionDeuda");
           builder.Property(t => t.RentaMes).HasColumnName("RentaMes");
           builder.Property(t => t.Satisfecho).HasColumnName("Satisfecho");
           builder.Property(t => t.FechaNotificacion).HasColumnName("FechaNotificacion");
           builder.Property(t => t.DeudaPendiente).HasColumnName("DeudaPendiente");
           builder.Property(t => t.Observaciones).HasColumnName("Observaciones");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.UsuarioSatisfecho).HasColumnName("UsuarioSatisfecho");
           builder.Property(t => t.FechaSatisfecho).HasColumnName("FechaSatisfecho");

            // Relationships
            //HasOptional(t => t.Alq_Expediente_Contratos)
            //    .WithMany(t => t.Alq_Expediente_Contratos_PlanPagos_Lineas)
            //    .HasForeignKey(d => d.IdContrato);

        }
    }
}
