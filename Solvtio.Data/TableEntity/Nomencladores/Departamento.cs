using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class Departamento
    {
        public Departamento()
        {
            //PropuestaComercialSet = new List<PropuestaComercial>();
            FechaAlta = DateTime.Now;
            Activo = true;
        }

        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        public virtual ICollection<PropuestaComercial> PropuestaComercialSet { get; set; }
        public virtual ICollection<Gnr_Abogado> AbogadoSet { get; set; }
        public virtual ICollection<Usuario> UsuarioSet { get; set; }
    }
}
