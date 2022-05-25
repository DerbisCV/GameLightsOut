import {
  CaracteristicaBase,
  CaracteristicaBaseSearch,
  DtoIdNombre,
  ModelDtoNombre,
} from 'src/models';
import { ApiService } from '../api.service';

export class NomencladorApiService {
  constructor(private api: ApiService) {}
  // private path = 'api/Nomenclador';
  private pathApi = this.api.environment.apiUrl + 'Nomenclador';

  public async tipoExpedienteGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/TipoExpedienteGetAll`);
  }
  public async tipoAreaGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/TipoAreaGetAll`);
  }

  public async clienteOficinaGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/ClienteOficinaGetAll`);
  }
  public async abogadoGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/AbogadoGetAll`);
  }
  public async procuradorGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/ProcuradorGetAll`);
  }

  public async juzgadoGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/JuzgadoGetAll`);
  }
  public async partidoJudicialGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/PartidoJudicialGetAll`);
  }
  public async carteraGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/CarteraGetAll`);
  }
  public async tipoNotaGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/TipoNotaGetAll`); //http://localhost:40274/api/Nomenclador/TipoNotaGetAll
  }
  public async tipoDeudorGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/TipoDeudorGetAll`); //http://localhost:40274/api/Nomenclador/TipoNotaGetAll
  }
  public async provinciasGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/ProvinciaGetAll`); //http://localhost:40274/api/Nomenclador/TipoNotaGetAll
  }
  public async municipiosByProvincia(
    idProvincia: number
  ): Promise<ModelDtoNombre[]> {
    return await this.api.get(
      `${this.pathApi}/MunicipiosByProvincia?idProvincia=${idProvincia}`
    );
  }

  public async getTipoSubFaseByEstado(
    estadoTipo: number
  ): Promise<DtoIdNombre[]> {
    return await this.api.get(
      `${this.pathApi}/GetTipoSubFaseByEstado?estadoTipo=${estadoTipo}`
    );
  }

  public async getTipoIncidenciaByEstado(
    estadoTipo: number
  ): Promise<DtoIdNombre[]> {
    return await this.api.get(
      `${this.pathApi}/GetTipoIncidenciaByEstado?estadoTipo=${estadoTipo}`
    );
  }

  public async getTipoEstadoMotivoByTipoEstado(
    estadoTipo: number
  ): Promise<DtoIdNombre[]> {
    return await this.api.get(
      `${this.pathApi}/GetTipoEstadoMotivoByTipoEstado?estadoTipo=${estadoTipo}`
    );
  }

  public async tipoEstadoGetAllByExpediente(
    idExpediente: number
  ): Promise<ModelDtoNombre[]> {
    return await this.api.get(
      `${this.pathApi}/TipoEstadoGetAllByExpediente?idExpediente=${idExpediente}`
    );
  }

  public async getCaracteristicaBaseByGrupo(
    grupo: string,
    soloActivos?: boolean
  ): Promise<ModelDtoNombre[]> {
    return await this.api.get(
      `${this.pathApi}/GetCaracteristicaBaseByGrupo?grupo=${grupo}&soloActivos=${soloActivos}`
    );
  }
  public async getPagadoresPorOficina(
    idClienteOficina?: number
  ): Promise<ModelDtoNombre[]> {
    return await this.api.get(
      `${this.pathApi}/GetPagadoresPorOficina?idClienteOficina=${idClienteOficina}`
    );
  }

  public async tipoSegmentoGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/TipoSegmentoGetAll`);
  }
  public async tipoRecepcionBurofaxMotivoGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(
      `${this.pathApi}/TipoRecepcionBurofaxMotivoGetAll`
    );
  }
  public async tipoEstadoClienteGetAll(): Promise<ModelDtoNombre[]> {
    return await this.api.get(`${this.pathApi}/TipoEstadoClienteGetAll`);
  }

  public async get(
    search: CaracteristicaBaseSearch
  ): Promise<CaracteristicaBaseSearch> {
    //return new CaracteristicaBaseSearch(await this.api.post(`${this.api.environment.apiUrl}${this.path}SearchEmployees`, search))

    return new CaracteristicaBaseSearch({
      ...new CaracteristicaBaseSearch(),
      ...{ result: await this.api.get(this.pathApi) },
    });
  }

  public async getById(id: string): Promise<CaracteristicaBase> {
    const item: CaracteristicaBase = await this.api.get(
      `${this.pathApi}/${id}`
    );
    return new CaracteristicaBase(item);
  }

  public async create(item: CaracteristicaBase) {
    return this.api.post<CaracteristicaBase>(this.pathApi, item);
  }

  public async udpate(item: CaracteristicaBase) {
    return this.api.put<CaracteristicaBase>(`${this.pathApi}/${item.id}`, item);
  }
  // public async udpate(item: CaracteristicaBase, id: number) {
  //   item.id = id;
  //   return this.api.put<CaracteristicaBase>(`${this.pathApi}/${id}`, item);
  // }

  public async delete(id: string) {
    return this.api.delete(`${this.pathApi}/${id}`);
  }
}
