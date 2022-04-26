using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Neg_GestionMap : IEntityTypeConfiguration<Neg_Gestion>
    {
        public Neg_GestionMap()
        {
           } public void Configure(EntityTypeBuilder<Neg_Gestion> builder) {
           builder.HasKey(t => t.IdExpediente);

            // Properties
           builder.Property(t => t.IdExpediente)
                .ValueGeneratedNever();

           builder.Property(t => t.OficinaSucursalNo)
                .HasMaxLength(4);

           builder.Property(t => t.OficinaSucursalTelefono)
                .HasMaxLength(50);

            // Table & Column Mappings
           builder.ToTable("Neg_Gestion");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdGestor).HasColumnName("IdGestor");
           builder.Property(t => t.Plan30).HasColumnName("Plan30");
           builder.Property(t => t.Observacion).HasColumnName("Observacion");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.OficinaSucursalNo).HasColumnName("OficinaSucursalNo");
           builder.Property(t => t.OficinaSucursalTelefono).HasColumnName("OficinaSucursalTelefono");
           builder.Property(t => t.OficinaSucursalObservacion).HasColumnName("OficinaSucursalObservacion");
           builder.Property(t => t.IdTipoEstadoLast).HasColumnName("IdTipoEstadoLast");
           builder.Property(t => t.DeudaNegociacion).HasColumnName("DeudaNegociacion");
           builder.Property(t => t.DeudaRecuperada).HasColumnName("DeudaRecuperada");

            // Relationships
            //HasRequired(t => t.Expediente)
                //  .WithOptional(t => t.Neg_Gestion);
            //HasRequired(t => t.Gnr_Persona)
                //  .WithMany(t => t.Neg_Gestion)
                //  .HasForeignKey(d => d.IdGestor);

        }
    }
}
