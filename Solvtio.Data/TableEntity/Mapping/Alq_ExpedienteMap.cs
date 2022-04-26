using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Solvtio.Models.Mapping
{
    public class Alq_ExpedienteMap : IEntityTypeConfiguration<Alq_Expediente>
    {
        public void Configure(EntityTypeBuilder<Alq_Expediente> builder)
        {
            builder.ToTable("Alq_Expediente");
            builder.HasKey(t => t.IdExpediente);
            builder.Property(t => t.IdExpediente).ValueGeneratedNever();

            builder.Property(t => t.ReferenciaExternaMACRO)
                .HasMaxLength(50);

            builder.Property(t => t.ReferenciaExternaMSGI)
                .HasMaxLength(50);

            builder.Property(t => t.NumAuto)
                .HasMaxLength(50);

            builder.Property(t => t.TipoProcedimiento)
                .HasMaxLength(50);



            builder.Property(t => t.Cedente)
                .HasMaxLength(200);

            builder.Property(t => t.CodigoActivoCedente)
                .HasMaxLength(50);

            // Table & Column Mappings
            
            //Property(t => t.IdExpediente).HasColumnName("IdExpediente");
            //Property(t => t.ReferenciaExternaMACRO).HasColumnName("ReferenciaExternaMACRO");
            //Property(t => t.ReferenciaExternaMSGI).HasColumnName("ReferenciaExternaMSGI");
            //Property(t => t.DeudaInicial).HasColumnName("DeudaInicial");
            //Property(t => t.DeudaPendiente).HasColumnName("DeudaPendiente");
            //Property(t => t.FechaEstadoActual).HasColumnName("FechaEstadoActual");
            //Property(t => t.IdAbogadoZona).HasColumnName("IdAbogadoZona");
            //Property(t => t.ObservacionesMigracion).HasColumnName("ObservacionesMigracion");
            //Property(t => t.EstaCompleto).HasColumnName("EstaCompleto");
            //Property(t => t.FechaEnvioBurofax).HasColumnName("FechaEnvioBurofax");
            //Property(t => t.Fianza).HasColumnName("Fianza");
            //Property(t => t.GarantiaAdicional).HasColumnName("GarantiaAdicional");
            //Property(t => t.IdAlqContrato).HasColumnName("IdAlqContrato");
            //Property(t => t.TipoProcedimiento).HasColumnName("TipoProcedimiento");
            //Property(t => t.IdTipoEstadoCliente).HasColumnName("IdTipoEstadoCliente");
            //Property(t => t.Cedente).HasColumnName("Cedente");
            //Property(t => t.CodigoActivoCedente).HasColumnName("CodigoActivoCedente");
            //Property(t => t.ImporteCostas).HasColumnName("ImporteCostas");
            //Property(t => t.ImporteCondonacion).HasColumnName("ImporteCondonacion");
            //Property(t => t.IdTipoGarantiaAdicional).HasColumnName("IdTipoGarantiaAdicional");
            //Property(t => t.IdProcedimientoActual).HasColumnName("IdProcedimientoActual");
            //Property(t => t.IdEstadoDemanda).HasColumnName("IdEstadoDemanda");
            //Property(t => t.IdExpedienteEjc).HasColumnName("IdExpedienteEjc");

            //HasRequired(t => t.Expediente)
            //    .WithOptional(t => t.Alq_Expediente);
            //HasOptional(t => t.Gnr_Abogado)
            //    .WithMany(t => t.Alq_Expediente)
            //    .HasForeignKey(d => d.IdAbogadoZona);
            //HasOptional(t => t.Gnr_TipoEstadoCliente)
            //    .WithMany(t => t.Alq_Expediente)
            //    .HasForeignKey(d => d.IdTipoEstadoCliente);

        }


    }
}
