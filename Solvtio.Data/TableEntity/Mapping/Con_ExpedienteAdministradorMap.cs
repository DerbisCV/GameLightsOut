using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteAdministradorMap : IEntityTypeConfiguration<Con_ExpedienteAdministrador>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteAdministrador> builder)
        {
            // 
           builder.HasKey(t => t.IdAdministrador);

            // Properties
            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteAdministrador");
           builder.Property(t => t.IdAdministrador).HasColumnName("IdAdministrador");
           builder.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.IdTipoAdministrador).HasColumnName("IdTipoAdministrador");

            // Relationships
            //HasRequired(t => t.Expediente)
            //    .WithMany(t => t.Con_ExpedienteAdministrador)
            //    .HasForeignKey(d => d.IdExpediente);
            //HasRequired(t => t.Gnr_Persona)
            //    .WithMany(t => t.Con_ExpedienteAdministrador)
            //    .HasForeignKey(d => d.IdPersona);

        }
    }
}
