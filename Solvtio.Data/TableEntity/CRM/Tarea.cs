using Solvtio.Common;
using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Solvtio.Models
{
    [Table("Tarea")]
    public class Tarea : ITitulo
    {
        #region Constructors

        public Tarea()
        {
            CreateBase();
        }

        public Tarea(int idEmpresa)
        {
            CreateBase();
            IdEmpresa = idEmpresa;
        }

        private void CreateBase()
        {
            Fecha = CreatedDate = DateTime.Now;

            ActivoResidencial = new TareaCriteriosAdquisicion();
            SueloWip = new TareaCriteriosAdquisicion();
            ActivoComercial = new TareaCriteriosAdquisicion();
            ActivoOficina = new TareaCriteriosAdquisicion();
            ActivoHotel = new TareaCriteriosAdquisicion();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarea { get; set; }

        public DateTime Fecha { get; set; }
        public string Titulo { get; set; }
        public string Observaciones { get; set; }
        public TipoTarea TipoTarea { get; set; }
        public bool Completada { get; set; }

        public int? IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Gnr_ClienteOficina Empresa { get; set; }


        public int? IdContacto { get; set; }
        [ForeignKey("IdContacto")]
        public Contacto Contacto { get; set; }

        public int? IdOportunidad { get; set; }
        [ForeignKey("IdOportunidad")]
        public Oportunidad Oportunidad { get; set; }

        public int? IdComite { get; set; }
        [ForeignKey("IdComite")]
        public Comite Comite { get; set; }

        public int? IdResponsable { get; set; }
        [ForeignKey("IdResponsable")]
        public Gnr_Persona Responsable { get; set; }


        public TareaCriteriosAdquisicion ActivoResidencial { get; set; }
        public TareaCriteriosAdquisicion SueloWip { get; set; }
        public TareaCriteriosAdquisicion ActivoComercial { get; set; }
        public TareaCriteriosAdquisicion ActivoOficina { get; set; }
        public TareaCriteriosAdquisicion ActivoHotel { get; set; }

        public virtual ICollection<TareaServicioBufete> TareaServicioBufeteSet { get; set; }

        [NotMapped]
        public List<KeyValue> LstServicios { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public List<int> LstServicio { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Fecha.ToString("d/M")}: {TipoTarea.GetDescription()}";
        }

        public string ServiciosToString()
        {
            if (TareaServicioBufeteSet.IsEmpty()) return string.Empty;

            var sb = new StringBuilder();
            foreach (var serv in TareaServicioBufeteSet)
            {
                if (sb.Length > 0)
                    sb.Append($", {serv.ServicioBufete.Nombre}");
                else
                    sb.Append(serv.ServicioBufete.Nombre);
            }

            return sb.ToString();
        }

        #endregion
    }

    public class TareaCriteriosAdquisicion
    {
        public bool? Npl { get; set; }
        public bool? Reo { get; set; }

        public decimal? VolumenInversion { get; set; }
        public decimal? InversionMaximaPorUnidad { get; set; }

        public decimal? InversionMin { get; set; }
        public decimal? InversionMax { get; set; }
        public decimal? SuperficieMin { get; set; }
        public decimal? SuperficieMax { get; set; }
        public decimal? EdificabilidadMin { get; set; }
        public decimal? EdificabilidadMax { get; set; }

        public int? NoHabitaciones { get; set; }

        //public DecimalMinMax Inversion { get; set; }
        //public DecimalMinMax Superficie { get; set; }
        //public DecimalMinMax Edificabilidad { get; set; }

        public bool? TipoAtomatizado { get; set; }
        public bool? TipoPromocionCompleta { get; set; }
        public bool? TipoWip { get; set; }
        public bool? TipoWipResidencial { get; set; }
        public bool? TipoWipTerciario { get; set; }

        public bool? TipoSuelo { get; set; }
        public bool? TipoSueloFinalistaDesarrollo { get; set; }
        public bool? TipoSueloResidencial { get; set; }
        public bool? TipoSueloTerciario { get; set; }

        public string Ubicacion { get; set; }
        public bool? EstadoLibre { get; set; }
        public bool? EstadoAlquilado { get; set; }
        public bool? EstadoOkupado { get; set; }
        public bool? EstadoSinPosesion { get; set; }

        public void Refresh(TareaCriteriosAdquisicion model)
        {
            Npl = model?.Npl;
            Reo = model?.Reo;
            VolumenInversion = model?.VolumenInversion;
            InversionMaximaPorUnidad = model?.InversionMaximaPorUnidad;

            TipoAtomatizado = model?.TipoAtomatizado;
            TipoPromocionCompleta = model?.TipoPromocionCompleta;
            TipoWip = model?.TipoWip;
            TipoWipResidencial = model?.TipoWipResidencial;
            TipoWipTerciario = model?.TipoWipTerciario;
            TipoSuelo = model?.TipoSuelo;
            TipoSueloFinalistaDesarrollo = model?.TipoSueloFinalistaDesarrollo;
            TipoSueloResidencial = model?.TipoSueloResidencial;
            TipoSueloTerciario = model?.TipoSueloTerciario;

            Ubicacion = model?.Ubicacion;
            EstadoLibre = model?.EstadoLibre;
            EstadoAlquilado = model?.EstadoAlquilado;
            EstadoOkupado = model?.EstadoOkupado;
            EstadoSinPosesion = model?.EstadoSinPosesion;

            VolumenInversion = model?.VolumenInversion;
            TipoSuelo = model?.TipoSuelo;
            TipoSueloFinalistaDesarrollo = model?.TipoSueloFinalistaDesarrollo;
            TipoSueloResidencial = model?.TipoSueloResidencial;
            TipoSueloTerciario = model?.TipoSueloTerciario;
            InversionMin = model?.InversionMin;
            InversionMax = model?.InversionMax;
            SuperficieMin = model?.SuperficieMin;
            SuperficieMax = model?.SuperficieMax;
            EdificabilidadMin = model?.EdificabilidadMin;
            EdificabilidadMax = model?.EdificabilidadMax;

            NoHabitaciones = model?.NoHabitaciones;
            //Reo = model?.Reo;

        }
    }

    public class DecimalMinMax
    {
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }

        public void Refresh(DecimalMinMax model)
        {
            Min = model?.Min;
            Max = model?.Max;
        }
    }

}
