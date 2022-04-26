//using System.Data.Entity.ModelConfiguration;

//using Microsoft.EntityFrameworkCore; using Microsoft.EntityFrameworkCore.Metadata.Builders; namespace Solvtio.Models.Mapping
//{
//    public class ExpedienteMuebleMap : IEntityTypeConfiguration<ExpedienteDeudorMueble>
//    {
//        public ExpedienteMuebleMap()
//        {
//            public void Configure(EntityTypeBuilder<object> builder) {
//            this.HasKey(t => t.IdMueble);

//            // Properties
//            this.Property(t => t.NoMueble)
//                .HasMaxLength(500);

//            this.Property(t => t.Tipo)
//                .HasMaxLength(500);

//            this.Property(t => t.Registro)
//                .HasMaxLength(500);

//            this.Property(t => t.LetraEmbargo)
//                .HasMaxLength(500);

//            // Table & Column Mappings
//            this.ToTable("ExpedienteMueble");
//            this.Property(t => t.IdMueble).HasColumnName("IdMueble");
//            this.Property(t => t.IdExpediente).HasColumnName("IdExpediente");
//            this.Property(t => t.IdExpedienteEstado).HasColumnName("IdExpedienteEstado");
//            this.Property(t => t.NoMueble).HasColumnName("NoMueble");
//            this.Property(t => t.Tipo).HasColumnName("Tipo");
//            this.Property(t => t.Registro).HasColumnName("Registro");
//            this.Property(t => t.LetraEmbargo).HasColumnName("LetraEmbargo");
//            this.Property(t => t.Descripcion).HasColumnName("Descripcion");

//            // Relationships
//            this.//HasRequired(t => t.ExpedienteEstado)
//                //  .WithMany(t => t.ExpedienteMuebles)
//                //  .HasForeignKey(d => d.IdExpedienteEstado);

//        }
//    }
//}
