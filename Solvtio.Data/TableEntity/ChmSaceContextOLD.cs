using Microsoft.EntityFrameworkCore;
using Solvtio.Models.Common;
using System.Linq;
using Solvtio.Data;

namespace Solvtio.Models
{
    public class ChmSaceContext : DbContext
    {
        #region Constructors

        //static ChmSaceContext()
        //{
        //    //Database.SetInitializer<ChmSaceContext>(null);
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChmSaceContext, Migrations.Configuration>());
        //}

        //public ChmSaceContext()
        //    : base("Name=ChmSaceContext")
        //{
        //}

        //public ChmSaceContext(string connectionString) : base(connectionString)
        //{
        //}

        #endregion

        #region Override Methods / OnModelCreating

        public override int SaveChanges()
        {
            AuditPreSaveChange();
            return base.SaveChanges();
        }

        private void AuditPreSaveChange()
        {
            var modifiedEntries = ChangeTracker
                .Entries()
                .Where(x =>
                        //(x.Entity is IAuditable || x.Entity is IAuditableMin)
                        //&& (
                        x.State == EntityState.Added
                        || x.State == EntityState.Modified
                //)
                );

            foreach (var entry in modifiedEntries.Where(x => x.Entity is IAuditableMin))
            {
                var entity = entry.Entity as IAuditableMin;
                if (entity != null) entity.Audit();
            }

            foreach (var entry in modifiedEntries.Where(x => x.Entity is IAuditable))
            {
                var entity = entry.Entity as IAuditable;
                if (entity != null)
                {
                    if (entry.State == EntityState.Added) entity.Audit(true);
                    if (entry.State == EntityState.Modified) entity.Audit(false);
                    //if (entry.State == EntityState.Added) entity.Audit(true, _httpContextAccessor);
                    //if (entry.State == EntityState.Modified) entity.Audit(false, _httpContextAccessor);
                }
            }

            if (!modifiedEntries.Any(x => x.Entity is Expediente))
            {
                foreach (var entry in modifiedEntries.Where(x => x.Entity is IExpedienteEstado))
                {
                    var entity = entry.Entity as IExpedienteEstado;
                    var expediente = Expedientes.FirstOrDefault(x => x.IdExpediente == entity.IdExpediente);
                    if (expediente != null) expediente.Audit();
                }
            }
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    #region Evaluacion del Desempeño

        //    modelBuilder
        //        .Entity<Usuario>()
        //        .HasMany(i => i.EvaluacionEmpleadoSet)
        //        .WithRequired()
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Pagador>()
        //        .HasMany(p => p.ClienteSet)
        //        .WithMany(c => c.Pagadores)
        //        .Map(pc =>
        //        {
        //            pc.MapLeftKey("IdPagador");
        //            pc.MapRightKey("IdCliente");
        //            pc.ToTable("PagadorCliente");
        //        });

        //    #endregion

        //    #region JV

        //    modelBuilder.Entity<JvExpedienteEstadoRecepcion>()
        //        .HasKey(t => t.IdExpedienteEstado)
        //        .Property(t => t.IdExpedienteEstado).ValueGeneratedNever();
        //    modelBuilder.Entity<JvExpedienteEstadoRecepcion>()
        //        .//HasRequired(t => t.ExpedienteEstado)
        //        //  .WithOptional(t => t.JvExpedienteEstadoRecepcion);

        //    modelBuilder.Entity<JvExpedienteEstadoPresentacionDemanda>()
        //        .HasKey(t => t.IdExpedienteEstado)
        //        .Property(t => t.IdExpedienteEstado).ValueGeneratedNever();
        //    modelBuilder.Entity<JvExpedienteEstadoPresentacionDemanda>()
        //        .//HasRequired(t => t.ExpedienteEstado)
        //        //  .WithOptional(t => t.JvExpedienteEstadoPresentacionDemanda);

        //    #endregion

        //    #region OLDs

        //    modelBuilder.Configurations.Add(new AccionFlujoMap());
        //    modelBuilder.Configurations.Add(new AlertaDestinatarioMap());
        //    modelBuilder.Configurations.Add(new AlertaSupervisorMap());
        //    modelBuilder.Configurations.Add(new Alq_ExpedienteMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_ContratosMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_Contratos_Deuda_LineasMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_Contratos_PlanPagos_LineasMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_EstadoAdjudicacionMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_EstadoFinalizacionMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_EstadoLanzamientoMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_EstadoPresentacionDemandaMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_EstadoRecepcionMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_EstadoTramitaJuzgadoMap());
        //    modelBuilder.Configurations.Add(new Alq_Expediente_EstadoTramitaJuzgado_ActuacionesMap());
        //    modelBuilder.Configurations.Add(new aspnet_ApplicationsMap());
        //    modelBuilder.Configurations.Add(new aspnet_MembershipMap());
        //    modelBuilder.Configurations.Add(new aspnet_PathsMap());
        //    modelBuilder.Configurations.Add(new aspnet_PersonalizationAllUsersMap());
        //    modelBuilder.Configurations.Add(new aspnet_PersonalizationPerUserMap());
        //    modelBuilder.Configurations.Add(new aspnet_ProfileMap());
        //    modelBuilder.Configurations.Add(new aspnet_RolesMap());
        //    modelBuilder.Configurations.Add(new aspnet_SchemaVersionsMap());
        //    modelBuilder.Configurations.Add(new aspnet_UsersMap());
        //    modelBuilder.Configurations.Add(new aspnet_WebEvent_EventsMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteAdministradorMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteCreditoMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteCreditoCalificacionMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteCreditoGarantiaAvalistaMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteCreditoGarantiaInmueblesMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteCreditoGarantiaOtrosMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteEstadoComunMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteEstadoConvenioMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteEstadoFinalizadoMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteEstadoLiquidacionMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteEstadoLiquidacionLoteMap());
        //    modelBuilder.Configurations.Add(new Con_ExpedienteIncidenteMap());
        //    modelBuilder.Configurations.Add(new Con_TipoCalificacionMap());
        //    modelBuilder.Configurations.Add(new Con_TipoCalificacionTiempoMap());
        //    modelBuilder.Configurations.Add(new Con_TipoFaseMap());
        //    modelBuilder.Configurations.Add(new Con_TipoIncidenteMap());
        //    modelBuilder.Configurations.Add(new ConfiguracionMap());
        //    modelBuilder.Configurations.Add(new DepartamentoMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoAdjudicacionMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoEfectividadEmbargoMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoFinalizacionMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoNotificacionMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoPresentacionDemandaMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoRecepcionMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoRequerimientoPagoMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoSolicitudSubastaMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoSubastaMap());
        //    modelBuilder.Configurations.Add(new Ejc_ExpedienteEstadoTramiteEmbargoMap());
        //    modelBuilder.Configurations.Add(new ExpedienteMap());
        //    modelBuilder.Configurations.Add(new ExpedienteAccionMap());
        //    modelBuilder.Configurations.Add(new ExpedienteAcreedoreMap());
        //    modelBuilder.Configurations.Add(new ExpedienteAlertaMap());
        //    modelBuilder.Configurations.Add(new ExpedienteDeudorMap());
        //    modelBuilder.Configurations.Add(new ExpedienteDocumentoMap());
        //    modelBuilder.Configurations.Add(new ExpedienteEstadoMap());
        //    modelBuilder.Configurations.Add(new ExpedienteFacturaMap());
        //    modelBuilder.Configurations.Add(new ExpedienteGastoMap());
        //    modelBuilder.Configurations.Add(new ExpedienteIngresoMap());
        //    modelBuilder.Configurations.Add(new ExpedienteVistaMap());
        //    modelBuilder.Configurations.Add(new FacturaMap());
        //    modelBuilder.Configurations.Add(new FileRecordMap());
        //    modelBuilder.Configurations.Add(new Gnr_AbogadoMap());
        //    modelBuilder.Configurations.Add(new Gnr_ClienteMap());
        //    modelBuilder.Configurations.Add(new Gnr_ClienteOficinaMap());
        //    modelBuilder.Configurations.Add(new Gnr_JuzgadoMap());
        //    modelBuilder.Configurations.Add(new Gnr_ListasValores_ListasMap());
        //    modelBuilder.Configurations.Add(new Gnr_ListasValores_ValoresMap());
        //    modelBuilder.Configurations.Add(new Gnr_PersonaMap());
        //    modelBuilder.Configurations.Add(new Gnr_PersonaDireccionMap());
        //    modelBuilder.Configurations.Add(new Gnr_PersonaExpedienteMap());
        //    modelBuilder.Configurations.Add(new Gnr_PersonaTelefonoMap());
        //    modelBuilder.Configurations.Add(new Gnr_PlantillasDocMap());
        //    modelBuilder.Configurations.Add(new Gnr_ProcuradorMap());
        //    modelBuilder.Configurations.Add(new GNR_ProcuradoresMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoAlertaMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoAreaMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoDeudorMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoDireccionMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoEstadoMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoEstadoClienteMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoEstadoMotivoMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoExpedienteMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoExpedienteDocumentoMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoIdentidadMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoPersonaMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoTelefonoMap());
        //    modelBuilder.Configurations.Add(new Gnr_TipoTratamientoMap());
        //    modelBuilder.Configurations.Add(new Gnr_ValijaMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoAdjudicacionMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoDatoRequerimientoMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoFinalizacionMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoNegociacionPosesionMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoPresentacionDemandaMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoProcesoParalizadoMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoRecepcionMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoSubastaMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteEstadoTramitacionJuzgadoMap());
        //    modelBuilder.Configurations.Add(new Hip_ExpedienteGarantiaMap());
        //    modelBuilder.Configurations.Add(new Hip_HipotecaMap());
        //    modelBuilder.Configurations.Add(new Hip_HipotecaDatoEscrituraMap());
        //    modelBuilder.Configurations.Add(new Hip_HipotecaPagoACuentaMap());
        //    modelBuilder.Configurations.Add(new Hip_InmuebleMap());
        //    modelBuilder.Configurations.Add(new Hip_PartidoJudicialMap());
        //    modelBuilder.Configurations.Add(new HIP_PartidosJudicialesMap());
        //    modelBuilder.Configurations.Add(new Hip_TipoDemandaMap());
        //    modelBuilder.Configurations.Add(new Hip_TipoInmuebleMap());
        //    modelBuilder.Configurations.Add(new Hip_TipoLugarEjecucionMap());
        //    modelBuilder.Configurations.Add(new Hip_TipoPeriodicidadMap());
        //    modelBuilder.Configurations.Add(new Hip_TipoReferenciaHipotecariaMap());
        //    modelBuilder.Configurations.Add(new Hip_TipoSubastaMap());
        //    modelBuilder.Configurations.Add(new Hip_TipoTitulizadoMap());
        //    modelBuilder.Configurations.Add(new Hip_TitularInmuebleMap());
        //    modelBuilder.Configurations.Add(new Mnt_ExpedienteMap());
        //    modelBuilder.Configurations.Add(new Neg_GestionMap());
        //    modelBuilder.Configurations.Add(new Neg_GestionEstadoMap());
        //    modelBuilder.Configurations.Add(new ProcuradoresClienteMap());
        //    modelBuilder.Configurations.Add(new ProcuradorPartidoJudicialMap());
        //    modelBuilder.Configurations.Add(new PropuestaComercialMap());
        //    modelBuilder.Configurations.Add(new RolePermissionMap());
        //    modelBuilder.Configurations.Add(new sysdiagramMap());
        //    modelBuilder.Configurations.Add(new TipoAccionMap());
        //    modelBuilder.Configurations.Add(new TipoCalificacionCreditoTiempoMap());
        //    modelBuilder.Configurations.Add(new TipoClasificacionCreditoMap());
        //    modelBuilder.Configurations.Add(new TipoExpedienteAccionMap());
        //    modelBuilder.Configurations.Add(new TipoFormaPagoMap());
        //    modelBuilder.Configurations.Add(new TipoGarantiaMap());
        //    modelBuilder.Configurations.Add(new TipoVistaMap());
        //    modelBuilder.Configurations.Add(new Hip_Hipoteca_EnEjecucion_ViewMap());
        //    modelBuilder.Configurations.Add(new vAlq_DEMANDAMap());
        //    modelBuilder.Configurations.Add(new vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLastMap());
        //    modelBuilder.Configurations.Add(new vAlq_InformeTotalPMap());
        //    modelBuilder.Configurations.Add(new vExpedienteDeudorPrincipalMap());
        //    modelBuilder.Configurations.Add(new vGnr_NombresCamposMap());
        //    modelBuilder.Configurations.Add(new vGnr_PlantillaDoc_ALQUILER_BUROFAXMap());
        //    modelBuilder.Configurations.Add(new vHip_HipotecaEnEjecucionMap());
        //    modelBuilder.Configurations.Add(new vHipotecaPrincipalMap());
        //    modelBuilder.Configurations.Add(new View_1Map());
        //    modelBuilder.Configurations.Add(new View_5Map());
        //    modelBuilder.Configurations.Add(new vInmueblePrincipalMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_ApplicationsMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_MembershipUsersMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_ProfilesMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_RolesMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_UsersMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_UsersInRolesMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_PathsMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_SharedMap());
        //    modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_UserMap());

        //    #endregion
        //}

        #endregion

        #region Tablas Comunes

        public DbSet<NotificacionMail> NotificacionMailSet { get; set; }
        public DbSet<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }
        public DbSet<NotificacionMailAsignacion> NotificacionMailAsignacionSet { get; set; }
        public DbSet<NotificacionMailTimeline> NotificacionMailTimelineSet { get; set; }
        public DbSet<NotificacionBuzon> NotificacionBuzonSet { get; set; }

