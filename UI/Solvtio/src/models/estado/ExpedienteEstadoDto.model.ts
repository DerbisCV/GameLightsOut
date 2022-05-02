import { ModelDtoNombre } from '../CaracteristicaBase.model';

export class ExpedienteEstadoDto {
  idExpedienteEstado: number = 0;
  idExpediente: number = 0;
  fecha: Date = new Date();
  tipoEstado: ModelDtoNombre = new ModelDtoNombre();

  constructor(item?: Partial<ExpedienteEstadoDto>) {
    if (!!item) Object.assign(this, item);
  }
}
