export class CaracteristicaBase {
  id: number = 0;
  nombre: string = '';
  grupo: string = '';
  codigo: string = '';
  orden: number = 0;
  activo: boolean = false;
  fechaAlta: Date = new Date();

  constructor(item?: Partial<CaracteristicaBase>) {
    if (!!item) Object.assign(this, item);
  }
}
export class ModelDtoNombre {
  id: number = 0;
  nombre: string = '';

  constructor(item?: Partial<ModelDtoNombre>) {
    if (!!item) Object.assign(this, item);
  }
}
