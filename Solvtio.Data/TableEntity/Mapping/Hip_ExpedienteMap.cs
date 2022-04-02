using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteMap : EntityTypeConfiguration<Hip_Expediente>
    {
        public Hip_ExpedienteMap()
        {
            // Primary Key
            HasKey(t => t.IdExpediente);

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Hip_Expediente");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.EsTitulizado).HasColumnName("EsTitulizado");
            Property(t => t.MayorCuantia).HasColumnName("MayorCuantia");
            Property(t => t.ObservacionesMigracion).HasColumnName("ObservacionesMigracion");
            Property(t => t.InmueblesPrestamoEnPorciento).HasColumnName("InmueblesPrestamoEnPorciento");
            //this.Property(t => t.TieneOcupantes).HasColumnName("TieneOcupantes");
            Property(t => t.IdExpedienteEjc).HasColumnName("IdExpedienteEjc");

            // Relationships
            HasOptional(t => t.Ejc_Expediente1)
                .WithMany(t => t.Hip_Expediente1)
                .HasForeignKey(d => d.IdExpedienteEjc);
            HasRequired(t => t.Expediente)
                .WithOptional(t => t.Hip_Expediente);

        }
    }
}