        public DbSet<TipoNotificacion> TipoNotificacionSet { get; set; }
        public DbSet<TipoAreaNotificacion> TipoAreaNotificacionSet { get; set; }
        public DbSet<Holiday> HolidaySet { get; set; }
        public DbSet<JobResult> JobResultSet { get; set; }

        public DbSet<ActividadAbogado> ActividadAbogadoSet { get; set; }
        public DbSet<ActividadAbogadoDetalle> ActividadAbogadoDetalleSet { get; set; }

        #endregion

        #region Usuario

        public DbSet<Usuario> UsuarioSet { get; set; }
        public DbSet<UsuarioRole> UsuarioRoleSet { get; set; }

        public DbSet<Role> RoleSet { get; set; }
        public DbSet<RolePage> RolePageSet { get; set; }
        public DbSet<UsuarioLog> UsuarioLogSet { get; set; }
        public DbSet<Grupo> GrupoSet { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuarioSet { get; set; }
        public DbSet<Nomina> NominaSet { get; set; }

        #endregion

        #region Nomencladores

        public DbSet<ComunidadAutonoma> ComunidadAutonomaSet { get; set; }
        public DbSet<Provincia> ProvinciaSet { get; set; }
        public DbSet<Municipio> MunicipioSet { get; set; }
        public DbSet<CodigoPostal> CodigoPostalSet { get; set; }

        public DbSet<Juzgado> JuzgadoSet { get; set; }
        public DbSet<TramiteJudicial> TramiteJudicialSet { get; set; }
        public DbSet<JuzgadoTramiteJudicial> JuzgadoTramiteJudicialSet { get; set; }
        public DbSet<Area> AreaSet { get; set; }
        public DbSet<AreaNegocio> AreaNegocioSet { get; set; }
        public DbSet<HitoFacturacion> HitoFacturacionSet { get; set; }
        public DbSet<CaracteristicaBase> CaracteristicaBaseSet { get; set; }
        public DbSet<Sla> SlaSet { get; set; }
        public DbSet<SlaOficina> SlaOficinaSet { get; set; }
        public DbSet<TipoSubFaseEstado> TipoSubFaseEstadoSet { get; set; }
        public DbSet<TipoIncidenciaEstado> TipoIncidenciaEstadoSet { get; set; }
        public DbSet<Cartera> CarteraSet { get; set; }
        public DbSet<EntidadGestora> EntidadGestoraSet { get; set; }
        public DbSet<EntidadGestoraGestor> EntidadGestoraGestorSet { get; set; }
        public DbSet<FacturadorRegla> FacturadorReglaSet { get; set; }
        public DbSet<Proveedor> ProveedorSet { get; set; }
        public DbSet<Informe> InformeSet { get; set; }

        #endregion

        #region Facturacion

        public DbSet<Hito> HitoSet { get; set; }
        public DbSet<HitoExpediente> HitoExpedienteSet { get; set; }
        public DbSet<ContratoFactura> ContratoFacturaSet { get; set; }
        public DbSet<ContratoFacturaCondicion> ContratoFacturaCondicionSet { get; set; }

        #endregion

        #region Expediente - Hijos Comunes

        public DbSet<ExpedienteNegociacion> ExpedienteNegociacionSet { get; set; }
        public DbSet<ExpedienteJurisdiccionVoluntaria> ExpedienteJurisdiccionVoluntariaSet { get; set; }
        public DbSet<ExpedienteInscripcionCredito> ExpedienteInscripcionCreditoSet { get; set; }
        public DbSet<ExpedienteEscritura> ExpedienteEscrituraSet { get; set; }
        public DbSet<ExpedienteSubasta> ExpedienteSubastaSet { get; set; }
        public DbSet<ExpedienteNota> ExpedienteNotaSet { get; set; }
        public DbSet<ExpedienteHito> ExpedienteHitoSet { get; set; }
        public DbSet<Impulso> ImpulsoSet { get; set; }
        public DbSet<Actuacion> ActuacionSet { get; set; }
        public DbSet<Mediacion> MediacionSet { get; set; }
        public DbSet<ExpedienteHitoProcesal> ExpedienteHitoProcesalSet { get; set; }
        public DbSet<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }
        public DbSet<ExpedienteParalizado> ExpedienteParalizadoSet { get; set; }
        public DbSet<ExpedientePrestamo> ExpedientePrestamoSet { get; set; }
        public DbSet<ExpedienteHora> ExpedienteHoraSet { get; set; }
        public DbSet<ExpedienteContrato> ExpedienteContratoSet { get; set; }
        public DbSet<ExpedienteContratoRecuperacion> ExpedienteContratoRecuperacionSet { get; set; }
        public DbSet<ExpedienteContratoDeudaDesglose> ExpedienteContratoDeudaDesgloseSet { get; set; }
        public DbSet<ExpedienteResolucionJudicial> ExpedienteResolucionJudicialSet { get; set; }
        public DbSet<ExpedienteAcuerdo> ExpedienteAcuerdoSet { get; set; }
        public DbSet<ExpedienteRecursoReposicion> ExpedienteRecursoReposicionSet { get; set; }

