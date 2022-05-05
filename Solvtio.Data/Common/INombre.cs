using System;

namespace Solvtio.Models
{
    public interface INombre
    {
        string Nombre { get; set; }
    }
    public interface IName : INombre
    {
        int Id { get; }
        string Nombre { get; set; }
    }

    public interface ITitulo
    {
        string Titulo { get; set; }
        DateTime Fecha { get; set; }
    }

    //public interface IPersona
    //{
    //    Gnr_Persona Persona { get; set; }
    //}

    //public interface IGnrPersona
    //{
    //    Gnr_Persona Gnr_Persona { get; set; }
    //}
}