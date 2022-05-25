export class EstadoAlqFinalizacionDto {
  idExpedienteEstado: number = 0;
  idMotivo?: number;

  pagoDeuda: boolean = false;
  entregaPosesion: boolean = false;
  desestimacionDemanda: boolean = false;
  llaves: boolean = false;
  enervacionJudicial: boolean = false;
  desestimientoJudicial: boolean = false;
  porAcuerdo: boolean = false;
  paralizacionInstCliente: boolean = false;
  mediacion: boolean = false;
  condonacionSinProceso: boolean = false;
  facturable: boolean = false;
  precontencioso: boolean = false;
  sentenciaEstimatoria: boolean = false;
  archivo: boolean = false;
  archivoProvisional: boolean = false;
  cesionVenia: boolean = false;

  constructor(item?: Partial<EstadoAlqFinalizacionDto>) {
    if (!!item) Object.assign(this, item);
  }
}
