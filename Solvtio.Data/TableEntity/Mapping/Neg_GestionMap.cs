using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Neg_GestionMap : EntityTypeConfiguration<Neg_Gestion>
    {
        public Neg_GestionMap()
        {
            // Primary Key
            HasKey(t => t.IdExpediente);

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.OficinaSucursalNo)
                .HasMaxLength(4);

            Property(t => t.OficinaSucursalTelefono)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Neg_Gestion");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.IdGestor).HasColumnName("IdGestor");
            Property(t => t.Plan30).HasColumnName("Plan30");
            Property(t => t.Observacion).HasColumnName("Observacion");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.OficinaSucursalNo).HasColumnName("OficinaSucursalNo");
            Property(t => t.OficinaSucursalTelefono).HasColumnName("OficinaSucursalTelefono");
            Property(t => t.OficinaSucursalObservacion).HasColumnName("OficinaSucursalObservacion");
            Property(t => t.IdTipoEstadoLast).HasColumnName("IdTipoEstadoLast");
            Property(t => t.DeudaNegociacion).HasColumnName("DeudaNegociacion");
            Property(t => t.DeudaRecuperada).HasColumnName("DeudaRecuperada");

            // Relationships
            HasRequired(t => t.Expediente)
                .WithOptional(t => t.Neg_Gestion);
            HasRequired(t => t.Gnr_Persona)
                .WithMany(t => t.Neg_Gestion)
                .HasForeignKey(d => d.IdGestor);

        }
    }
}
