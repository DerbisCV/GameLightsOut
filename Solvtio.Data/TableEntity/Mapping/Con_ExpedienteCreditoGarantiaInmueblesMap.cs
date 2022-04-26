using System.Data.Entity.ModelConfiguration;

using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    public class Con_ExpedienteCreditoGarantiaInmueblesMap : IEntityTypeConfiguration<Con_ExpedienteCreditoGarantiaInmuebles>
    {
        public void Configure(EntityTypeBuilder<Con_ExpedienteCreditoGarantiaInmuebles> builder) {
           builder.HasKey(t => t.IdExpedienteCreditoGarantiaInmueble);

            // Properties
           builder.Property(t => t.Tomo)
                .HasMaxLength(250);

           builder.Property(t => t.Libro)
                .HasMaxLength(250);

           builder.Property(t => t.Folio)
                .HasMaxLength(250);

           builder.Property(t => t.NumeroFinca)
                .HasMaxLength(250);

           builder.Property(t => t.Inscripcion)
                .HasMaxLength(250);

           builder.Property(t => t.Direccion)
                .HasMaxLength(250);

           builder.Property(t => t.Localidad)
                .HasMaxLength(50);

           builder.Property(t => t.CodigoPostal)
                .HasMaxLength(5);

           builder.Property(t => t.Provincia)
                .HasMaxLength(50);

           builder.Property(t => t.Lote)
                .HasMaxLength(10);

            // Table & Column Mappings
           builder.ToTable("Con_ExpedienteCreditoGarantiaInmuebles");
           builder.Property(t => t.IdExpedienteCreditoGarantiaInmueble).HasColumnName("IdExpedienteCreditoGarantiaInmueble");
           builder.Property(t => t.IdExpedienteCredito).HasColumnName("IdExpedienteCredito");
           builder.Property(t => t.IdTipoInmueble).HasColumnName("IdTipoInmueble");
           builder.Property(t => t.Superficie).HasColumnName("Superficie");
           builder.Property(t => t.Descripcion).HasColumnName("Descripcion");
           builder.Property(t => t.Tomo).HasColumnName("Tomo");
           builder.Property(t => t.Libro).HasColumnName("Libro");
           builder.Property(t => t.Folio).HasColumnName("Folio");
           builder.Property(t => t.NumeroFinca).HasColumnName("NumeroFinca");
           builder.Property(t => t.Inscripcion).HasColumnName("Inscripcion");
           builder.Property(t => t.Direccion).HasColumnName("Direccion");
           builder.Property(t => t.Localidad).HasColumnName("Localidad");
           builder.Property(t => t.CodigoPostal).HasColumnName("CodigoPostal");
           builder.Property(t => t.Provincia).HasColumnName("Provincia");
           builder.Property(t => t.Lote).HasColumnName("Lote");
           builder.Property(t => t.ImporteSubasta).HasColumnName("ImporteSubasta");
           builder.Property(t => t.ImporteAdjudicacion).HasColumnName("ImporteAdjudicacion");
           builder.Property(t => t.Adjudicado).HasColumnName("Adjudicado");
           builder.Property(t => t.FechaAdjudicacion).HasColumnName("FechaAdjudicacion");

            // Relationships
            //HasRequired(t => t.Con_ExpedienteCredito)
            //    .WithMany(t => t.Con_ExpedienteCreditoGarantiaInmuebles)
            //    .HasForeignKey(d => d.IdExpedienteCredito);
            //HasRequired(t => t.Hip_TipoInmueble)
            //    .WithMany(t => t.Con_ExpedienteCreditoGarantiaInmuebles)
            //    .HasForeignKey(d => d.IdTipoInmueble);

        }
    }
}
