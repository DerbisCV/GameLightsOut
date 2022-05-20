import { ModelDtoNombre } from '../CaracteristicaBase.model';
import { DtoIdNombre } from '../common.model';

export class ExpedienteEstadoDto {
  idExpedienteEstado: number = 0;
  idExpediente: number = 0;
  idTipoEstado: number = 0;
  tipoEstado: DtoIdNombre = new DtoIdNombre();
  fecha: Date = new Date();
  fechaAlta: Date = new Date();
  fechaFin?: Date;
  fechaModificado?: Date;
  incidenciaFechaResolucion?: Date;

  observacion: string = '';
  usuario: string = '';
  idTipoSubFaseEstado?: number;
  idTipoSubFaseCliente?: number;
  idTipoIncidenciaEstado?: number;

  // public   { get; set; }
  // public int?  { get; set; }
  // public int?  { get; set; }
  // public int?  { get; set; }

  constructor(item?: Partial<ExpedienteEstadoDto>) {
    if (!!item) Object.assign(this, item);

    this.fecha = !!item?.fecha ? new Date(item.fecha) : new Date();
    this.fechaAlta = !!item?.fechaAlta ? new Date(item.fechaAlta) : new Date();
    if (!!item?.fechaFin) this.fechaFin = new Date(item.fechaFin);
    if (!!item?.fechaModificado)
      this.fechaModificado = new Date(item.fechaModificado);
    if (!!item?.incidenciaFechaResolucion)
      this.incidenciaFechaResolucion = new Date(item.incidenciaFechaResolucion);
  }
}
