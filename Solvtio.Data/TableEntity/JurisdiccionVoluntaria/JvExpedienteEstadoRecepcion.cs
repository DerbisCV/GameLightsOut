using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("JvExpedienteEstadoRecepcion")]
    public class JvExpedienteEstadoRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public JvExpedienteEstadoRecepcion() { }
        public JvExpedienteEstadoRecepcion(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }

        //public bool TituloEjecutivo { get; set; }
        //public bool TituloInscrito { get; set; }
        //public bool BurofaxesEnviados { get; set; }
        //public bool BurofaxesFiadores { get; set; }
        //public bool PagosCuenta { get; set; }
        //public bool CantidadesConsignar { get; set; }
        //public bool NotaSimple { get; set; }
        //public bool JurisdiccionVoluntaria { get; set; }

        #endregion
    }
}
