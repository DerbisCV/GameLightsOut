export class ExpedienteNotaDto {
  idExpedienteNota: number = 0;
  idExpediente: number = 0;
  idExpedienteEstado: number = 0;
  fecha: Date = new Date();
  nota: string = '';
  usuario: string = '';

  constructor(item?: Partial<ExpedienteNotaDto>) {
    if (!!item) Object.assign(this, item);
  }
}
