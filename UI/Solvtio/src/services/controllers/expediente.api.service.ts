// import { ApiService } from '../api.service';
import { FilterBase } from '../../models/search/baseSearch.model';
// import { EmployeeSearch } from '../../models/search/employeeSearch.model';
// import { CommunitySearch, Employee, OfficeSearch } from 'src/models';
// import * as _ from 'underscore';

///api/Expediente/GetWithPagination

import {
  Expediente,
  ExpedienteDeudorDto,
  ExpedienteEstadoDto,
  ExpedienteNotaDto,
  ExpedienteSearch,
  KpiInfo,
  PaginationFilter,
} from 'src/models';
import { ApiService } from '../api.service';

export class ExpedienteApiService {
  constructor(private api: ApiService) {}
  private path = 'api/Expediente';
  private pathApi = this.api.environment.apiUrl + 'Expediente';

  public async get(search: ExpedienteSearch): Promise<ExpedienteSearch> {
    //return new ExpedienteSearch(await this.api.post(`${this.api.environment.apiUrl}${this.path}SearchEmployees`, search))

    return new ExpedienteSearch({
      ...new ExpedienteSearch(),
      ...{ result: await this.api.get(this.pathApi) },
    });
  }

  public async getPaginated(
    paginationFilter: PaginationFilter
  ): Promise<ExpedienteSearch> {
    if (paginationFilter.pagination.pageNumber === 0)
      paginationFilter.pagination.pageNumber = 1;

    console.log(paginationFilter);

    //$http.post("items/uploadItem", formData, {headers: { "Content-Type": undefined }})

    return new ExpedienteSearch(
      await this.api.post(`${this.pathApi}/GetWithPagination`, paginationFilter)
    );
  }

  public async getDashboardKpi(filter: FilterBase): Promise<KpiInfo[]> {
    if (filter.idTipo1 === 0) filter.idTipo1 = 1;

    return await this.api.post(`${this.pathApi}/GetDashboardKpi`, filter);
  }

  public async getById(id: string): Promise<Expediente> {
    const item: Expediente = await this.api.get(`${this.pathApi}/${id}`);
    return new Expediente(item);
  }

  public async getIdExpedienteByNo(noExp: string): Promise<number> {
    return await this.api.get(
      `${this.pathApi}/GetIdExpedienteByNo?noExpediente=${noExp}`
    );
  }

  public async create(item: Expediente) {
    return this.api.post<Expediente>(this.pathApi, item);
  }

  public async udpate(item: Expediente) {
    console.log('ready for update Expediente:');

    return this.api.put<Expediente>(
      `${this.pathApi}/${item.idExpediente}`,
      item
    );
  }

  public async delete(id: string) {
    return this.api.delete(`${this.pathApi}/${id}`);
  }

  public async getEstadoActual(
    idExpediente: number
  ): Promise<ExpedienteEstadoDto> {
    return await this.api.get(
      `${this.pathApi}/GetEstadoActual?id=${idExpediente}`
    );
  }

  public async getNotas(idExpediente: number): Promise<ExpedienteNotaDto[]> {
    return await this.api.get(
      `${this.pathApi}/GetNotas?idExpediente=${idExpediente}`
    );
  }

  public async getNotasByEstado(
    idExpedienteEstado: number
  ): Promise<ExpedienteNotaDto[]> {
    return await this.api.get(
      `${this.pathApi}/GetExpedienteNotaByEstado?idExpedienteEstado=${idExpedienteEstado}`
    );
  }

  public async getNotaById(
    idExpedienteNota: number
  ): Promise<ExpedienteNotaDto> {
    if (idExpedienteNota == 0) return new ExpedienteNotaDto();
    //http://localhost:40274/api/Expediente/NotaGetById?idExpedienteNota=1

    const item: ExpedienteNotaDto = await this.api.get(
      `${this.pathApi}/NotaGetById?idExpedienteNota=${idExpedienteNota}`
    );
    return new ExpedienteNotaDto(item);
  }

  public async notaUdpate(item: ExpedienteNotaDto) {
    ///api/Expediente/NotaUpdate
    console.log('ready for update ExpedienteNotaDto:');

    return this.api.put<ExpedienteNotaDto>(`${this.pathApi}/NotaUpdate`, item);
  }

  public async notaAdd(idExpediente: number, item: ExpedienteNotaDto) {
    item.idExpediente = idExpediente;
    return this.api.post<ExpedienteNotaDto>(`${this.pathApi}/NotaAdd`, item);
  }

  public async notaDelete(id: number) {
    //http://localhost:40274/api/Expediente/NotaDelete?idExpedienteNota=-1
    return this.api.delete(`${this.pathApi}/NotaDelete?idExpedienteNota=${id}`);
  }

  public async getDeudores(
    idExpediente: number
  ): Promise<ExpedienteDeudorDto[]> {
    return await this.api.get(
      `${this.pathApi}/GetDeudores?idExpediente=${idExpediente}`
    );
  }

  public async getDeudorById(
    idExpedienteDeudor: number
  ): Promise<ExpedienteDeudorDto> {
    if (idExpedienteDeudor == 0) return new ExpedienteDeudorDto();

    const item: ExpedienteDeudorDto = await this.api.get(
      `${this.pathApi}/DeudorGetById?idExpedienteDeudor=${idExpedienteDeudor}`
    );
    return new ExpedienteDeudorDto(item);
  }

  public async deudorUdpate(item: ExpedienteDeudorDto) {
    return this.api.put<ExpedienteDeudorDto>(
      `${this.pathApi}/DeudorUpdate`,
      item
    );
  }

  public async deudorAdd(idExpediente: number, item: ExpedienteDeudorDto) {
    item.idExpediente = idExpediente;
    return this.api.post<ExpedienteDeudorDto>(
      `${this.pathApi}/DeudorAdd`,
      item
    );
  }

  public async deudorDelete(id: number) {
    return this.api.delete(
      `${this.pathApi}/DeudorDelete?idExpedienteDeudor=${id}`
    );
  }

  public async getEstados(
    idExpediente: number
  ): Promise<ExpedienteEstadoDto[]> {
    return await this.api.get(
      `${this.pathApi}/GetEstados?idExpediente=${idExpediente}`
    );
  }

  public async getEstadoById(
    idExpedienteEstado: number
  ): Promise<ExpedienteEstadoDto> {
    if (idExpedienteEstado == 0) return new ExpedienteEstadoDto();

    const item: ExpedienteEstadoDto = await this.api.get(
      `${this.pathApi}/EstadoGetById?idExpedienteEstado=${idExpedienteEstado}`
    );
    return new ExpedienteEstadoDto(item);
  }

  public async estadoAdd(idExpediente: number, item: ExpedienteEstadoDto) {
    item.idExpediente = idExpediente;
    return this.api.post<ExpedienteEstadoDto>(
      `${this.pathApi}/EstadoAdd`,
      item
    );
  }

  public async estadoDelete(id: number) {
    return this.api.delete(
      `${this.pathApi}/EstadoDelete?idExpedienteEstado=${id}`
    );
  }

  public async estadoUdpate(item: ExpedienteEstadoDto) {
    return this.api.put<ExpedienteEstadoDto>(
      `${this.pathApi}/EstadoUpdate`,
      item
    );
  }
}
