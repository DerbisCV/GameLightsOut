using System;
using Solvtio.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("TmpNegociacionAliseda")]
    public class TmpNegociacionAliseda
    {
        #region Constructors

        public TmpNegociacionAliseda()
        {
            CreateBase();
        }
        //public CaracteristicaBase(string name, string grupo, string codigoReferencia = null)
        //{
        //    CreateBase();

        //    int orden = codigoReferencia.ToIntegerOrDefault(0);
        //    Nombre = name;
        //    Grupo = grupo;
        //    Codigo = codigoReferencia;
        //    Orden = orden;
        //}
        //public CaracteristicaBase(string name, string grupo, string codigoReferencia, int orden)
        //{
        //    CreateBase();

        //    Nombre = name;
        //    Grupo = grupo;
        //    Codigo = codigoReferencia;
        //    Orden = orden;
        //}

        private void CreateBase()
        {
            //FechaAlta = DateTime.Now;
            //Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Proveedor { get; set; }
        public string InmuebleAsociado { get; set; }
        public string FincaRegistral { get; set; }
        public string Registro { get; set; }
        public string RegistroNo { get; set; }
        public decimal? VbcInmueble { get; set; }

        public string TipoInmueble { get; set; }
        public string DeudorNombre { get; set; }
        public string DeudorDocumento { get; set; }
        public string TtPpEstado { get; set; }
        public DateTime? TtPpFecha { get; set; }
        public string TtPpIncentivo { get; set; }
        public string TtPpIncentivoImporte { get; set; }

        public string IncentivoEfectividadFecha { get; set; }
        public string Quita { get; set; }
        public string QuitaImporte { get; set; }
        public string Clasificacion { get; set; }
        public string Observaciones { get; set; }
        public string TiempoEstimado { get; set; }
        public string FaseProyecto { get; set; }
        public string DetalleActivos { get; set; }
        public string SenalamientosFuturo { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<Gnr_Abogado> AbogadoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public Expediente Expediente { get; set; }

        [NotMapped]
        public Hip_Inmueble Inmueble { get; set; }

        #endregion
    }
}
