namespace Solvtio.Models
{
    public partial class PropuestaComercial
    {
        public int IdPropuestaComercial { get; set; }
        public int IdCliente { get; set; }
        public int IdDepartamento { get; set; }
        public string Descripcion { get; set; }
        public decimal ImporteFijo { get; set; }
        public int PeriodicidadId { get; set; }
        public decimal PorcientoVariable { get; set; }
        public string PorcientoVariableDescripcion { get; set; }
        public bool Aceptada { get; set; }
        public int? DocumentoPropuestaComercialId { get; set; }
        public int IdFormaPago { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        public virtual Gnr_Cliente Gnr_Cliente { get; set; }
        public virtual Hip_TipoPeriodicidad Hip_TipoPeriodicidad { get; set; }
    }
}
