export class DtoIdNombre {
  id: number = 0;
  nombre: string = '';

  constructor(item?: Partial<DtoIdNombre>) {
    if (!!item) Object.assign(this, item);
  }
}
