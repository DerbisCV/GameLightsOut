using Solvtio.Models;

namespace Solvtio.Data.Models.Dtos
{
    public class ModelDtoNombre
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class DtoIdNombre
    {
        public DtoIdNombre() { }
        public DtoIdNombre(int? id, string nombre)
        {
            Id = id ?? 0;
            Nombre = nombre;
        }
        public DtoIdNombre(IName model)
        {
            if (model == null) return;

            Id = model.Id;
            Nombre = model.Nombre;
        }
        public DtoIdNombre(IDescripcion model)
        {
            if (model == null) return;

            Id = model.Id;
            Nombre = model.Descripcion;
        }
        public DtoIdNombre(Gnr_Abogado model) : this(model?.Persona)
        {
            //if (model == null) return;
            
            //this(model.Persona);                
        }
        public DtoIdNombre(Gnr_Persona model)
        {
            if (model == null) return;

            Id = model.IdPersona;
            Nombre = model?.NombreApellidos;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
