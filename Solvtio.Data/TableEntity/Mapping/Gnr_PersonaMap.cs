using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Gnr_PersonaMap : EntityTypeConfiguration<Gnr_Persona>
    {
        public Gnr_PersonaMap()
        {
            // Primary Key
            HasKey(t => t.IdPersona);

            // Properties
            Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(550);

            Property(t => t.Apellidos)
                .HasMaxLength(250);

            Property(t => t.NoDocumento)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Email)
                .HasMaxLength(150);

            Property(t => t.Usuario)
                .HasMaxLength(50);

            Property(t => t.NombreApellidos)
			//	//.IsRequired()
				.HasMaxLength(801);

            // Table & Column Mappings
            ToTable("Gnr_Persona");
            Property(t => t.IdPersona).HasColumnName("IdPersona");
            Property(t => t.Nombre).HasColumnName("Nombre");
            Property(t => t.Apellidos).HasColumnName("Apellidos");
            Property(t => t.IdTipoIdentidad).HasColumnName("IdTipoIdentidad");
            Property(t => t.NoDocumento).HasColumnName("NoDocumento");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.IdTipoTratamiento).HasColumnName("IdTipoTratamiento");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.Usuario).HasColumnName("Usuario");
            Property(t => t.FechaAlta).HasColumnName("FechaAlta");
            Property(t => t.NombreApellidos).HasColumnName("NombreApellidos");

            // Relationships
            HasOptional(t => t.aspnet_Users)
                .WithMany(t => t.Gnr_Persona)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.Gnr_TipoIdentidad)
                .WithMany(t => t.Gnr_Persona)
                .HasForeignKey(d => d.IdTipoIdentidad);
            HasOptional(t => t.Gnr_TipoTratamiento)
                .WithMany(t => t.Gnr_Persona)
                .HasForeignKey(d => d.IdTipoTratamiento);

        }
    }
}