        public DbSet<ExpedienteFaseCliente> ExpedienteFaseClienteSet { get; set; }
        public DbSet<FaseCliente> FaseClienteSet { get; set; }
        public DbSet<MotivoCliente> MotivoClienteSet { get; set; }

        #endregion

        #region ExpedienteEstado

        public DbSet<ExpedienteEstadoCitacion> ExpedienteEstadoCitacionSet { get; set; }
        public DbSet<ExpedienteEstadoAbogadoHistorico> ExpedienteEstadoAbogadoHistoricoSet { get; set; }
        public DbSet<ExpedienteEstadoParalizado> ExpedienteEstadoParalizadoSet { get; set; }
        public DbSet<ExpedienteEstadoJurisdiccionVoluntaria> ExpedienteEstadoJurisdiccionVoluntariaSet { get; set; }

        #endregion

        #region ExpedienteOrdinario

        public DbSet<ExpedienteOrdinario> ExpedienteOrdinarioSet { get; set; }

        public DbSet<ExpedienteEstadoOrdinarioRecepcion> ExpedienteEstadoOrdinarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioPresentacionDemanda> ExpedienteEstadoOrdinarioPresentacionDemandaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioTramitacionJuzgado> ExpedienteEstadoOrdinarioTramitacionJuzgadoSet { get; set; }
        //public DbSet<ExpedienteEstadoOrdinarioDatoRequerimiento> ExpedienteEstadoOrdinarioDatoRequerimientoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioProcesoParalizado> ExpedienteEstadoOrdinarioProcesoParalizadoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioSubasta> ExpedienteEstadoOrdinarioSubastaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioAdjudicacion> ExpedienteEstadoOrdinarioAdjudicacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioNegociacionPosesion> ExpedienteEstadoOrdinarioNegociacionPosesionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioFinalizacion> ExpedienteEstadoOrdinarioFinalizacionSet { get; set; }

