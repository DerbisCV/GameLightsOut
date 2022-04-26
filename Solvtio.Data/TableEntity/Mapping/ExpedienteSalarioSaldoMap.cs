using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
{
    //public class ExpedienteDeudorSalarioSaldoMap : IEntityTypeConfiguration<ExpedienteDeudorSalarioSaldo>
    //{
    //    public ExpedienteDeudorSalarioSaldoMap()
    //    {
    //        public void Configure(EntityTypeBuilder<object> builder) {
    //        this.HasKey(t => t.Id);

    //        // Properties
    //        this.Property(t => t.Entidad)
    //            .HasMaxLength(500);

    //        // Table & Column Mappings
    //        this.ToTable("ExpedienteDeudorSalarioSaldo");
    //        this.Property(t => t.Id).HasColumnName("IdSalarioSaldo");
    //        this.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
    //        this.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
    //        this.Property(t => t.Tipo).HasColumnName("Tipo");
    //        this.Property(t => t.Fecha).HasColumnName("Fecha");
    //        this.Property(t => t.Entidad).HasColumnName("Entidad");
    //        this.Property(t => t.Importe).HasColumnName("Importe");

    //        // Relationships
    //        this.//HasRequired(t => t.ExpedienteEstado)
    //            //  .WithMany(t => t.ExpedienteDeudorSalarioSaldoes)
    //            //  .HasForeignKey(d => d.IdExpedienteEstado);

    //    }
    //}
}
