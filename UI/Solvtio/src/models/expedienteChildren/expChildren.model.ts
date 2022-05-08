import { DtoIdNombre, PersonaDto } from '../common.model';

export class ExpedienteNotaDto {
  idExpedienteNota: number = 0;
  idExpediente: number = 0;
  idExpedienteEstado: number = 0;
  fecha: Date = new Date();
  tipo: DtoIdNombre = new DtoIdNombre();
  nota: string = '';
  usuario: string = '';
  noteType: number = 0;

  constructor(item?: Partial<ExpedienteNotaDto>) {
    if (!!item) Object.assign(this, item);
    // this.noteType = this.tipo;
    this.fecha = !!item?.fecha ? new Date(item.fecha) : new Date();
  }
}

export class ExpedienteDeudorDto {
  idExpedienteDeudor: number = 0;
  idExpediente: number = 0;

  gnr_TipoDeudor!: DtoIdNombre;
  provincia: DtoIdNombre | undefined = new DtoIdNombre();
  persona!: PersonaDto | undefined;

  domicilioNotificacion: string | undefined = '';
  abogadoNombre: string | undefined = '';
  abogadoDespacho: string | undefined = '';
  abogadoTelefono: string | undefined = '';

  constructor(item?: Partial<ExpedienteDeudorDto>) {
    if (!!item) Object.assign(this, item);
  }

  // [{"idExpedienteDeudor":11678,"gnr_TipoDeudor":{"id":1,"nombre":"Deudor Principal"},"provincia":null,
  //"persona":{"idPersona":2546,"nombre":"RAMON CUARESMA CUARESMA","apellidos":"","nombreApellidos":"RAMON CUARESMA CUARESMA ","idTipoIdentidad":0,"noDocumento":"43116569","telefono":null,"telefonosTodos":"","telefonoPrincipal":null,"email":null,"emailsTodos":"","direccion":null,"codigoPostal":null,"domicilioNotificacion":null},
  //"idExpediente":11662,"domicilioNotificacion":null,"abogadoNombre":null,"abogadoDespacho":null,"abogadoTelefono":null}]
}
