namespace Solvtio.Models
{
    public class ModelDashboardFacturas
	{
		#region Constructor

		public ModelDashboardFacturas()
		{
			CreateBase();		
		}
		public ModelDashboardFacturas(TipoExpedienteEnum? tipoExpediente)
		{
			CreateBase();
            if (tipoExpediente.HasValue)
            {
			    Filter.IdTipoExpediente = (int)tipoExpediente;
			    Filter.TipoExpedienteSelected = tipoExpediente.Value;
            }
		}
        public ModelDashboardFacturas(TipoExpedienteEnum? tipoExpediente, int? idPersona)
        {
            CreateBase();
            if (tipoExpediente.HasValue)
            {
                Filter.IdTipoExpediente = (int)tipoExpediente;
                Filter.TipoExpedienteSelected = tipoExpediente.Value;
                Filter.IdUsuario = idPersona;
            }
        }
        public ModelDashboardFacturas(ModelFilterBase filter)
		{
			CreateBase();
			Filter = filter;
			if (Filter.IdTipoExpediente.HasValue)
				Filter.TipoExpedienteSelected = (TipoExpedienteEnum)Filter.IdTipoExpediente.Value;
		}

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
		}

		#endregion

		public ModelFilterBase Filter { get; set; }

		#region Hipotecario

		public int HipotecarioFacturaSolviaHito1 { get; set; } // PRESENTACIÓN DEMANDA
	    public int HipotecarioFacturaSolviaHito2 { get; set; } // DECRETO DE ADJUDICACIÓN
	    public int HipotecarioFacturaSolviaHito3 { get; set; } // FECHA TOMA DE POSESIÓN
	    public int HipotecarioFacturaSolviaHito4 { get; set; } //  SI CONTINUA POR EL  579 LEC:  40% ANOTADOS LOS EMBARGOS EN EL RP; 20% REALIZADA LA SUBASTA Y 40% OBTENIDA LA POSESIÓN.

	    public int HipotecarioFacturaSabadellHito1 { get; set; } // CIERRE DE SUBASTA
	    public int HipotecarioFacturaSabadellHito2 { get; set; } // FINALIZACIÓN(TESTIMONIO INSCRITO + POSESIÓN)
	    public int HipotecarioFacturaSabadellHito3 { get; set; } // MOTIVOS DE FINALIZACIÓN
	    public int HipotecarioFacturaSabadellHito4 { get; set; } // PARALIZADOS 

	    public int HipotecarioFacturaAnticipaHito1 { get; set; } // DECRETO DE ADJUDICACIÓN
        public int HipotecarioFacturaAnticipaHito2 { get; set; } // FINALIZACIÓN(TESTIMONIO INSCRITO + POSESIÓN)
	    public int HipotecarioFacturaAnticipaHito3 { get; set; } // MOTIVOS DE FINALIZACIÓN

	    public int HipotecarioFacturaSarebHito1 { get; set; } // 
	    public int HipotecarioFacturaSarebHito2 { get; set; } // 
	    public int HipotecarioFacturaSarebHito3 { get; set; } // 

        public int HipotecarioFacturaPostEjcHito1 { get; set; }

	    public int HipotecarioFacturaBankiaHito1 { get; set; }
	    public int HipotecarioFacturaBankiaHito2a { get; set; }
	    public int HipotecarioFacturaBankiaHito2b { get; set; }

	    public int? HipotecarioFacturaAlisedaNoVeniadoHito1 { get; set; }
	    public int? HipotecarioFacturaAlisedaNoVeniadoHito2 { get; set; }
	    public int? HipotecarioFacturaAlisedaNoVeniadoFinalizadosPdteFacturar { get; set; }

        public int? HipotecarioFacturaAlisedaVeniadoHito1 { get; set; }
        public int? HipotecarioFacturaAlisedaVeniadoHito2 { get; set; }
        public int? HipotecarioFacturaAlisedaVeniadoFinalizadosPdteFacturar { get; set; }

        public int HipotecarioFacturaAbancaHito1 { get; set; }
	    public int HipotecarioFacturaAbancaHito2 { get; set; }
	    public int HipotecarioFacturaAbancaHito3 { get; set; }

        public int? HipotecarioFacturaVoyagerAltamiraNoVeniadoHito1 { get; set; }
        public int? HipotecarioFacturaVoyagerAltamiraNoVeniadoHito2 { get; set; }
        public int? HipotecarioFacturaVoyagerAltamiraNoVeniadoHitoFinalizacion { get; set; }
        public int? HipotecarioFacturaVoyagerAltamiraVeniadoHito1 { get; set; }
        public int? HipotecarioFacturaVoyagerAltamiraVeniadoHitoFinalizacion { get; set; }

        public int? HipotecarioFinalizadoSinFactura { get; set; }
        public int? AlquilerFinalizadoSinFactura { get; set; }
        public int? OrdinarioFinalizadoSinFactura { get; set; }
        public int? EjecutivoFinalizadoSinFactura { get; set; }

        public int? FacturaHito1 { get; set; }
        public int? FacturaHito2 { get; set; }
        public int? FacturaHito3 { get; set; }
        public int? FacturaHito4 { get; set; }
        public int? FacturaHito5 { get; set; }
        public int? FacturaHito6 { get; set; }

        //public int? FacturaHito1Alq { get; set; }
        //public int? FacturaHito2Alq { get; set; }
        //public int? FacturaHito3Alq { get; set; }
        //public int? FacturaHito4Alq { get; set; }
        //public int? FacturaHito5Alq { get; set; }
        //public int? FacturaHito6Alq { get; set; }

