using Solvtio.Models.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    [Table("ClienteObjetivo")]
    public partial class ClienteObjetivo
    {
        #region Constructors

        public ClienteObjetivo() { }
        public ClienteObjetivo(int idCliente) : this()
        {
            IdCliente = idCliente;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClienteObjetivo { get; set; }

        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Gnr_Cliente Cliente { get; set; }

        public int? IdAreaNegocio { get; set; }
        [ForeignKey("IdAreaNegocio")]
        public virtual AreaNegocio AreaNegocio { get; set; }

        public int Year { get; set; }
        public decimal ImportePlaneado { get; set; }
        public decimal? ImporteConseguido { get; set; }

        public PlanReal Mes01 { get; set; }
        public PlanReal Mes02 { get; set; }
        public PlanReal Mes03 { get; set; }
        public PlanReal Mes04 { get; set; }
        public PlanReal Mes05 { get; set; }
        public PlanReal Mes06 { get; set; }
        public PlanReal Mes07 { get; set; }
        public PlanReal Mes08 { get; set; }
        public PlanReal Mes09 { get; set; }
        public PlanReal Mes10 { get; set; }
        public PlanReal Mes11 { get; set; }
        public PlanReal Mes12 { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        #endregion

        #region Methods

        internal void Refresh(ClienteObjetivo modelBase)
        {
            //ImportePlaneado = modelBase.ImportePlaneado;
        }

        #endregion
    }

    public class PlanReal
    {
        public decimal? Plan { get; set; }
        public decimal? Real { get; set; }

        public PlanReal() {}
        public PlanReal(IEnumerable<ClienteObjetivo> queryFiltered, int month) : this()
        {
            switch (month)
            {
                case 1:
                    Plan = queryFiltered.Sum(x => x.Mes01.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes01.Real ?? 0);
                    break;
                case 2:
                    Plan = queryFiltered.Sum(x => x.Mes02.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes02.Real ?? 0);
                    break;
                case 3:
                    Plan = queryFiltered.Sum(x => x.Mes03.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes03.Real ?? 0);
                    break;
                case 4:
                    Plan = queryFiltered.Sum(x => x.Mes04.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes04.Real ?? 0);
                    break;
                case 5:
                    Plan = queryFiltered.Sum(x => x.Mes05.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes05.Real ?? 0);
                    break;
                case 6:
                    Plan = queryFiltered.Sum(x => x.Mes06.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes06.Real ?? 0);
                    break;
                case 7:
                    Plan = queryFiltered.Sum(x => x.Mes07.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes07.Real ?? 0);
                    break;
                case 8:
                    Plan = queryFiltered.Sum(x => x.Mes08.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes08.Real ?? 0);
                    break;
                case 9:
                    Plan = queryFiltered.Sum(x => x.Mes09.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes09.Real ?? 0);
                    break;
                case 10:
                    Plan = queryFiltered.Sum(x => x.Mes10.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes10.Real ?? 0);
                    break;
                case 11:
                    Plan = queryFiltered.Sum(x => x.Mes11.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes11.Real ?? 0);
                    break;
                case 12:
                    Plan = queryFiltered.Sum(x => x.Mes12.Plan ?? 0);
                    Real = queryFiltered.Sum(x => x.Mes12.Real ?? 0);
                    break;

                default:
                    break;
            }
        }

    }
}