        public DbSet<ExpedienteEstadoOrdinarioJuicio> ExpedienteEstadoOrdinarioJuicioSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioAutoAdmisionNotificacion> ExpedienteEstadoOrdinarioAutoAdmisionNotificacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioSentencia> ExpedienteEstadoOrdinarioSentenciaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioEjecucionSentencia> ExpedienteEstadoOrdinarioEjecucionSentenciaSet { get; set; }

        #endregion

        #region ExpedienteOrdinarioCs 

        public DbSet<ExpedienteOrdinarioCs> ExpedienteOrdinarioCsSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsRecepcion> ExpedienteEstadoOrdinarioCsRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAudienciaPrevia> ExpedienteEstadoOrdinarioCsAudienciaPreviaSet { get; set; }

        public DbSet<ExpedienteEstadoOrdinarioCsTramitacionJuzgado> ExpedienteEstadoOrdinarioCsTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsProcesoParalizado> ExpedienteEstadoOrdinarioCsProcesoParalizadoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsSubasta> ExpedienteEstadoOrdinarioCsSubastaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAdjudicacion> ExpedienteEstadoOrdinarioCsAdjudicacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsNegociacionPosesion> ExpedienteEstadoOrdinarioCsNegociacionPosesionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsFinalizacion> ExpedienteEstadoOrdinarioCsFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsJuicio> ExpedienteEstadoOrdinarioCsJuicioSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion> ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsEjecucionSentencia> ExpedienteEstadoOrdinarioCsEjecucionSentenciaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsSentencia> ExpedienteEstadoOrdinarioCsSentenciaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAllanamientoTotal> ExpedienteEstadoOrdinarioCsAllanamientoTotalSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAllanamientoParcial> ExpedienteEstadoOrdinarioCsAllanamientoParcialSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAcuerdo> ExpedienteEstadoOrdinarioCsAcuerdoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsContestacionDemanda> ExpedienteEstadoOrdinarioCsContestacionDemandaSet { get; set; }

        #endregion

        #region Hipotecario

        public DbSet<HipExpedienteEstadoGeneracion> HipExpedienteEstadoGeneracionSet { get; set; }

        public DbSet<Hip_ExpedienteEstadoAdjudicacionVencimiento> Hip_ExpedienteEstadoAdjudicacionVencimientoSet { get; set; }

        #endregion

        #region Alquiler

        public DbSet<AlqExpedienteEstadoEnervacion> AlqExpedienteEstadoEnervacionSet { get; set; }
        public DbSet<AlqExpedienteEstadoEnervacionPago> AlqExpedienteEstadoEnervacionPagoSet { get; set; }
        public DbSet<AlqExpedienteEstadoProcesoParalizado> AlqExpedienteEstadoProcesoParalizadoSet { get; set; }
        public DbSet<AlqExpedienteEstadoPresentacionDenuncia> AlqExpedienteEstadoPresentacionDenunciaSet { get; set; }
        public DbSet<AlqExpedienteEstadoTramitacionDenuncia> AlqExpedienteEstadoTramitacionDenunciaSet { get; set; }

        #endregion

        #region Ejecutivo

        public DbSet<Ejc_Expediente> Ejc_Expediente { get; set; }
        public DbSet<Ejc_ExpedienteEstadoAdjudicacion> Ejc_ExpedienteEstadoAdjudicacionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoEfectividadEmbargo> Ejc_ExpedienteEstadoEfectividadEmbargoSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoFinalizacion> Ejc_ExpedienteEstadoFinalizacionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoNotificacion> Ejc_ExpedienteEstadoNotificacionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoPresentacionDemanda> Ejc_ExpedienteEstadoPresentacionDemandaSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoRecepcion> Ejc_ExpedienteEstadoRecepcionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoRequerimientoPago> Ejc_ExpedienteEstadoRequerimientoPagoSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoSolicitudSubasta> Ejc_ExpedienteEstadoSolicitudSubastaSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoSubasta> Ejc_ExpedienteEstadoSubastaSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoTramiteEmbargo> Ejc_ExpedienteEstadoTramiteEmbargoSet { get; set; }

        public DbSet<EjcExpedienteEstadoEnvioDemandaProcurador> EjcExpedienteEstadoEnvioDemandaProcuradorSet { get; set; }
        public DbSet<EjcExpedienteEstadoPresentacionEscrito579> EjcExpedienteEstadoPresentacionEscrito579Set { get; set; }

        public DbSet<ExpedienteDeudorEjcutivo> ExpedienteDeudorEjcutivoSet { get; set; }
        public DbSet<ExpedienteDeudorEjcutivoAveriguacion> ExpedienteDeudorEjcutivoAveriguacionSet { get; set; }
        public DbSet<ExpedienteDeudorMueble> ExpedienteDeudorMuebleSet { get; set; }
        //public DbSet<ExpedienteDeudorInmueble> ExpedienteDeudorInmuebleSet { get; set; }
        public DbSet<ExpedienteDeudorSalarioSaldo> ExpedienteDeudorSalarioSaldoSet { get; set; }


        public DbSet<ExpedienteSalarioSaldo> ExpedienteSalarioSaldoSet { get; set; }
        public DbSet<ExpedienteMueble> ExpedienteMuebleSet { get; set; }

        #endregion

        #region JV 

        public DbSet<ExpedienteJV> ExpedienteJVSet { get; set; }
        public DbSet<JvExpedienteEstadoRecepcion> JvExpedienteEstadoRecepcionSet { get; set; }
        public DbSet<JvExpedienteEstadoPresentacionDemanda> JvExpedienteEstadoPresentacionDemandaSet { get; set; }

        #endregion

        #region Monitorio

        public DbSet<ExpedienteMonitorio> ExpedienteMonitorioSet { get; set; }

        public DbSet<ExpedienteEstadoMonitorioRecepcion> ExpedienteEstadoMonitorioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoMonitorioPresentacionDemanda> ExpedienteEstadoMonitorioPresentacionDemandaSet { get; set; }
        public DbSet<ExpedienteEstadoMonitorioTramitacionJuzgado> ExpedienteEstadoMonitorioTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoMonitorioFinalizacion> ExpedienteEstadoMonitorioFinalizacionSet { get; set; }

        #endregion

        #region Verbal

