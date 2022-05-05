import { DtoIdNombre } from './common.model';

export class Expediente {
  idExpediente: number = 0;
  noExpediente: string = '';
  referenciaExterna: string = '';
  referencia2: string = '';
  referenciaJudicial: string = '';
  clienteOficina: string = '';

  tipoExpediente: number = 1;

  idClienteOficina: number = 0;
  idTipoArea: number = 0;
  IdProcurador?: number;
  idAbogado?: number;
  idAccionPropuesta?: number;
  idJuzgado?: number;
  idPartidoJudicial?: number;
  idExpedienteNegociacion?: number;
  idExpedienteFather?: number;
  idExpedienteSon?: number;
  idExpedienteBrother?: number;
  idEstadoLast?: number;
  idExpedienteFaseClienteLast?: number;
  idExpedienteSubastaLast?: number;
  idDeudorPrincipal?: number;
  idAreaNegocio?: number;
  idCartera?: number;
  idTipoExpediente: number = 0;

  idVeniadoHitoFacturacion?: number;
  idSucesionCausaIncidencia?: number;
  idSucesionEstadoProcesalCliente?: number;
  idSucesionProblemasDetalles?: number;
  idSubTipoProcedimiento?: number;
  deudaFinal?: number;
  importeAdmision?: number; //Readonly
  importePreFactura?: number; //Readonly
  sucesionResultadoRecuso?: number; ////TipoResultadoApelacion? Enum

  refKmaleon: string = '';
  noAuto: string = '';
  referenciaReoco: string = '';
  nic: string = '';
  avisoImportante: string = '';
  gestorCliente: string = '';
  origen: string = '';
  contratoRef: string = '';

  inicio: Date | undefined;
  fin?: Date | undefined;
  finPrevisto?: Date | undefined;
  fechaAlta: Date = new Date();
  fechaModificacion: Date = new Date();

  archivado?: Date | undefined;
  fechaCierre?: Date | undefined;
  fechaHitoInicio?: Date | undefined;
  fechaHitoFin?: Date | undefined;
  fechaHito1?: Date | undefined;
  fechaHito2?: Date | undefined;
  fechaHito3?: Date | undefined;
  sucesionPresentada?: Date | undefined;
  sucesionAcordada?: Date | undefined;
  sucesionCopiaSellada?: Date | undefined;
  sucesionDenegada?: Date | undefined;
  sucesionRecurrida?: Date | undefined;
  fechaCargaAppCliente?: Date | undefined;

  servicioIntegral: boolean = false;
  paralizado: boolean = false;
  esHeredado: boolean = false;
  esRelevante: boolean = false;
  esConfidencial: boolean = false;
  inactivoInterno: boolean = false;
  esNofacturable: boolean = false;
  facturacionCompleta: boolean = false;
  sucesionOposicion: boolean = false;

  constructor(item?: Partial<Expediente>) {
    if (!!item) Object.assign(this, item);
  }
}

// public TipoExpedienteEnum  { get; set; }

export class ModelExpediente {
  idExpediente: number = 0;
  deudaFinal: number = 0;
  idEstadoLast: number = 0;

  noExpediente: string = '';
  referenciaExterna: string = '';
  noAuto: string = '';

  inicio: Date | undefined;
  fin: Date | undefined;
  fechaAlta: Date | undefined;

  clienteOficina!: DtoIdNombre;
  deudor!: DtoIdNombre;
  abogado!: DtoIdNombre;
  oficina!: DtoIdNombre;
  tipoExpediente!: DtoIdNombre;
  juzgado!: DtoIdNombre;

  estado!: EstadoDtoMin;

  constructor(item?: Partial<ModelExpediente>) {
    if (!!item) Object.assign(this, item);
  }
}

export class EstadoDtoMin {
  idExpedienteEstado: number = 0;
  fecha: Date | undefined;
  tipo!: DtoIdNombre;

  constructor(item?: Partial<EstadoDtoMin>) {
    if (!!item) Object.assign(this, item);
  }
}
