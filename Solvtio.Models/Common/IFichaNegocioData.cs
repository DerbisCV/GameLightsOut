using System;
using System.ComponentModel.DataAnnotations;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    public interface IFichaNegocioData
    {
        decimal Ingresos { get; set; }
        decimal GastosDirectos { get; set; }
        decimal GastosIndirectos { get; set; }
        decimal ResultadosAntesIndirectos { get; }

        int ExpEntradas { get; set; }
        int ExpSalidas { get; set; }
        int ExpStock { get; set; }

        int NoPersonas { get; set; }
        int NoPersonasTipoContrato1 { get; set; }
        int NoPersonasTipoContrato2 { get; set; }
        int NoPersonasTipoContrato3 { get; set; }
        int NoPersonasTipoContrato4 { get; set; }
    }

}