        public DbSet<ExpedienteVerbal> ExpedienteVerbalSet { get; set; }

        public DbSet<ExpedienteEstadoVerbalRecepcion> ExpedienteEstadoVerbalRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoVerbalPresentacionDemanda> ExpedienteEstadoVerbalPresentacionDemandaSet { get; set; }
        public DbSet<ExpedienteEstadoVerbalTramitacionJuzgado> ExpedienteEstadoVerbalTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoVerbalFinalizacion> ExpedienteEstadoVerbalFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteMultiDivisa

        public DbSet<ExpedienteMultiDivisa> ExpedienteMultiDivisaSet { get; set; }

        public DbSet<ExpedienteEstadoMDRecepcion> ExpedienteEstadoMDRecepcionSet { get; set; }

        #endregion

        #region ExpedienteProcura

        public DbSet<ExpedienteProcura> ExpedienteProcuraSet { get; set; }

        public DbSet<ExpedienteEstadoProcuraRecepcion> ExpedienteEstadoProcuraRecepcionSet { get; set; }
        //public DbSet<ExpedienteEstadoProcuraFinalizacion> ExpedienteEstadoProcuraFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteScne

        public DbSet<ExpedienteScne> ExpedienteScneSet { get; set; }

        //public DbSet<ExpedienteEstadoScneRecepcion> ExpedienteEstadoScneRecepcionSet { get; set; }
        //public DbSet<ExpedienteEstadoScneFinalizacion> ExpedienteEstadoScneFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteBastanteo

        public DbSet<ExpedienteBastanteo> ExpedienteBastanteoSet { get; set; }

        public DbSet<ExpedienteEstadoBastanteoRecepcion> ExpedienteEstadoBastanteoRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoBastanteoFinalizacion> ExpedienteEstadoBastanteoFinalizacionSet { get; set; }

        #endregion

        #region ExpedientePrelitigio

        public DbSet<ExpedientePrelitigio> ExpedientePrelitigioSet { get; set; }
        public DbSet<ExpedienteDeudorBurofax> ExpedienteDeudorBurofaxSet { get; set; }

        public DbSet<ExpedienteEstadoPrelitigioRecepcion> ExpedienteEstadoPrelitigioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoPrelitigioFinalizacion> ExpedienteEstadoPrelitigioFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteTestamentario

        public DbSet<ExpedienteTestamentario> ExpedienteTestamentarioSet { get; set; }

        public DbSet<ExpedienteEstadoTestamentarioRecepcion> ExpedienteEstadoTestamentarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoTestamentarioFinalizacion> ExpedienteEstadoTestamentarioFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteTpn

        public DbSet<ExpedienteTpn> ExpedienteTpnSet { get; set; }
        public DbSet<ExpedienteEstadoTpnRecepcion> ExpedienteEstadoTpnRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoTpnFinalizacion> ExpedienteEstadoTpnFinalizacionSet { get; set; }

        #endregion

        #region Saneamiento

        public DbSet<ExpedienteSaneamiento> ExpedienteSaneamientoSet { get; set; }

        public DbSet<ExpedienteEstadoSaneamientoRecepcion> ExpedienteEstadoSaneamientoRecepcionSet { get; set; }
        //public DbSet<ExpedienteEstadoSaneamientoPresentacionDemanda> ExpedienteEstadoSaneamientoPresentacionDemandaSet { get; set; }
        //public DbSet<ExpedienteEstadoSaneamientoTramitacionJuzgado> ExpedienteEstadoSaneamientoTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoSaneamientoFinalizacion> ExpedienteEstadoSaneamientoFinalizacionSet { get; set; }

        #endregion

        #region Concursal

        public DbSet<ConcursalComunicacionCredito> ConcursalComunicacionCreditoSet { get; set; }
        public DbSet<ConcursalGarantiaOtra> ConcursalGarantiaOtraSet { get; set; }
        public DbSet<ConcursalConvenioDesglose> ConcursalConvenioDesgloseSet { get; set; }
        public DbSet<ConcursalConvenioDesglosePago> ConcursalConvenioDesglosePagoSet { get; set; }

        public DbSet<Con_Expediente> Con_Expediente { get; set; }
        public DbSet<Con_ExpedienteAdministrador> Con_ExpedienteAdministrador { get; set; }
        public DbSet<Con_ExpedienteCredito> Con_ExpedienteCredito { get; set; }
        public DbSet<Con_ExpedienteCreditoCalificacion> Con_ExpedienteCreditoCalificacion { get; set; }
        public DbSet<Con_ExpedienteCreditoGarantiaAvalista> Con_ExpedienteCreditoGarantiaAvalista { get; set; }
        public DbSet<Con_ExpedienteCreditoGarantiaInmuebles> Con_ExpedienteCreditoGarantiaInmuebles { get; set; }
        public DbSet<Con_ExpedienteCreditoGarantiaOtros> Con_ExpedienteCreditoGarantiaOtros { get; set; }

        public DbSet<Con_ExpedienteEstadoComun> Con_ExpedienteEstadoComun { get; set; }
        public DbSet<Con_ExpedienteEstadoConvenio> Con_ExpedienteEstadoConvenio { get; set; }
        public DbSet<Con_ExpedienteEstadoFinalizado> Con_ExpedienteEstadoFinalizado { get; set; }
        public DbSet<Con_ExpedienteEstadoLiquidacion> Con_ExpedienteEstadoLiquidacion { get; set; }
        public DbSet<Con_ExpedienteEstadoLiquidacionLote> Con_ExpedienteEstadoLiquidacionLote { get; set; }
        public DbSet<Con_ExpedienteIncidente> Con_ExpedienteIncidente { get; set; }
        public DbSet<Con_TipoCalificacion> Con_TipoCalificacion { get; set; }
        public DbSet<Con_TipoCalificacionTiempo> Con_TipoCalificacionTiempo { get; set; }
        public DbSet<Con_TipoFase> Con_TipoFase { get; set; }
        public DbSet<Con_TipoIncidente> Con_TipoIncidente { get; set; }

        #endregion

        #region Civil

        public DbSet<ExpedienteCivil> ExpedienteCivilSet { get; set; }
        public DbSet<ExpedienteEstadoCivilRecepcion> ExpedienteEstadoCivilRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoCivilFinalizacion> ExpedienteEstadoCivilFinalizacionSet { get; set; }

        public DbSet<ExpedienteMercantilInmobiliario> ExpedienteMercantilInmobiliarioSet { get; set; }
        public DbSet<ExpedienteEstadoMercantilInmobiliarioRecepcion> ExpedienteEstadoMercantilInmobiliarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoMercantilInmobiliarioFinalizacion> ExpedienteEstadoMercantilInmobiliarioFinalizacionSet { get; set; }

