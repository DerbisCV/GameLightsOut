using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaMap : IEntityTypeConfiguration<Gnr_Persona>
    {
        
            public void Configure(EntityTypeBuilder<Gnr_Persona> builder) {
           builder.HasKey(t => t.IdPersona);

            // Properties
           builder.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(550);

           builder.Property(t => t.Apellidos)
                .HasMaxLength(250);

           builder.Property(t => t.NoDocumento)
                .IsRequired()
                .HasMaxLength(50);

           builder.Property(t => t.Email)
                .HasMaxLength(150);

           builder.Property(t => t.Usuario)
                .HasMaxLength(50);

           builder.Property(t => t.NombreApellidos)
			//	//.IsRequired()
				.HasMaxLength(801);

            // Table & Column Mappings
           builder.ToTable("Gnr_Persona");
           builder.Property(t => t.IdPersona).HasColumnName("IdPersona");
           builder.Property(t => t.Nombre).HasColumnName("Nombre");
           builder.Property(t => t.Apellidos).HasColumnName("Apellidos");
           builder.Property(t => t.IdTipoIdentidad).HasColumnName("IdTipoIdentidad");
           builder.Property(t => t.NoDocumento).HasColumnName("NoDocumento");
           builder.Property(t => t.Email).HasColumnName("Email");
           builder.Property(t => t.IdTipoTratamiento).HasColumnName("IdTipoTratamiento");
           builder.Property(t => t.UserId).HasColumnName("UserId");
           builder.Property(t => t.Usuario).HasColumnName("Usuario");
           builder.Property(t => t.FechaAlta).HasColumnName("FechaAlta");
           builder.Property(t => t.NombreApellidos).HasColumnName("NombreApellidos");

            // Relationships
            //// HasOptional(t => t.aspnet_Users)
            //    //  .WithMany(t => t.Gnr_Persona)
            //    //  .HasForeignKey(d => d.UserId);
            //HasRequired(t => t.Gnr_TipoIdentidad)
                //  .WithMany(t => t.Gnr_Persona)
                //  .HasForeignKey(d => d.IdTipoIdentidad);
            // HasOptional(t => t.Gnr_TipoTratamiento)
                //  .WithMany(t => t.Gnr_Persona)
                //  .HasForeignKey(d => d.IdTipoTratamiento);

        }
    }
}
