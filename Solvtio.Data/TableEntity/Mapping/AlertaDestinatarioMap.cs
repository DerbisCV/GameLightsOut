using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class AlertaDestinatarioMap : IEntityTypeConfiguration<AlertaDestinatario>
    {
        public AlertaDestinatarioMap()
        {
            //public void Configure(EntityTypeBuilder<object> builder) {
            //HasKey(t => t.IdPersona);

            //// Properties
            //Property(t => t.IdPersona)
            //    .ValueGeneratedNever();

            // Table & Column Mappings
            //Property(t => t.IdPersona).HasColumnName("IdPersona");
            //Property(t => t.IdSupervisor).HasColumnName("IdSupervisor");
            //Property(t => t.IsAdmin).HasColumnName("IsAdmin");

            // Relationships
            ////HasRequired(t => t.AlertaSupervisor)
            //    //  .WithMany(t => t.AlertaDestinatarios)
            //    //  .HasForeignKey(d => d.IdSupervisor);
            ////HasRequired(t => t.Gnr_Persona)
            //    //  .WithOptional(t => t.AlertaDestinatario);

        }

        public void Configure(EntityTypeBuilder<AlertaDestinatario> builder)
        {
            builder.ToTable("AlertaDestinatario").HasKey(t => t.IdPersona);
            builder.Property(t => t.IdPersona).ValueGeneratedNever();            
        }
    }
}
