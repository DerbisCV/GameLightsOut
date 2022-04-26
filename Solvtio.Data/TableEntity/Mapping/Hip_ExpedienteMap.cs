using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Hip_ExpedienteMap : IEntityTypeConfiguration<Hip_Expediente>
    {
        public Hip_ExpedienteMap()
        {
           } public void Configure(EntityTypeBuilder<Hip_Expediente> builder) {
           builder.HasKey(t => t.IdExpediente);

            // Properties
           builder.Property(t => t.IdExpediente)
                .ValueGeneratedNever();

            // Table & Column Mappings
           builder.ToTable("Hip_Expediente");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.EsTitulizado).HasColumnName("EsTitulizado");
           builder.Property(t => t.MayorCuantia).HasColumnName("MayorCuantia");
           builder.Property(t => t.ObservacionesMigracion).HasColumnName("ObservacionesMigracion");
           builder.Property(t => t.InmueblesPrestamoEnPorciento).HasColumnName("InmueblesPrestamoEnPorciento");
            //this.Property(t => t.TieneOcupantes).HasColumnName("TieneOcupantes");
           builder.Property(t => t.IdExpedienteEjc).HasColumnName("IdExpedienteEjc");

            // Relationships
            //// HasOptional(t => t.Ejc_Expediente1)
            //    //  .WithMany(t => t.Hip_Expediente1)
            //    //  .HasForeignKey(d => d.IdExpedienteEjc);
            //HasRequired(t => t.Expediente)
                //  .WithOptional(t => t.Hip_Expediente);

        }
    }
}
