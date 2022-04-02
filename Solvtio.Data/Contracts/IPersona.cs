using System;

namespace Solvtio.Models
{
    public interface IPersona
    {
        Gnr_Persona Persona { get; set; }
    }

    public interface IGnrPersona
    {
        Gnr_Persona Gnr_Persona { get; set; }
    }
}