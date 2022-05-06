export class DtoIdNombre {
  id: number = 0;
  nombre: string = '';

  constructor(item?: Partial<DtoIdNombre>) {
    if (!!item) Object.assign(this, item);
  }
}

export class PersonaDto {
  idPersona: number = 0;
  idTipoIdentidad: number | undefined = 0;
  nombre: string | undefined = '';
  apellidos: string | undefined = '';
  nombreApellidos: string | undefined = '';
  noDocumento: string | undefined = '';
  telefono: string | undefined = '';
  telefonosTodos: string | undefined = '';
  email: string | undefined = '';
  emailsTodos: string | undefined = '';
  direccion: string | undefined = '';
  codigoPostal: string | undefined = '';
  domicilioNotificacion: string | undefined = '';

  //"persona":{"telefonoPrincipal":null,},

  constructor(item?: Partial<PersonaDto>) {
    if (!!item) Object.assign(this, item);
  }
}