        #endregion

        #region Alquiler 

        #region Altamira

        public int? AlquilerFacturaAltamiraHito1 { get; set; }
        public int? AlquilerFacturaEjcAltamiraHito1 { get; set; }

        //public int? AlquilerFacturaLuri4Hito1 { get; set; }
        //public int? AlquilerFacturaLuri6Hito1 { get; set; }
        //public int? AlquilerFacturaEjcLuri4Hito1 { get; set; }
        //public int? AlquilerFacturaEjcLuri6Hito1 { get; set; }
        //public int? AlquilerFacturaPdteAltamiraLuri46 { get; set; }

        #endregion

        #region Llogatalia

        public int? AlquilerFacturaLlogataliaHito1 { get; set; }
        public int? AlquilerFacturaLlogataliaHito2 { get; set; }
        public int? AlquilerFacturaEjcLlogataliaHito1 { get; set; }
        public int? AlquilerFacturaPdteLlogatalia { get; set; }

        #endregion

        #region MerlinRetail

        public int? AlquilerFacturaMerlinRetailHito1 { get; set; }
        public int? AlquilerFacturaMerlinRetailHito2 { get; set; }
        public int? AlquilerFacturaEjcMerlinRetailHito1 { get; set; }
        public int? AlquilerFacturaPdteMerlinRetail { get; set; }

        #endregion

        #region SolviaHoteles

        public int? AlquilerFacturaSolviaHotelesHito1 { get; set; }
        public int? AlquilerFacturaSolviaHotelesHito2 { get; set; }
        public int? AlquilerFacturaEjcSolviaHotelesHito1 { get; set; }
        public int? AlquilerFacturaPdteSolviaHoteles { get; set; }

        #endregion

        #region Azzam / Homes

        public int? AlquilerFacturaAzzamHito1 { get; set; }
        public int? AlquilerFacturaAzzamHito2 { get; set; }
        public int? AlquilerFacturaEjcAzzamHito1 { get; set; }

        public int? AlquilerFacturaHomesHito1 { get; set; }
        public int? AlquilerFacturaHomesHito2 { get; set; }
        public int? AlquilerFacturaEjcHomesHito1 { get; set; }

        #endregion

        #region Ahora Asset Management

        public int? AlquilerFacturaAhoraAssetManagementHito1 { get; set; }
        public int? AlquilerFacturaAhoraAssetManagementHito2 { get; set; }

        #endregion

        #region Anticipa 

        public int? AlquilerFacturaAnticipaHito1 { get; set; }
        public int? AlquilerFacturaAnticipaHito2 { get; set; }
        public int? AlquilerFacturaEjcAnticipaHito1 { get; set; }


        

        public int? AlquilerFacturaAnticipaHito2_ConVista_0_120 { get; set; }
        public int? AlquilerFacturaAnticipaHito2_SinVista_0_120 { get; set; }
        public int? AlquilerFacturaAnticipaHito2_ConVista_121_180 { get; set; }
        public int? AlquilerFacturaAnticipaHito2_SinVista_121_180 { get; set; }
        public int? AlquilerFacturaAnticipaHito2_ConVista_181 { get; set; }
        public int? AlquilerFacturaAnticipaHito2_SinVista_181 { get; set; }
        public int? AlquilerFacturaAnticipaHito3 { get; set; }
        public int? AlquilerFacturaEjcAnticipaHito2 { get; set; }

        #endregion

        public int? AlquilerFacturaAlisedaHito1 { get; set; }
        public int? AlquilerFacturaAlisedaHito2 { get; set; }
        public int? AlquilerFacturaEjcAlisedaHito1 { get; set; }
        public int? AlquilerFacturaPdteAliseda { get; set; }

        public int? AlquilerFacturaFidereHito1 { get; set; }
        public int? AlquilerFacturaFidereHito2 { get; set; }
        public int? AlquilerFacturaEjcFidereHito1 { get; set; }
        public int? AlquilerFacturaPdteFidere { get; set; }


        public int? AlquilerFacturasHito1 { get; set; }
        public int? AlquilerFacturasHito2 { get; set; }

        #endregion

        #region Conciliacion

        public int? ConciliacionFacturasHito1Caixa { get; set; }

        #endregion

        #region Ordinario

        public int? OrdinarioFacturasHito1Caixa { get; set; }

        #endregion

        #region OrdinarioCs

        public int? OrdinarioCsFacturasBancoPopularHito1 { get; set; }
	    public int? OrdinarioCsFacturasBancoPopularHito2 { get; set; }
        public int? OrdinarioCsFacturasHito2PendienteFinalizar { get; set; }

        #endregion

        #region TPA

        public int TpaFacturasPendientesHito1 { get; set; }
	    public int TpaFacturasPendientesHito2 { get; set; }

        #endregion

        #region JC

        public int JcFacturasPendientesHito1 { get; set; }
        public int JcFacturasPendientesHito1ConHito2 { get; set; }
        public int JcFacturasPendientesHito2 { get; set; }

        #endregion

        #region Concursal (ReI, MyC)

        public int? MyCFacturasPendientesHito1 { get; set; }

        public int? MyCFacturasAbanca52 { get; set; }

        #endregion

        #region Monitorio

        public int? MonitorioFacturaHito1 { get; set; }

        #endregion

        #region Procura

        public int? ProcuraFacturasHito1 { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion
    }
}