        public DbSet<ExpedienteDdl> ExpedienteDdlSet { get; set; }
        public DbSet<ExpedienteEstadoDdlRecepcion> ExpedienteEstadoDdlRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoDdlFinalizacion> ExpedienteEstadoDdlFinalizacionSet { get; set; }

        public DbSet<ExpedienteContenciosoAdministrativo> ExpedienteContenciosoAdministrativoSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoAdministrativoRecepcion> ExpedienteEstadoContenciosoAdministrativoRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoAdministrativoFinalizacion> ExpedienteEstadoContenciosoAdministrativoFinalizacionSet { get; set; }

        public DbSet<ExpedienteContenciosoOrdinario> ExpedienteContenciosoOrdinarioSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoOrdinarioRecepcion> ExpedienteEstadoContenciosoOrdinarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoOrdinarioFinalizacion> ExpedienteEstadoContenciosoOrdinarioFinalizacionSet { get; set; }

        public DbSet<ExpedienteCambiario> ExpedienteCambiarioSet { get; set; }
        public DbSet<ExpedienteEstadoCambiarioRecepcion> ExpedienteEstadoCambiarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoCambiarioFinalizacion> ExpedienteEstadoCambiarioFinalizacionSet { get; set; }

        #endregion

        #region Penal 

        public DbSet<ExpedientePenal> ExpedientePenalSet { get; set; }

        public DbSet<ExpedienteEstadoPenalRecepcion> ExpedienteEstadoPenalRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoPenalFinalizacion> ExpedienteEstadoPenalFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoPenal> ExpedienteEstadoPenalSet { get; set; }
        public DbSet<Auto> AutoSet { get; set; }
        public DbSet<ExpedientePropuesta> ExpedientePropuestaSet { get; set; }

        public DbSet<ExpedienteAbogado> ExpedienteAbogadoSet { get; set; }
        public DbSet<ExpedienteCliente> ExpedienteClienteSet { get; set; }

        #endregion

        #region Facturacion y tiempos medios

        public DbSet<TipoHitoProcesal> TipoHitoProcesalSet { get; set; }
        public DbSet<TipoHitoProcesalTiempoMedio> TipoHitoProcesalTiempoMedioSet { get; set; }
        public DbSet<ClienteFacturaHitoProcesal> ClienteFacturaHitoProcesalSet { get; set; }

        #endregion

        #region Fiscal 

        public DbSet<ExpedienteFiscal> ExpedienteFiscalSet { get; set; }

        public DbSet<ExpedienteEstadoFiscalRecepcion> ExpedienteEstadoFiscalRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoFiscalFinalizacion> ExpedienteEstadoFiscalFinalizacionSet { get; set; }
        //public DbSet<ExpedienteEstadoFiscal> ExpedienteEstadoFiscalSet { get; set; }
        //public DbSet<Auto> AutoSet { get; set; }
        //public DbSet<ExpedientePropuesta> ExpedientePropuestaSet { get; set; }

        //public DbSet<ExpedienteAbogado> ExpedienteAbogadoSet { get; set; }
        //public DbSet<ExpedienteCliente> ExpedienteClienteSet { get; set; }

        #endregion

        #region Conciliacion 

        public DbSet<ExpedienteConciliacion> ExpedienteConciliacionSet { get; set; }
        public DbSet<ExpedienteEstadoConciliacionRecepcion> ExpedienteEstadoConciliacionRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoConciliacionFinalizacion> ExpedienteEstadoConciliacionFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoConciliacionActo> ExpedienteEstadoConciliacionActoSet { get; set; }

        #endregion

        #region JuraCuenta 

        public DbSet<ExpedienteJuraCuenta> ExpedienteJuraCuentaSet { get; set; }

        public DbSet<ExpedienteEstadoJuraCuentaRecepcion> ExpedienteEstadoJuraCuentaRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoJuraCuentaFinalizacion> ExpedienteEstadoJuraCuentaFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoJuraCuentaTramitacion> ExpedienteEstadoJuraCuentaTramitacionSet { get; set; }

        //public DbSet<Auto> AutoSet { get; set; }
        //public DbSet<ExpedientePropuesta> ExpedientePropuestaSet { get; set; }
        //public DbSet<ExpedienteAbogado> ExpedienteAbogadoSet { get; set; }
        //public DbSet<ExpedienteCliente> ExpedienteClienteSet { get; set; }

        #endregion

        #region Migrados de DB First - Code First

