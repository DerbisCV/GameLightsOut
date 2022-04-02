using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteMap : EntityTypeConfiguration<Con_Expediente>
    {
        public Con_ExpedienteMap()
        {
            // Primary Key
            HasKey(t => t.IdExpediente);

            // Properties
            Property(t => t.IdExpediente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //this.Property(t => t.NoAuto)
            //    .HasMaxLength(50);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            //this.Property(t => t.Juzgado)
            //    .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Con_Expediente");
            Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            Property(t => t.FechaDeclaracion).HasColumnName("FechaDeclaracion");
            Property(t => t.FechaPublicacionBoe).HasColumnName("FechaPublicacionBoe");
            Property(t => t.PlazoEnDias).HasColumnName("PlazoEnDias");
            //this.Property(t => t.NoAuto).HasColumnName("NoAuto");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            //this.Property(t => t.Juzgado).HasColumnName("Juzgado");
            Property(t => t.IdDeudorPrincipal).HasColumnName("IdDeudorPrincipal");

            // Relationships
            HasOptional(t => t.Gnr_Persona)
                .WithMany(t => t.Con_Expediente)
                .HasForeignKey(d => d.IdDeudorPrincipal);
            HasRequired(t => t.Expediente)
                .WithOptional(t => t.Con_Expediente);

        }
    }
}
