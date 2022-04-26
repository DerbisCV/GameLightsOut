using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class AlertaSupervisorMap : IEntityTypeConfiguration<AlertaSupervisor>
    {
        public void Configure(EntityTypeBuilder<AlertaSupervisor> builder)
        {
            builder
                .ToTable("AlertaSupervisor")
                .Property(t => t.IdPersona).ValueGeneratedNever();// .ValueGeneratedNever();

            builder.HasKey(t => t.IdPersona);



            //Property(t => t.Departamento)
            //    .IsFixedLength()
            //    .HasMaxLength(100);

            // Table & Column Mappings
            //;
            //Property(t => t.IdPersona).HasColumnName("IdPersona");
            //Property(t => t.Departamento).HasColumnName("Departamento");
            //Property(t => t.EsEjecutivo).HasColumnName("EsEjecutivo");

            // Relationships
            ////HasRequired(t => t.Gnr_Persona)
            //    //  .WithOptional(t => t.AlertaSupervisor);

        }

    }
}