        public DbSet<Procura> ProcuraSet { get; set; }
        public DbSet<AccionFlujo> AccionFlujoes { get; set; }
        public DbSet<AlertaDestinatario> AlertaDestinatarios { get; set; }
        public DbSet<AlertaSupervisor> AlertaSupervisors { get; set; }
        public DbSet<Alq_Expediente> Alq_Expedientes { get; set; }
        public DbSet<Alq_Expediente_Contrato> Alq_Expediente_Contratos { get; set; }
        public DbSet<Alq_Expediente_Contratos_Deuda_Lineas> Alq_Expediente_Contratos_Deuda_Lineas { get; set; }
        public DbSet<Alq_Expediente_Contratos_PlanPagos_Lineas> Alq_Expediente_Contratos_PlanPagos_Lineas { get; set; }
        public DbSet<Alq_Expediente_EstadoAdjudicacion> Alq_Expediente_EstadoAdjudicacion { get; set; }
        public DbSet<Alq_Expediente_EstadoFinalizacion> Alq_Expediente_EstadoFinalizaciones { get; set; }
        public DbSet<Alq_Expediente_EstadoLanzamiento> Alq_Expediente_EstadoLanzamientos { get; set; }
        public DbSet<Alq_Expediente_EstadoPresentacionDemanda> Alq_Expediente_EstadoPresentacionDemandas { get; set; }
        public DbSet<Alq_Expediente_EstadoRecepcion> Alq_Expediente_EstadoRecepciones { get; set; }
        public DbSet<Alq_Expediente_EstadoTramitaJuzgado> Alq_Expediente_EstadoTramitaJuzgadoSet { get; set; }
        public DbSet<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> Alq_Expediente_EstadoTramitaJuzgado_ActuacionSet { get; set; }
        public DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public DbSet<aspnet_Users> aspnet_Users { get; set; }
        public DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }

        public DbSet<Configuracion> Configuracions { get; set; }
        public DbSet<Departamento> DepartamentoSet { get; set; }

        public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<ExpedienteAccion> ExpedienteAccions { get; set; }
        public DbSet<ExpedienteAcreedore> ExpedienteAcreedores { get; set; }
        public DbSet<ExpedienteAlerta> ExpedienteAlertas { get; set; }
        public DbSet<ExpedienteDeudor> ExpedienteDeudors { get; set; }
        //public DbSet<ExpedienteDocumento> ExpedienteDocumentoes { get; set; }
        public DbSet<ExpedienteEstado> ExpedienteEstadoes { get; set; }
        public DbSet<ExpedienteFactura> ExpedienteFacturaSet { get; set; }
        public DbSet<ExpedienteGastoSuplido> ExpedienteGastoSuplidoSet { get; set; }
        public DbSet<ExpedienteCobro> ExpedienteCobroSet { get; set; }
        public DbSet<ExpedienteGasto> ExpedienteGastoes { get; set; }
        public DbSet<ExpedienteIngreso> ExpedienteIngresoes { get; set; }

        public DbSet<ExpedienteVista> ExpedienteVistaSet { get; set; }
        public DbSet<ExpedienteTituloEjecutivo> ExpedienteTituloEjecutivoSet { get; set; }

        public DbSet<Factura> FacturaSet { get; set; }
        public DbSet<FileRecord> FileRecords { get; set; }
        public DbSet<Gnr_Abogado> Gnr_Abogado { get; set; }
        public DbSet<AbogadoFacturacion> AbogadoFacturacionSet { get; set; }
        public DbSet<Gnr_Cliente> Gnr_Cliente { get; set; }
        public DbSet<ClienteObjetivo> ClienteObjetivoSet { get; set; }
        public DbSet<Gnr_ClienteOficina> Gnr_ClienteOficina { get; set; }
        public DbSet<Pagador> PagadorSet { get; set; }
        public DbSet<ClienteTipoExpedienteConfiguracion> ClienteTipoExpedienteConfiguracionSet { get; set; }
        public DbSet<Gnr_ListasValores_Listas> Gnr_ListasValores_ListasSet { get; set; }
        public DbSet<Gnr_ListasValores_Valores> Gnr_ListasValores_Valores { get; set; }
        public DbSet<Gnr_Persona> Gnr_Persona { get; set; }
        public DbSet<Gnr_PersonaDireccion> Gnr_PersonaDireccion { get; set; }
        public DbSet<Gnr_PersonaExpediente> Gnr_PersonaExpediente { get; set; }
        public DbSet<Gnr_PersonaTelefono> Gnr_PersonaTelefono { get; set; }
        public DbSet<Gnr_PlantillasDoc> Gnr_PlantillasDoc { get; set; }
        public DbSet<Gnr_Procurador> Gnr_Procurador { get; set; }
        public DbSet<GNR_Procuradores> GNR_Procuradores { get; set; }
        public DbSet<Gnr_TipoAlerta> Gnr_TipoAlerta { get; set; }
        public DbSet<Gnr_TipoArea> Gnr_TipoArea { get; set; }
        public DbSet<Gnr_TipoDeudor> Gnr_TipoDeudor { get; set; }
        public DbSet<Gnr_TipoDireccion> Gnr_TipoDireccion { get; set; }
        public DbSet<Gnr_TipoEstado> Gnr_TipoEstado { get; set; }
        public DbSet<Gnr_TipoEstadoCliente> Gnr_TipoEstadoClienteSet { get; set; }
        public DbSet<Gnr_TipoEstadoMotivo> Gnr_TipoEstadoMotivoSet { get; set; }
        public DbSet<Gnr_TipoExpediente> Gnr_TipoExpediente { get; set; }
        public DbSet<Gnr_TipoExpedienteDocumento> Gnr_TipoExpedienteDocumento { get; set; }
        public DbSet<Gnr_TipoIdentidad> Gnr_TipoIdentidad { get; set; }
        public DbSet<Gnr_TipoPersona> Gnr_TipoPersona { get; set; }
        public DbSet<Gnr_TipoTelefono> Gnr_TipoTelefono { get; set; }
        public DbSet<Gnr_TipoTratamiento> Gnr_TipoTratamiento { get; set; }
        //public DbSet<Gnr_Valija> Gnr_Valija { get; set; }
        public DbSet<Hip_Expediente> Hip_Expediente { get; set; }
        public DbSet<Hip_ExpedienteEstadoAdjudicacion> Hip_ExpedienteEstadoAdjudicacion { get; set; }
        public DbSet<Hip_ExpedienteEstadoDatoRequerimiento> Hip_ExpedienteEstadoDatoRequerimiento { get; set; }
        public DbSet<Hip_ExpedienteEstadoFinalizacion> Hip_ExpedienteEstadoFinalizacion { get; set; }
        public DbSet<Hip_ExpedienteEstadoNegociacionPosesion> Hip_ExpedienteEstadoNegociacionPosesionSet { get; set; }
        public DbSet<HipExpedienteEstadoPresentacionDemanda> Hip_ExpedienteEstadoPresentacionDemanda { get; set; }
        public DbSet<Hip_ExpedienteEstadoProcesoParalizado> Hip_ExpedienteEstadoProcesoParalizado { get; set; }
        public DbSet<HipExpedienteEstadoRecepcion> Hip_ExpedienteEstadoRecepcion { get; set; }
        public DbSet<Hip_ExpedienteEstadoSubasta> Hip_ExpedienteEstadoSubasta { get; set; }
        public DbSet<HipExpedienteEstadoTramitacionSubasta> Hip_ExpedienteEstadoTramitacionJuzgado { get; set; }
        public DbSet<Hip_ExpedienteGarantia> Hip_ExpedienteGarantia { get; set; }
        public DbSet<Hip_Hipoteca> Hip_Hipoteca { get; set; }
        public DbSet<Hip_HipotecaDatoEscritura> Hip_HipotecaDatoEscritura { get; set; }
        public DbSet<Hip_HipotecaPagoACuenta> Hip_HipotecaPagoACuenta { get; set; }
        public DbSet<Hip_Inmueble> Hip_Inmueble { get; set; }
        public DbSet<Inmueble> InmuebleSet { get; set; }
        public DbSet<InmuebleNota> InmuebleNotaSet { get; set; }
        public DbSet<InmuebleContacto> InmuebleContactoSet { get; set; }
        public DbSet<InmuebleOferta> InmuebleOfertaSet { get; set; }
        public DbSet<InmuebleContrato> InmuebleContratoSet { get; set; }
        public DbSet<InmuebleEstado> InmuebleEstadoSet { get; set; }
        public DbSet<HipInmuebleNota> HipInmuebleNotaSet { get; set; }

        public DbSet<PartidoJudicial> PartidoJudicialSet { get; set; }
        public DbSet<HIP_PartidosJudiciales> HIP_PartidosJudiciales { get; set; }
        public DbSet<Hip_TipoDemanda> Hip_TipoDemanda { get; set; }
        public DbSet<Hip_TipoInmueble> Hip_TipoInmueble { get; set; }
        public DbSet<Hip_TipoLugarEjecucion> Hip_TipoLugarEjecucion { get; set; }
        public DbSet<Hip_TipoPeriodicidad> Hip_TipoPeriodicidad { get; set; }
        public DbSet<Hip_TipoReferenciaHipotecaria> Hip_TipoReferenciaHipotecaria { get; set; }
        public DbSet<Hip_TipoSubasta> Hip_TipoSubasta { get; set; }
        public DbSet<Hip_TipoTitulizado> Hip_TipoTitulizado { get; set; }
        public DbSet<Hip_TitularInmueble> Hip_TitularInmueble { get; set; }
        public DbSet<Mnt_Expediente> Mnt_Expediente { get; set; }
        public DbSet<Neg_Gestion> Neg_Gestiones { get; set; }
        public DbSet<Neg_GestionEstado> Neg_GestionEstados { get; set; }
        public DbSet<ProcuradoresCliente> ProcuradoresClientes { get; set; }
        public DbSet<ProcuradorPartidoJudicial> ProcuradorPartidoJudicialSet { get; set; }
        public DbSet<PropuestaComercial> PropuestaComercials { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TipoAccion> TipoAccions { get; set; }
        public DbSet<TipoCalificacionCreditoTiempo> TipoCalificacionCreditoTiempoes { get; set; }
        public DbSet<TipoClasificacionCredito> TipoClasificacionCreditoes { get; set; }
        public DbSet<TipoExpedienteAccion> TipoExpedienteAccions { get; set; }
        public DbSet<TipoFormaPago> TipoFormaPagoes { get; set; }
        public DbSet<TipoGarantia> TipoGarantias { get; set; }
        public DbSet<TipoVista> TipoVistaSet { get; set; }

        public DbSet<SolicitudDocumental> SolicitudDocumentalSet { get; set; }

        public DbSet<Hip_Hipoteca_EnEjecucion_View> Hip_Hipoteca_EnEjecucion_View { get; set; }
        public DbSet<vAlq_DEMANDA> vAlq_DEMANDA { get; set; }
        public DbSet<vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLast> vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLastSet { get; set; }
        public DbSet<vAlq_InformeTotalP> vAlq_InformeTotalP { get; set; }
        public DbSet<vExpedienteDeudorPrincipal> vExpedienteDeudorPrincipals { get; set; }
        public DbSet<vGnr_NombresCampos> vGnr_NombresCampos { get; set; }
        public DbSet<vGnr_PlantillaDoc_ALQUILER_BUROFAX> vGnr_PlantillaDoc_ALQUILER_BUROFAX { get; set; }
        public DbSet<vHip_HipotecaEnEjecucion> vHip_HipotecaEnEjecucion { get; set; }
        public DbSet<vHipotecaPrincipal> vHipotecaPrincipals { get; set; }
        public DbSet<View_1> View_1 { get; set; }
        public DbSet<View_5> View_5 { get; set; }
        public DbSet<vInmueblePrincipal> vInmueblePrincipals { get; set; }
        public DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        public DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        public DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        public DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        public DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }

        #endregion

        #region Recursos Humanos

        public DbSet<Candidato> CandidatoSet { get; set; }
        public DbSet<UsuarioExperiencia> UsuarioExperienciaSet { get; set; }
        public DbSet<UsuarioFormacion> UsuarioFormacionSet { get; set; }
        public DbSet<UsuarioIdioma> UsuarioIdiomaSet { get; set; }
        public DbSet<UsuarioInformatica> UsuarioInformaticaSet { get; set; }
        public DbSet<UsuarioAreasDominio> UsuarioAreasDominioSet { get; set; }
        public DbSet<UsuarioRetribucion> UsuarioRetribucionSet { get; set; }
        public DbSet<UsuarioEvaluacion> UsuarioEvaluacionSet { get; set; }

        #endregion

        #region Tmp

        public DbSet<TmpNegociacionAliseda> TmpNegociacionAlisedaSet { get; set; }

        #endregion

        #region CRM

        public DbSet<Oportunidad> OportunidadSet { get; set; }
        public DbSet<Contacto> ContactoSet { get; set; }
        public DbSet<OportunidadContacto> OportunidadContactoSet { get; set; }
        public DbSet<OportunidadUsuario> OportunidadUsuarioSet { get; set; }
        public DbSet<Tarea> TareaSet { get; set; }
        public DbSet<TareaServicioBufete> TareaServicioBufeteSet { get; set; }
        public DbSet<Nota> NotaSet { get; set; }
        public DbSet<Contrato> ContratoSet { get; set; }
        public DbSet<Comite> ComiteSet { get; set; }
        public DbSet<ServicioBufete> ServicioBufeteSet { get; set; }
        public DbSet<ClienteServicioBufete> ClienteServicioBufeteSet { get; set; }

        #endregion

        #region FichaNegocio

        public DbSet<FichaNegocio> FichaNegocioSet { get; set; }
        public DbSet<FichaNegocioMes> FichaNegocioMesSet { get; set; }

        public DbSet<PeriodoSemana> PeriodoSemanaSet { get; set; }
        public DbSet<Division> DivisionSet { get; set; }
        public DbSet<DivisionPlan> DivisionPlanSet { get; set; }
        public DbSet<DivisionReal> DivisionRealSet { get; set; }

        #endregion

        #region Inmuebles y Carteras

        public DbSet<CarteraInmobiliaria> CarteraInmobiliariaSet { get; set; }
        public DbSet<CarteraInmueble> CarteraInmuebleSet { get; set; }

        public DbSet<Asset> AssetSet { get; set; }

        #endregion

        #region CAU / RegistroComunicacion

        public DbSet<Tiket> TiketSet { get; set; }
        public DbSet<RegistroComunicacion> RegistroComunicacionSet { get; set; }

        #endregion

        #region LOGs

        public DbSet<LogEstadoSubfase> LogEstadoSubfaseSet { get; set; }

        public DbSet<LogKpiAbogado> LogKpiAbogadoSet { get; set; }

        #endregion

        #region Evaluacion del Desempeño

        public DbSet<EvaluacionEmpleado> EvaluacionEmpleadoSet { get; set; }
        public DbSet<EvaluacionEmpleadoObjetivo> EvaluacionEmpleadoObjetivoSet { get; set; }
        public DbSet<EvaluacionEmpleadoCompetencia> EvaluacionEmpleadoCompetenciaSet { get; set; }

        public DbSet<EvaluacionCompetencia> EvaluacionCompetenciaSet { get; set; }
        public DbSet<EvaluacionCompetenciaGrupo> EvaluacionCompetenciaGrupoSet { get; set; }

        #endregion
    }

    //public class ExpedienteOrdinarioMap : IEntityTypeConfiguration<ExpedienteOrdinario>
    //{
    //    public ExpedienteOrdinarioMap()
    //    {
    //        //HasRequired(t => t.Expediente)//  .WithOptional(t => t.ExpedienteOrdinario);
    //    }
    //}
}
