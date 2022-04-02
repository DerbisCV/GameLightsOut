using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public partial class ModelCuadroDeMandoPorClienteOficina
	{
		#region Constructors

		public ModelCuadroDeMandoPorClienteOficina()
		{
			CreateBase();
		}
		public ModelCuadroDeMandoPorClienteOficina(int idClienteOficina)
		{
			CreateBase();
            Filter = new ModelFilterBase()
            {
                ClienteOficinaSelected = idClienteOficina
            };
		}
		public ModelCuadroDeMandoPorClienteOficina(ModelFilterBase filter)
		{
			CreateBase();
            Filter = filter;
		}
		public void CreateBase()
		{
            Filter = new ModelFilterBase();
            StaticHip = new ModelStaticByClient();
            StaticEjc = new ModelStaticByClient();
            StaticMnt = new ModelStaticByClient();
            StaticOrd = new ModelStaticByClient();
            StaticAlq = new ModelStaticByClient();
            StaticCon = new ModelStaticByClient();
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }

        public ModelStaticByClient StaticHip { get; set; }
        public ModelStaticByClient StaticEjc { get; set; }
        public ModelStaticByClient StaticMnt { get; set; }
        public ModelStaticByClient StaticOrd { get; set; }
        public ModelStaticByClient StaticAlq { get; set; }
        public ModelStaticByClient StaticCon { get; set; }


        //public int TotalExpHip { get; set; }
        //public int TotalExpHipFinalizados { get; set; }
        //public int TotalExpHipParalizados { get; set; }

        //public int TotalExpEjc { get; set; }
        //public int TotalExpEjcFinalizados { get; set; }
        //public int TotalExpEjcParalizados { get; set; }

        //public int TotalExpMnt { get; set; }
        //public int TotalExpMntFinalizados { get; set; }
        //public int TotalExpMntParalizados { get; set; }

        //public int TotalExpOrd { get; set; }
        //public int TotalExpOrdFinalizados { get; set; }
        //public int TotalExpOrdParalizados { get; set; }

        //public int TotalExpAlq { get; set; }
        //public int TotalExpAlqFinalizados { get; set; }
        //public int TotalExpAlqParalizados { get; set; }

        //public int TotalExpCon { get; set; }
        //public int TotalExpConFinalizados { get; set; }
        //public int TotalExpConParalizados { get; set; }


        #endregion

        #region Properties ReadOnly

        public int TotalExp => StaticHip.TotalExp + StaticEjc.TotalExp + StaticMnt.TotalExp + StaticOrd.TotalExp + StaticAlq.TotalExp + StaticCon.TotalExp;
        public int TotalExpActivos => StaticHip.TotalExpActivos + StaticEjc.TotalExpActivos + StaticMnt.TotalExpActivos + StaticOrd.TotalExpActivos + StaticAlq.TotalExpActivos + StaticCon.TotalExpActivos;
        public int TotalExpParalizados => StaticHip.TotalExpParalizados + StaticEjc.TotalExpParalizados + StaticMnt.TotalExpParalizados + StaticOrd.TotalExpParalizados + StaticAlq.TotalExpParalizados + StaticCon.TotalExpParalizados;
        public int TotalExpFinalizados => StaticHip.TotalExpFinalizados + StaticEjc.TotalExpFinalizados + StaticMnt.TotalExpFinalizados + StaticOrd.TotalExpFinalizados + StaticAlq.TotalExpFinalizados + StaticCon.TotalExpFinalizados;

        public int TotalDemandasPresentadas => StaticHip.TotalDemandasPresentadas + StaticEjc.TotalDemandasPresentadas + StaticMnt.TotalDemandasPresentadas + StaticOrd.TotalDemandasPresentadas + StaticAlq.TotalDemandasPresentadas + StaticCon.TotalDemandasPresentadas;

        public int TotalSubastaDecretoConvocatoria => StaticHip.TotalSubastaDecretoConvocatoria + StaticEjc.TotalSubastaDecretoConvocatoria + StaticMnt.TotalSubastaDecretoConvocatoria + StaticOrd.TotalSubastaDecretoConvocatoria + StaticAlq.TotalSubastaDecretoConvocatoria + StaticCon.TotalSubastaDecretoConvocatoria;
        public int TotalSubastaRealizadas => StaticHip.TotalSubastaRealizadas + StaticEjc.TotalSubastaRealizadas + StaticMnt.TotalSubastaRealizadas + StaticOrd.TotalSubastaRealizadas + StaticAlq.TotalSubastaRealizadas + StaticCon.TotalSubastaRealizadas;
        public int TotalPosesionesPositivas => StaticHip.TotalPosesionesPositivas + StaticEjc.TotalPosesionesPositivas + StaticMnt.TotalPosesionesPositivas + StaticOrd.TotalPosesionesPositivas + StaticAlq.TotalPosesionesPositivas + StaticCon.TotalPosesionesPositivas;
        public int FacturadoHito1 => StaticHip.FacturadoHito1 + StaticEjc.FacturadoHito1 + StaticMnt.FacturadoHito1 + StaticOrd.FacturadoHito1 + StaticAlq.FacturadoHito1 + StaticCon.FacturadoHito1;
        public int FacturadoHito2 => StaticHip.FacturadoHito2 + StaticEjc.FacturadoHito2 + StaticMnt.FacturadoHito2 + StaticOrd.FacturadoHito2 + StaticAlq.FacturadoHito2 + StaticCon.FacturadoHito2;

        #endregion

    }

    public class ModelStaticByClient
    {
        #region Properties

        public string Name { get; set; }

        public int TotalExp { get; set; }
        public int TotalExpFinalizados { get; set; }
        public int TotalExpParalizados { get; set; }

        public int TotalDemandasPresentadas { get; set; }
        public int TotalSubastaDecretoConvocatoria { get; set; }
        public int TotalSubastaRealizadas { get; set; }
        public int TotalPosesionesPositivas { get; set; }
        public int FacturadoHito1 { get; set; }
        public int FacturadoHito2 { get; set; }

        #endregion

        #region Properties ReadOnly

        public int TotalExpActivos => TotalExp - TotalExpFinalizados - TotalExpParalizados;

        #endregion

    }
}
