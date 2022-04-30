export class Expediente {
  idExpediente: number = 0;
  noExpediente: string = '';
  referenciaExterna: string = '';
  referencia2: string = '';
  referenciaJudicial: string = '';
  clienteOficina: string = '';
  tipoExpediente: number = 1;
  // activo: boolean = false;
  inicio: Date | undefined;
  fin: Date | undefined;
  finPrevisto: Date | undefined;

  constructor(item?: Partial<Expediente>) {
    if (!!item) Object.assign(this, item);
  }
}

// public TipoExpedienteEnum  { get; set; }

export class ModelExpediente {
  idExpediente: number = 0;
  noExpediente: string = '';
  referenciaExterna: string = '';
  clienteOficina: string = '';
  tipoExpediente: number = 1;
  // activo: boolean = false;
  inicio: Date | undefined;
  fin: Date | undefined;

  constructor(item?: Partial<Expediente>) {
    if (!!item) Object.assign(this, item);
  }
}
