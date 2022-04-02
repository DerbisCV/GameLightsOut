using System.Data.Entity.ModelConfiguration;

namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoGarantiaInmueblesMap : EntityTypeConfiguration<Con_ExpedienteCreditoGarantiaInmuebles>
    {
        public Con_ExpedienteCreditoGarantiaInmueblesMap()
        {
            // Primary Key
            HasKey(t => t.IdExpedienteCreditoGarantiaInmueble);

            // Properties
            Property(t => t.Tomo)
                .HasMaxLength(250);

            Property(t => t.Libro)
                .HasMaxLength(250);

            Property(t => t.Folio)
                .HasMaxLength(250);

            Property(t => t.NumeroFinca)
                .HasMaxLength(250);

            Property(t => t.Inscripcion)
                .HasMaxLength(250);

            Property(t => t.Direccion)
                .HasMaxLength(250);

            Property(t => t.Localidad)
                .HasMaxLength(50);

            Property(t => t.CodigoPostal)
                .HasMaxLength(5);

            Property(t => t.Provincia)
                .HasMaxLength(50);

            Property(t => t.Lote)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Con_ExpedienteCreditoGarantiaInmuebles");
            Property(t => t.IdExpedienteCreditoGarantiaInmueble).HasColumnName("IdExpedienteCreditoGarantiaInmueble");
            Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
            Property(t => t.IdTipoInmueble).HasColumnName("IdTipoInmueble");
            Property(t => t.Superficie).HasColumnName("Superficie");
            Property(t => t.Descripcion).HasColumnName("Descripcion");
            Property(t => t.Tomo).HasColumnName("Tomo");
            Property(t => t.Libro).HasColumnName("Libro");
            Property(t => t.Folio).HasColumnName("Folio");
            Property(t => t.NumeroFinca).HasColumnName("NumeroFinca");
            Property(t => t.Inscripcion).HasColumnName("Inscripcion");
            Property(t => t.Direccion).HasColumnName("Direccion");
            Property(t => t.Localidad).HasColumnName("Localidad");
            Property(t => t.CodigoPostal).HasColumnName("CodigoPostal");
            Property(t => t.Provincia).HasColumnName("Provincia");
            Property(t => t.Lote).HasColumnName("Lote");
            Property(t => t.ImporteSubasta).HasColumnName("ImporteSubasta");
            Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
            Property(t => t.Adjudicado).HasColumnName("Adjudicado");
            Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");

            // Relationships
            HasRequired(t => t.Con_ExpedienteCredito)
                .WithMany(t => t.Con_ExpedienteCreditoGarantiaInmuebles)
                .HasForeignKey(d => d.IdExpedienteCredito);
            HasRequired(t => t.Hip_TipoInmueble)
                .WithMany(t => t.Con_ExpedienteCreditoGarantiaInmuebles)
                .HasForeignKey(d => d.IdTipoInmueble);

        }
    }
}
