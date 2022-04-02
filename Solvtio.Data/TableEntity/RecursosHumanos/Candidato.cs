using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Candidato")]
    public class Candidato : INombre
    {
        #region Constructors

        public Candidato()
        {
            CreateBase();
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCandidato { get; set; }
        public string NoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string UrlCv { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaAlta { get; set; }
        public int AniosExperiencia { get; set; }
        public decimal Salario { get; set; }
        public bool ClausulaSuelo { get; set; }
        public bool Demanda { get; set; }
        public bool Tramite { get; set; }
        public bool Subastas { get; set; }
        public bool Posesiones { get; set; }
        public bool FuncionNegociadora { get; set; }
        public bool Datos { get; set; }
        public bool Administracion { get; set; }
        public bool Internacional { get; set; }
        public bool GestorCarteraAlquiler { get; set; }
        public bool GestorCarteraHipotecario { get; set; }

        #endregion

        #region Properties ReadOnly

        public string NombreCompleto => $"{Nombre} {Apellido1} {Apellido2}".Trim();

        #endregion
    }
}