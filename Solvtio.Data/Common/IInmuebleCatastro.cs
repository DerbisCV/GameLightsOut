using System;
using System.ComponentModel.DataAnnotations;
using Solvtio.Models;

namespace Solvtio.Models
{
    public interface IInmuebleCatastro
    {
        string RefCatastral { get; set; }

        string Direccion { get; set; }
        string DireccionCodigoPostal { get; set; }
        string DireccionLocalidad { get; set; }

        string UsoPrincipal { get; set; }
        int? AnioConstruccion { get; set; }
        int? SuperficieConstruida { get; set; }
        int? SuperficieParcela { get; set; }

        int? IdProvincia { get; set; }
        int? IdMunicipio { get; set; }
        int? IdMunicipioCatastro { get; set; }
        Provincia Provincia { get; set; }
        Municipio Municipio { get; set; }


        //[Required]
        //int IdExpediente { get; set; }
        //Expediente Expediente { get; set; }

        //DateTime Fecha { get; set; }
        //int? IdAbogado { get; set; }
        //Gnr_Abogado Abogado { get; set; }
        //TipoFaseEstado? FaseEstado { get; set; }

        //string Observacion { get; set; }
        //string Usuario { get; set; }
        //DateTime FechaAlta { get; set; }

    }
}
