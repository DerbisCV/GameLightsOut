using System;

namespace Solvtio.Models
{
    public interface INombre
    {
        string Nombre { get; set; }
    }

    public interface ITitulo
    {
        string Titulo { get; set; }
        DateTime Fecha { get; set; }
    }
}